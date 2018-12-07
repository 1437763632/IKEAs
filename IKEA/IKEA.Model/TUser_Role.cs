using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 用户角色表
    /// </summary>
    public class TUser_Role
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
    }
}
