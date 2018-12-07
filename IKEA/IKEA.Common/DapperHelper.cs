using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;

namespace IKEA.Common
{
   public class DapperHelper
    {
       
        public static string connString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;


        /// <summary>
        /// 获取连接数据库的字符串
        /// </summary>
        /// <returns></returns>
        public static MySql.Data.MySqlClient.MySqlConnection GetConnString()
        {
            return new MySql.Data.MySqlClient.MySqlConnection(connString);
        }
    }
}
