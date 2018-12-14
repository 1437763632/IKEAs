using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Common
{
    using Dapper;
    using MySql.Data.MySqlClient;
    using Model;
    using System.Net.Http;
    using Cache;
    using Newtonsoft.Json;
    using System.Configuration;

    public class TokenHelper
    {
        public TUser Logins(string code)
        {
            using (MySqlConnection connection = DapperHelper.GetConnString())
            {
                TUser user = new TUser();
                HttpClient httpclient = new HttpClient();
                //  string appid = "wx9cfd1269436269a8";
                // string secret = "4b62a45558a4aa06e717c73a2b3229ef";
                string appid = ConfigurationManager.AppSettings["appid"].ToString();
                string secret = ConfigurationManager.AppSettings["secret"].ToString();
                httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = httpclient.PostAsync("https://api.weixin.qq.com/sns/jscode2session?appid=" + appid + "&secret=" + secret + "&js_code=" + code.ToString() + "&grant_type=authorization_code", null).Result;
                var result = "";
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                }
                httpclient.Dispose();
                var results = JsonConvert.DeserializeObject<TUser>(result);
                user.OpenId = results.OpenId;
                user.session_key = results.session_key;//密钥
                var client = connection.Query<TUser>("select * from TUser where Session_Key ='" + user.session_key + "'", null);//判断是否为已注册用户
                if (client == null)
                {
                    connection.Execute("insert into TUser(OpenID,Session_Key) values('" + user.OpenId + "','" + user.session_key + "')", null);
                }
                RedisHelper.Set<TUser>(user.session_key, user, DateTime.Now.AddMinutes(10));
                return user;
            }
        }
    }
}
