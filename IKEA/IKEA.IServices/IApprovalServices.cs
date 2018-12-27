using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 审批接口层
    /// </summary>
    public interface IApprovalServices
    {
        /// <summary>
        /// 添加审批流程
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        int AddApproval(Approval approval);
        /// <summary>
        /// 查看所有流程信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<Approval> GetApprovals();
        /// <summary>
        /// 添加条件信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        int AddCondition(Conditions condition);
        /// <summary>
        /// 根据流程获取条件
        /// </summary>
        /// <param name="ApprovalID"></param>
        /// <returns></returns>
        IEnumerable<Conditions> GetConditionsBy(int ApprovalID);
        /// <summary>
        /// 根据流程和角色ID获取条件
        /// </summary>
        /// <param name="ApprovalID"></param>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        Conditions GetConditionsByReason(int ApprovalID, int RoleID);
        /// <summary>
        /// 添加节点信息
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int AddNode(Node node);
        /// <summary>
        /// 查询所有节点信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<Node> GetNodes();
        /// <summary>
        /// 添加流程配置信息
        /// </summary>
        /// <param name="flowControlConfig"></param>
        /// <returns></returns>
        int AddFlowControlConfig(FlowControlConfig flowControlConfig);
        /// <summary>
        /// 获取流程配置信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<ShowFlowControlConfig> GetFlowControlConfigs();
        /// <summary>
        /// 根据角色ID获取用户
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        IEnumerable<TManage> GetManages(int roleID);
        /// <summary>
        /// 添加活动表信息
        /// </summary>
        /// <param name="activeFlow"></param>
        /// <returns></returns>
        int AddActiveFlow(ActiveFlow activeFlow);
        /// <summary>
        /// 根据ID获取活动表信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ActiveFlow GetActiveFlow(int id);
        /// <summary>
        /// 通过角色ID获取活动表信息
        /// </summary>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        IEnumerable<ActiveFlow> GetActiveFlows(int roleID);
        /// <summary>
        /// 根据负责角色找活动表
        /// </summary>
        /// <param name="nodeID"></param>
        /// <returns></returns>
        IEnumerable<ActiveFlow> GetActiveFlowsByNode(int roleID);
        /// <summary>
        /// 修改活动表信息
        /// </summary>
        /// <param name="activeFlow"></param>
        /// <returns></returns>
        int UpdateActiveFlow(ActiveFlow activeFlow);
    }
}
