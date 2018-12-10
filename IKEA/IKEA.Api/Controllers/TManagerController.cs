using IKEA.Common;
using IKEA.IServices;
using IKEA.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using Unity.Attributes;

namespace IKEA.Api.Controllers
{
    [RoutePrefix("TManager")]
    public class TManagerController : ApiController
    {
        [Unity.Attributes.Dependency]
        public IManager_Services managerServices { get; set; }
        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        [Route("Addmanager")]
        [HttpPost]
        public int Add(TManage manage)
        {
            var i = this.managerServices.Add(manage);
            return i;
        }
        /// <summary>
        /// 获取单个管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetManage")]
        [HttpGet]
        public TManage GetManage(int id)  
        {
            var i = this.managerServices.GetManage(id);
            return i;
        }

        /// <summary>
        /// 根据角色获取
        /// </summary>
        /// <returns></returns>
        [Route("GetManages")]
        [HttpGet]
        public IEnumerable<TManage> GetManages()
        {
            var result = this.managerServices.GetManages();
            return result;
        }

        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="manage"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpGet]
        public int Update(TManage manage)
        {
            var i = this.managerServices.Update(manage);
            return i;
        }
    }
}
