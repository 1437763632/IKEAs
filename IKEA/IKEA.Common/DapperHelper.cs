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
        string connectionString = "Database=dappers;Data Source=127.0.0.1;User Id=root;Password=111111;CharSet=utf8;port=3306";
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
