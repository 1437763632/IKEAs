using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    public class ShowFlowControlConfig
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
        /// 角色拥有者
        /// </summary>
        public IEnumerable<TManage> Managers { get; set; }
        /// <summary>
        /// 审批ID
        /// </summary>
        public int ApprovalID { get; set; }
        /// <summary>
        /// 审批名称
        /// </summary>
        public string ApproveName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否可修改
        /// </summary>
        public bool IsModified { get; set; }
        /// <summary>
        /// 是否可撤销
        /// </summary>
        public bool IsCanceled { get; set; }
        /// <summary>
        /// 节点ID
        /// </summary>
        public int NodeID { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// 节点描述
        /// </summary>
        public string NodeDescription { get; set; }
        /// <summary>
        /// 节点负责角色
        /// </summary>
        public int NodeRole { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 条件ID
        /// </summary>
        public int ConditionID { get; set; }
        /// <summary>
        /// 条件范围
        /// </summary>
        public string ConditionRange { get; set; }
        /// <summary>
        /// 下一节点ID
        /// </summary>
        public int NextNodeID { get; set; }
        /// <summary>
        /// 下一节点名称
        /// </summary>
        public string NextNodeName { get; set; }
        /// <summary>
        /// 下一节点描述
        /// </summary>
        public string NextNodeDescription { get; set; }
        /// <summary>
        /// 下一节点负责角色
        /// </summary>
        public int NextNodeRole { get; set; }
        /// <summary>
        /// 下一角色名称
        /// </summary>
        public string NextRoleName { get; set; }
    }
}
