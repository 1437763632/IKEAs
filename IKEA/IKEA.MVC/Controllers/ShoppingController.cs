using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKEA.MVC.Controllers
{
    using System.IO;
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddShopImage()
        {
            return View();
        }


        public ActionResult GetShopping()
        {
            return View();
        }

        public ActionResult AddProduct()
        {
            return View();
        }


        //public string addImage()
        //{
        //    HttpPostedFileBase fileName = Request.Files[0];
        //    if (!Directory.Exists(fileName))
        //    {

        //    }
        //}

        /// <summary>
        /// 多图片上传
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetImg()
        {
            List<string> pathList = new List<string>();
            var num = HttpContext.Request.Files.Count;

            string path =Server.MapPath( "~/Img/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            for (int i = 0; i < num; i++)
            {
                HttpPostedFile file = System.Web.HttpContext.Current.Request.Files[i];               
                string savePath = Path.Combine(path, Guid.NewGuid().ToString() + file.FileName);
                file.SaveAs(savePath);
                pathList.Add(path);
               
            }
            return Json(pathList);
           
        }
    }
}