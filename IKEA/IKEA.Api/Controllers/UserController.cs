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
    [RoutePrefix("User")]
    public class UserController : ApiController
    {
        /// <summary>
        /// 属性实例化
        /// </summary>
        [Dependency]
        public IUser_Services user_Services { get; set; }
        [Route("Login")]
        [HttpGet]
        public TUser Login(string code)
        {
            var user = user_Services.Login(code);
            return user;
        }
    }
}
