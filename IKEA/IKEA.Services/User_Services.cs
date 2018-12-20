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
        public TUser Login(string code)
        {
            var user= new TokenHelper().Logins(code);
            return user;
        }
    }
}
