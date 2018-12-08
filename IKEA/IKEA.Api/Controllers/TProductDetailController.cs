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
    [RoutePrefix("wyTProductDetail")]
    public class TProductDetailController : ApiController
    {
        [Dependency]
        ITrolleyDetail_Services TProductDetail { get; set; }

        

    }
}
