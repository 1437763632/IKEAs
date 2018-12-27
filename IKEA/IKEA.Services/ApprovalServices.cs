using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using IKEA.IServices;
    using IKEA.Model;
    using IKEA.Common;
    using Dapper;
    using MySql.Data.MySqlClient;
    /// <summary>
    /// 流程控制实现层
    /// </summary>
    public class ApprovalServices : IApprovalServices
    {
       

        /// <summary>
        /// 添加活动表信息
        /// </summary>
        /// <param name="activeFlow"></param>
        /// <returns></returns>
        public int AddActiveFlow(ActiveFlow activeFlow)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql1 = string.Format("SELECT * FROM flowcontrolconfig  WHERE ApprovalID=@ApprovalID AND RoleId=@RoleId");
                FlowControlConfig flowControlConfig = conn.Query<FlowControlConfig>(sql1, new { ApprovalID = activeFlow.ApprovalID, RoleId = activeFlow.RoleId }).FirstOrDefault();
                int result = -1;
                if (flowControlConfig != null)
                {
                    activeFlow.State = State.Unchecked;
                    string nodeSql = string.Format("SELECT * from node WHERE Id=@Id");
                    //获取当前节点信息
                    Node currentNode = conn.Query<Node>(nodeSql, new { Id = flowControlConfig.NodeID }).FirstOrDefault();
                    //添加当前节点信息
                    activeFlow.CurrentNodeID = flowControlConfig.NodeID;
                    activeFlow.CurrentRoleID = currentNode.NodeRole;
                    //添加下一节点信息
                    activeFlow.NextNodeID = flowControlConfig.NextNodeID;
                    string sql = string.Format("insert into ActiveFlow(UserId,RoleId,Reason,ApprovalID,ConditionRange,ActualCondition,State,CurrentNodeID,CurrentRoleID,NextNodeID) values(@UserId,@RoleId,@Reason,@ApprovalID,@ConditionRange,@ActualCondition,@State,@CurrentNodeID,@CurrentRoleID,@NextNodeID)");
                     result = conn.Execute(sql, activeFlow);
                }
                
                return result;
            }
        }

        /// <summary>
        /// 添加审批流程信息
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        public int AddApproval(Approval approval)
        {
            using (System.Data.IDbConnection conn=DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Approval(ApproveName,Description,IsModified,IsCanceled) values(@ApproveName,@Description,@IsModified,@IsCanceled)");
                int result = conn.Execute(sql, approval);
                return result;
            }
        }
        /// <summary>
        /// 添加条件信息
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public int AddCondition(Conditions condition)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql1 = string.Format("select * from Conditions where ApprovalID=@ApprovalID and RoleID=@RoleID");
                var conditions = conn.Query<Conditions>(sql1, condition);
                int result;
                if (conditions.Count() != 0)
                {
                    result = -1;
                }
                else
                {
                    string sql = string.Format("insert into Conditions(ApprovalID,RoleID,ConditionRange) values(@ApprovalID,@RoleID,@ConditionRange)");
                    result = conn.Execute(sql, condition);
                }               
                return result;
            }
        }
        /// <summary>
        /// 添加流程配置信息
        /// </summary>
        /// <param name="flowControlConfig"></param>
        /// <returns></returns>
        public int AddFlowControlConfig(FlowControlConfig flowControlConfig)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into FlowControlConfig(RoleID,ApprovalID,NodeID,NextNodeID) values(@RoleID,@ApprovalID,@NodeID,@NextNodeID)");
                int result = conn.Execute(sql, flowControlConfig);
                return result;
            }
        }

        /// <summary>
        /// 添加节点信息
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int AddNode(Node node)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("insert into Node(NodeName,Description,NodeRole) values(@NodeName,@Description,@NodeRole)");
                int result = conn.Execute(sql,node);
                return result;
            }
        }
        /// <summary>
        /// 获取单个活动表信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActiveFlow GetActiveFlow(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from ActiveFlow where id=@id");
                var result = conn.Query<ActiveFlow>(sql, new { id=id}).FirstOrDefault();
                return result;
            }
        }
        /// <summary>
        /// 根据角色ID获取活动表信息
        /// </summary>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        public IEnumerable<ActiveFlow> GetActiveFlows(int RoleID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from ActiveFlow where RoleID=@RoleID");
                var result = conn.Query<ActiveFlow>(sql, new { RoleID=RoleID});
                return result;
            }
        }
        /// <summary>
        /// 根据节点信息获取活动表
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public IEnumerable<ActiveFlow> GetActiveFlowsByNode(int roleID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("SELECT * FROM activeflow WHERE CurrentNodeID =(SELECT Id FROM node WHERE NodeRole=@RoleID)");
                var result = conn.Query<ActiveFlow>(sql, new { RoleID = roleID });
                return result;
            }
        }


        /// <summary>
        /// 获取所有审批信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Approval> GetApprovals()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from Approval");
                var result = conn.Query<Approval>(sql, null);
                return result;
            }
        }
        /// <summary>
        /// 获取条件信息
        /// </summary>
        /// <param name="ApprovalID"></param>
        /// <returns></returns>
        public IEnumerable<Conditions> GetConditionsBy(int ApprovalID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from Conditions where ApprovalID=@ApprovalID");
                var result = conn.Query<Conditions>(sql, new { ApprovalID = ApprovalID });
                return result;
            }
        }
        /// <summary>
        /// 获取单个条件信息
        /// </summary>
        /// <param name="ApprovalID"></param>
        /// <param name="RoleID"></param>
        /// <returns></returns>
        public Conditions GetConditionsByReason(int ApprovalID, int RoleID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from Conditions where ApprovalID=@ApprovalID and RoleID=@RoleID");
                var result = conn.Query<Conditions>(sql, new { ApprovalID = ApprovalID,RoleID=RoleID });
                return result.FirstOrDefault();
            }
        }
        /// <summary>
        /// 获取配置信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShowFlowControlConfig> GetFlowControlConfigs()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("SELECT f.Id,r.Id AS RoleID,f.ApprovalId,a.ApproveName,a.Description,a.IsModified,a.IsCanceled,f.NodeId,n.NodeName,n.Description AS NodeDescription,n.NodeRole,f.NextNodeId FROM flowcontrolconfig as f JOIN trole AS r ON f.RoleId =r.Id JOIN approval as a ON f.ApprovalId=a.Id JOIN node AS n ON f.NodeId=n.Id LEFT  JOIN node AS n1 ON f.NextNodeId=n1.Id");
                var result = conn.Query<ShowFlowControlConfig>(sql, null);
                return result;
            }
        }
        /// <summary>
        /// 根据角色ID获取用户信息
        /// </summary>
        /// <param name="roleID"></param>
        /// <returns></returns>
        public IEnumerable<TManage> GetManages(int roleID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("SELECT * FROM tmanage WHERE Id IN(SELECT ManageID FROM tmanage_role WHERE RoleID=@roleID)");
                var result = conn.Query<TManage>(sql, new { roleID=roleID});
                return result;
            }
           
        }
        /// <summary>
        /// 获取所有节点信息
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Node> GetNodes()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Format("select * from Node");
                var result = conn.Query<Node>(sql, null);
                return result;
            }
        }
        /// <summary>
        /// 修改活动表信息
        /// </summary>
        /// <param name="activeFlow"></param>
        /// <returns></returns>
        public int UpdateActiveFlow(ActiveFlow activeFlow)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                conn.Open();
                string sql = string.Empty;
                var result = -1;
                    sql = string.Format("UPDATE activeflow SET userid=@UserID,RoleID=@RoleID,Reason=@Reason,ApprovalID=@ApprovalID,ConditionRange=@ConditionRange,ActualCondition=@ActualCondition,CurrentNodeID=@CurrentNodeID,CurrentRoleID=@CurrentRoleID,CurrentUserID=@CurrentUserID,CurrentRemark=@CurrentRemark,State=@State,NextNodeID=@NextNodeID WHERE Id=@Id");
                    result = conn.Execute(sql, activeFlow);    
                return result;
            }
        }
    }
}
