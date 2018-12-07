using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 角色权限关系表
    /// </summary>
    public class TRole_Right
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public int RightID { get; set; }
    }
}
