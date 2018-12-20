using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Model;
    using IServices;
    using Common;
    using Dapper;
    using MySql.Data.MySqlClient;
    public class Role_Services : IRole_Services
    {
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Add(TRole role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql2 = string.Format("select * from TRole where RoleName=@RoleName");
                var Roles = conn.Query<TRole>(sql2, role);
                //定义角色存在
                int resault = -1;
                //当角色为空
                if(Roles.Count()==0)
                {
                    //添加角色                  
                    string sql = string.Format("insert into TRole(RoleName,RightID) value(@RoleName,@RightID);");
                    conn.Execute(sql, role);

                    //获取到角色id
                    string sql3 = string.Format("select id from TRole where RoleName=@RoleName");
                    var id = conn.Query<int>(sql3, role).FirstOrDefault();

                    var roles = role.RightID.Split(',');//权限ID分隔字符串

                    for (int j = 0; j < roles.Length; j++)//循环添加进入关系表
                    {
                        TRole_Right role_Right = new TRole_Right();//实例化关系表
                        role_Right.RoleID = id;   //角色id
                        role_Right.RightID = Convert.ToInt32(roles[j]);//权限id
                        string sql1 = string.Format("insert into TRole_Right (RoleID,RightID) value(@RoleID,@RightID)");//关系表添加语句
                        resault= conn.Execute(sql1, role_Right);
                    }
                }
               
                return resault;
            }
        }

        /// <summary>
        /// 删除角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TRole where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ShowRole> GetRole(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format(@"select r.Id,r.RoleName,tr.RightID from trole as r
join trole_right as tr
on r.Id = tr.RoleID
where r.Id = @Id");
                var i = conn.Query<ShowRole>(sql, new { Id = id }).ToList();
                return i;
            }
        }
        /// <summary>
        /// 获取角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ShowRole> GetRoles()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format(@"SELECT r.Id,r.RoleName,rr.RightID,GROUP_CONCAT(a.RightName separator ',') as RightName
from trole_right as rr
JOIN trole as r
ON rr.roleid=r.id
JOIN tright AS a
ON rr.rightid =a.id GROUP BY r.Id,r.RoleName ");
                var i = conn.Query<ShowRole>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 多表修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <param name="roleid"></param>
        /// <returns></returns>
        public int RoleUpdate(TRole role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql2 = string.Format("select * from TRole where RoleName=@RoleName");
                var Roles = conn.Query<TRole>(sql2, role);
                //定义角色存在
                int resault = -1;
                //当角色为空
                if (Roles.Count() == 0)
                {
                    //修改角色                  
                    string sql = string.Format("update TRole set RoleName=@RoleName,RightID=@RightID where Id=@Id");
                    conn.Execute(sql, role);
                    var roles = role.RightID.Split(',');
                    string del = string.Format("delete from TRole_Right where RoleID=@roleid");
                    conn.Execute(del, new { roleid = role.Id });
                    for (int j = 0; j < roles.Length; j++)
                    {
                        TRole_Right role_Right = new TRole_Right();
                        role_Right.RoleID = role.Id;
                        role_Right.RightID = Convert.ToInt32(roles[j]);
                        
                        string sql1 = string.Format("insert into TRole_Right (RoleID,RightID) value(@RoleID,@RightID)");
                        resault = conn.Execute(sql1, role_Right);
                    }
                }
                
                return resault;
            }
        }

        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Update(TRole role)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TRole set RoleName=@RoleName where Id=@Id");
                var i = conn.Execute(sql, role);
                return i;
            }
        }
    }
}
