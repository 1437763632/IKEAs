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

    [RoutePrefix("Home")]
    public class HomeController : ApiController
    {
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
    }
}
