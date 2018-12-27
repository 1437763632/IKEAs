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
    [RoutePrefix("rbac")]
    public class RBACController : ApiController
    {
        #region 权限
        [Dependency]
        public IRight_Services right { get; set; }
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("rightAdd")]
        public int Add(TRight right)
        {
            var i = this.right.Add(right);
            return i;
        }

        /// <summary>
        /// 根据ID获取权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("rightGetId")]
        public TRight GetRight(int id)
        {
            var i = this.right.GetRight(id);
            return i;
        }

        /// <summary>
        /// 修改权限信息
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("rightUpdate")]
        public int Update(TRight right)
        {
            var i = this.right.Update(right);
            return i;
        }
        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Getrights")]
        public IEnumerable<TRight> GetRights()
        {
            var i = this.right.GetRights();
            return i;
        }
        #endregion

        

        #region 角色
        [Dependency]
        public IRole_Services role { get; set; }
        [HttpPost]
        [Route("RoleAdd")]
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Add(string RoleName,string RightID)
        {
            TRole role = new TRole();
            role.RoleName = RoleName;
            role.RightID = RightID;
            var i = this.role.Add(role);
            return i;
        }

        /// <summary>
        /// 删除角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RoleDelete")]
        public int RoleDelete(int id)
        {
            var i = this.role.Delete(id);
            return i;
        }

        /// <summary>
        /// 获取单个角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRole")]
        public IEnumerable<ShowRole> GetRole(int id)
        {
            var i = this.role.GetRole(id);
            return i;
        }
        /// <summary>
        /// 获取角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoles")]
        public IEnumerable<ShowRole> GetRoles()
        {
            var i = this.role.GetRoles();
            return i;
        }
        /// <summary>
        /// 修改角色信息
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RoleUpdate")]
        public int Update(string RoleName, string RightID,int Id)
        {
            TRole role = new TRole();
            role.RoleName = RoleName;
            role.RightID = RightID;
            role.Id = Id;
            var i = this.role.RoleUpdate(role);
            return i;
        }

        #endregion

        

        #region 管理员角色
        [Dependency]
        public IManager_Services manager { get; set; }
        [HttpPost]
        [Route("ManageAdd")]
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ManageAdd(TManage manage)
        {
            //string ManageNumber, string ManagePass, string ManageName, string RoleID
            //TManage manage = new TManage();
            //manage.ManageNumber = ManageNumber;
            //manage.ManageName = ManageName;
            //manage.ManagePass = ManagePass;
            //manage.RoleID = RoleID;
            var i = this.manager.Add(manage);
            return i;
        }

        [HttpGet]
        [Route("GetManage")]
        /// <summary>
        /// 获取单个管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<ShowManage> GetManage(int id)
        {
            var i = manager.GetManage(id);
            return i;
        }

        [HttpGet]
        [Route("GetManages")]
        /// <summary>
        /// 根据角色获取
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ShowManage> GetManages()
        {
            var i = manager.GetManages();
            return i;
        }
        [HttpPost]
        [Route("ManageUpdate")]
        /// <summary>
        /// 修改管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int ManageUpdate(TManage manage)
        {
            var i = manager.Update(manage);
            return i;
        }
        #endregion

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="ManageNumber"></param>
        /// <param name="ManagePass"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        public TManage Login(string ManageNumber, string ManagePass)
        {
            var i = manager.Login(ManageNumber, ManagePass);
            return i;
        }
        /// <summary>
        /// 绑定数据栏
        /// </summary>
        /// <param name="ManageNumber"></param>
        /// <param name="ManagePass"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Httprights")]
        public IEnumerable<TRight> Getrights(int id)
        {
            var i = manager.Getrights(id);
            return i;

        }

        
    }
}
