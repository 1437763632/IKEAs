using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 审批条件表
    /// </summary>
    public class Conditions
    {
        /// <summary>
        /// id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 审批ID
        /// </summary>
        public int ApprovalID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 条件范围
        /// </summary>
        public string ConditionRange { get; set; }
    }
}
