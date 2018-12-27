using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 流程控制配置表
    /// </summary>
    public class FlowControlConfig
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 审批ID
        /// </summary>
        public int ApprovalID { get; set; }
        /// <summary>
        /// 节点ID
        /// </summary>
        public int NodeID { get; set; }
       
        /// <summary>
        /// 下一节点ID
        /// </summary>
        public int NextNodeID { get; set; }
    }
}
