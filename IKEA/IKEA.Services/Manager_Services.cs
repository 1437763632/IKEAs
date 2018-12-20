using IKEA.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;


using System.Threading.Tasks;

namespace IKEA.Services
{
    using Dapper;
    using IKEA.Common;
    using IKEA.IServices;
    using IKEA.Model;
    using MySql.Data.MySqlClient;
    public class Manager_Services : IManager_Services
    {
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        public int Add(TManage manage)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql2 = string.Format("select * from tmanage where ManageNumber=@ManageNumber");
                var manages = conn.Query<TRole>(sql2, manage);
                //定义管理账号存在
                int resault = -1;
                //当角色为空
                if (manages.Count() == 0)
                {
                    //添加角色                  
                    string sql = string.Format("INSERT INTO tmanage (ManageName,ManageNumber,ManagePass,RoleID)VALUE (@ManageName,@ManageNumber,@ManagePass,@RoleID)");
                    conn.Execute(sql, manage);
                    //查询id
                    string sql3 = string.Format("select id from tmanage where ManageNumber=@ManageNumber");
                    var id = conn.Query<int>(sql3, manage).FirstOrDefault();
                    var roles = manage.RoleID.Split(',');
                    for (int j = 0; j < roles.Length; j++)
                    {
                        TManage_Role manage_Role = new TManage_Role();
                        manage_Role.ManageID = id;
                        manage_Role.RoleID = Convert.ToInt32(roles[j]);
                        string sql1 = string.Format("insert into TManage_Role (ManageID,RoleID) value(@ManageID,@RoleID)");
                        resault = conn.Execute(sql1, manage_Role);
                    }
                }

                return resault;
            }
        }
        /// <summary>
        /// 获取单个管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ShowManage> GetManage(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format(@"select m.Id,m.ManageName,m.ManageNumber,m.ManagePass,tm.RoleID 
from tmanage as m
join tmanage_role as tm
on m.Id = tm.ManageID
where m.Id = @Id");
                var i = conn.Query<ShowManage>(sql, new { Id = id }).ToList();
                return i;
            }
        }

        /// <summary>
        /// 获取管理员信息 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShowManage> GetManages()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format(@"SELECT r.Id,r.ManageName,r.ManageNumber,r.ManagePass,rr.RoleID,GROUP_CONCAT(a.RoleName separator ',') as RoleName,r.CreateTime
from tmanage_role as rr
JOIN tmanage as r
ON rr.ManageID = r.Id
JOIN trole AS a
ON rr.RoleID = a.Id GROUP BY r.Id, r.ManageNumber ");
                var i = conn.Query<ShowManage>(sql, null).ToList();

                return i;
            }
        }

        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        /// 
        public int Update(TManage manage)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {


                //修改角色                  
                string sql = string.Format("update TManage set ManageName=@ManageName,ManagePass=@ManagePass,CreateTime=@CreateTime where Id=@Id");
                var manages = conn.Execute(sql, manage);
                var roles = manage.RoleID.Split(',');
                string del = string.Format("delete from TManage_Role where ManageID=@ManageID");
                conn.Execute(del, new { ManageID = manage.Id });
                for (int j = 0; j < roles.Length; j++)
                {
                    TManage_Role manage_Role = new TManage_Role();
                    manage_Role.ManageID = manage.Id;
                    manage_Role.RoleID = Convert.ToInt32(roles[j]);
                    string sql1 = string.Format("insert into TManage_Role (ManageID,RoleID) value(@ManageID,@RoleID)");
                    var resault = conn.Execute(sql1, manage_Role);
                }


                return manages;

            }
        }
        /// <summary>
        ///登录
        /// </summary>
        /// <param name="ManageNumber"></param>
        /// <param name="ManagePass"></param>
        /// <returns></returns>
        public TManage Login(string ManageNumber, string ManagePass)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * from tmanage WHERE ManageNumber=@ManageNumber AND ManagePass=@ManagePass");
                var result = conn.Query<TManage>(sql, new { ManageNumber = ManageNumber, ManagePass = ManagePass }).SingleOrDefault();

                if (result != null)
                {
                    return result;
                }
                return null;
            }
        }

        /// <summary>
        /// 绑定数据栏
        /// </summary>
        /// <param name="ManageNumber"></param>
        /// <param name="ManagePass"></param>
        /// <returns></returns>
        public IEnumerable<TRight> Getrights(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql2 = @"SELECT * from tright where Id in
(SELECT RightID from trole_right where RoleID in
(SELECT RoleID from tmanage_role where ManageID in 
(select Id from tmanage where Id=@Id)))";
                var result2 = conn.Query<TRight>(sql2, new { Id = id }).ToList();
                return result2;
            }

        }



    }
}
