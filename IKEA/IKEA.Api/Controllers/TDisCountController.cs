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
    /// 产品详情
    /// </summary>
    [RoutePrefix("TDisCount")]
    public class TDisCountController : ApiController
    {
        [Dependency]
        public IDisCount_Services DisCount { get; set; }
        /// <summary>
        /// 优惠劵
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        [Route("GetDisCount")]
        [HttpGet]
        public TDisCount GetDisCount(int id)
        {
            var result = this.DisCount.GetDisCount(id);
            return result;
        }
    }
}
