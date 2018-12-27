using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Model;
    using IServices;
    using Common;
    using Dapper;
    using MySql.Data.MySqlClient;
    public class User_Services: IUser_Services
    {
        public IEnumerable<TUser> Login()
        {
            
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("select * from TUser ");
                var result = conn.Query<TUser>(sql, null);
                return result.ToList<TUser>();
            }
        }

    }
}
