using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKEA.MVC.Controllers
{
    using Newtonsoft.Json;
    using Services;
    using Model;
    public class HomeController : Controller
    {
        Manager_Services Manager_Services = new Manager_Services();
        // GET: Home
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public int Login(TManage manage)
        {
            Session["Nuber"] = manage.ManageNumber;
            Session["Pass"] = manage.ManagePass;
            Session["Name"] = manage.ManageName;
            Session["Id"] = manage.Id;
            return 1;
        }
    }
}