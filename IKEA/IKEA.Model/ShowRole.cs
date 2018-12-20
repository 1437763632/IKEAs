using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
   public class ShowRole
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        [NotMapped]
        public int Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        [NotMapped]
        public string RoleName { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        [NotMapped]
        public string RightID { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        [NotMapped]
        public string RightName { get; set; }
    }
}
