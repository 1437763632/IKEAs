using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 审批活动表
    /// </summary>
    public class ActiveFlow
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 申请人
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 申请角色
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// 审批ID
        /// </summary>
        public int ApprovalID { get; set; }
        /// <summary>
        /// 条件范围
        /// </summary>
        public string ConditionRange { get; set; }
        /// <summary>
        /// 具体条件
        /// </summary>
        public string ActualCondition { get; set; }
        /// <summary>
        /// 当前节点ID
        /// </summary>
        public int CurrentNodeID { get; set; }
        /// <summary>
        /// 当前审批角色
        /// </summary>
        public int CurrentRoleID { get; set; }
        /// <summary>
        /// 当前审批人
        /// </summary>
        public int CurrentUserID { get; set; }
        /// <summary>
        /// 当前备注
        /// </summary>
        public string CurrentRemark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public State State { get; set; } 
        /// <summary>
        /// 下一节点ID
        /// </summary>
        public int NextNodeID { get; set; }
    }
}
