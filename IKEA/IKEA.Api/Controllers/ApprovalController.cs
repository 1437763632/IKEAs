using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IKEA.Api.Controllers
{
    using IKEA.Model;
    using IKEA.IServices;
    using IKEA.Services;
    using Unity.Attributes;
    /// <summary>
    /// 流程控制接口
    /// </summary>
    [RoutePrefix("Approval")]
    public class ApprovalController : ApiController
    {
        /// <summary>
        /// 流程控制属性实例化
        /// </summary>
        [Dependency]
        public IApprovalServices approvalServices { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Dependency]
        public IManager_Services manager_Services { get; set; }
        /// <summary>
        /// 添加审批信息
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddApproval")]
        public int AddApproval(Approval approval)
        {
            int result = approvalServices.AddApproval(approval);
            return result;
        }

        /// <summary>
        /// 添加条件信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddCondition")]
        public int AddCondition(Conditions condition)
        {
            var result = approvalServices.AddCondition(condition);
            return result;
        }
        /// <summary>
        /// 添加条件信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddNode")]
        public int AddNode(Node node)
        {
            var result = approvalServices.AddNode(node);
            return result;
        }
        /// <summary>
        /// 添加配置信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddFlowControlConfig")]
        public int AddFlowControlConfig(FlowControlConfig flowControlConfig)
        {
            var result = approvalServices.AddFlowControlConfig(flowControlConfig);
            return result;
        }

        /// <summary>
        /// 添加配置信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddActiveFlow")]
        public int AddActiveFlow(ActiveFlow activeFlow)
        {
            var result = approvalServices.AddActiveFlow(activeFlow);
            return result;
        }
        /// <summary>
        /// 获取所有审批信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovals")]
        public IEnumerable<Approval> GetApprovals()
        {
            var result = approvalServices.GetApprovals();
            return result;
        }
        /// <summary>
        /// 获取条件信息
        /// </summary>
        /// <param name="ApprovalID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetConditionsBy")]
        public IEnumerable<Conditions> GetConditionsBy(int ApprovalID)
        {
            var result = approvalServices.GetConditionsBy(ApprovalID);
            return result;
        }
        /// <summary>
        /// 获取单个条件信息
        /// </summary>
        /// <param name="ApprovalID"></param>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetConditionsByReason")]
        public Conditions GetConditionsByReason(int ApprovalID, int RoleID)
        {
            var result = approvalServices.GetConditionsByReason(ApprovalID, RoleID);
            return result;
        }
        /// <summary>
        /// 获取节点信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetNodes")]
        public IEnumerable<Node> GetNodes()
        {
            var result = approvalServices.GetNodes();
            return result;
        }
        /// <summary>
        /// 获取所有配置信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFlowControlConfigs")]
        public IEnumerable<ShowFlowControlConfig> GetFlowControlConfigs()
        {
            var result = approvalServices.GetFlowControlConfigs();
            return result;
        }
        /// <summary>
        /// 获取状态
        /// </summary>
        /// <returns></returns>
        [Route("GetStates")]
        [HttpGet]
        public Dictionary<int,string> GetStates()
        {
            Dictionary<int, string> strStates = new Dictionary<int, string>();
            var values = (int[])Enum.GetValues(typeof(State));
            foreach (var item in values)
            {
                strStates.Add(item, Enum.GetName(typeof(State), item));
            }
            var strState = strStates;
            return strStates;
        }
        /// <summary>
        /// 根据角色ID获取用户信息
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        [Route("GetManagersByRoleID")]
        [HttpGet]
        public IEnumerable<TManage> GetManagersByRoleID(int roleID)
        {
            var result = approvalServices.GetManages(roleID);
            return result;
        }
        /// <summary>
        /// 根据角色ID获取活动表
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        [Route("GetActiveFlows")]
        [HttpGet]
        public IEnumerable<ActiveFlow> GetActiveFlows(int roleID)
        {
            var result = approvalServices.GetActiveFlows(roleID);
            return result;
        }
        /// <summary>
        /// 根据nodeID获取活动表
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        [Route("GetActiveFlowsByNode")]
        [HttpGet]
        public IEnumerable<ActiveFlow> GetActiveFlowsByNode(int roleID)
        {
            var result = approvalServices.GetActiveFlowsByNode(roleID);
            return result;
        }
    }
}
