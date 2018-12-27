using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using Model;
    public interface IUser_Services
    {
       IEnumerable<TUser>  Login();
    }
}
