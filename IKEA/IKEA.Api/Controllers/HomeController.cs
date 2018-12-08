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
    /// 
    /// </summary>
    [RoutePrefix("Home")]
    public class HomeController : ApiController
    {
        [Dependency]
        IImage_Services image_Services { get; set; }

        IColor_Services color_Services = null;
        public HomeController(IColor_Services _color_Services)
        {
            color_Services = _color_Services;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IEnumerable<TColor> GetUsers()
        {
            var resault = color_Services.GetColors();
            return resault;
        }

        [HttpGet]
        [Route("GetImages")]
        public IHttpActionResult GetImages()
        {
            var resault = image_Services.GetImages(1);
            return Json<dynamic>(resault);
        }
    }
}
