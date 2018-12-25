using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKEA.MVC.Controllers
{
    using Models;

    public class DefaultController : Controller
    {
        // GET: Default
        [LoginFatier]
        public ActionResult Index()
        {
            ViewBag.Name = Session["Name"];
            ViewBag.Pass = Session["Pass"];
            ViewBag.Nuber = Session["Nuber"];
            ViewBag.Id = Session["Id"] ;
            return View();
        }
        /// <summary>
        /// 品牌管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult product_brand()
        {
            return View();
        }

        [LoginFatier]
        public ActionResult product_category()
        {
            return View();
        }
        /// <summary>
        /// 产品管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult product_list()
        {
            return View();
        }
        /// <summary>
        /// 图片管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult picture_list()
        {
            return View();
        }
        /// <summary>
        /// 角色管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult admin_role()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult admin_role_add()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult admin_role_upt()
        {
            return View();
        }
        /// <summary>
        /// 权限管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult admin_permission()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult admin_permission_add()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult admin_permission_upt()
        {
            return View();
        }
        /// <summary>
        /// 管理员管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult admin_list()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult admin_list_add()
        {
            return View();
        }
      //  [LoginFatier]
        public ActionResult admin_list_upt()
        {
            return View();
        }
        /// <summary>
        /// 系统管理
        /// </summary>
        /// <returns></returns>
//[LoginFatier]
        public ActionResult charts_1()
        {
            return View();
        }
      //  [LoginFatier]
        public ActionResult charts_2()
        {
            return View();
        }
       // [LoginFatier]
        public ActionResult charts_3()
        {
            return View();
        }
      //  [LoginFatier]
        public ActionResult charts_4()
        {
            return View();
        }
        //[LoginFatier]
        public ActionResult charts_5()
        {

            return View();
        }
       // [LoginFatier]
        public ActionResult charts_6()
        {
            return View();
        }
        //[LoginFatier]
        public ActionResult charts_7()
        {
            return View();
        }

        /// <summary>
        /// 会员管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult member_list()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult member_del()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult member_level()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult member_scoreoperation()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult member_record_browse()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult member_record_download()
        {
            return View();
        }
        [LoginFatier]
        public ActionResult member_record_share()
        {
            return View();
        }
        /// <summary>
        /// 商品管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult article_list()
        {
            return View();
        }
        /// <summary>
        /// 评论管理
        /// </summary>
        /// <returns></returns>
        [LoginFatier]
        public ActionResult comment_list()
        {
            return View();
        }



    }
}