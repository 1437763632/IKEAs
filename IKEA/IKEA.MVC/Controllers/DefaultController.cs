using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKEA.MVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult welcome()
        {
            return View();
        }
        /// <summary>
        /// 品牌管理
        /// </summary>
        /// <returns></returns>
        public ActionResult product_brand()
        {
            return View();
        }

        public ActionResult product_category()
        {
            return View();
        }
        /// <summary>
        /// 产品管理
        /// </summary>
        /// <returns></returns>
        public ActionResult product_list()
        {
            return View();
        }
        /// <summary>
        /// 图片管理
        /// </summary>
        /// <returns></returns>
        public ActionResult picture_list()
        {
            return View();
        }
        /// <summary>
        /// 角色管理
        /// </summary>
        /// <returns></returns>
        public ActionResult admin_role()
        {
            return View();
        }
        public ActionResult admin_role_add()
        {
            return View();
        }
        /// <summary>
        /// 权限管理
        /// </summary>
        /// <returns></returns>
        public ActionResult admin_permission()
        {
            return View();
        }
        /// <summary>
        /// 管理员列表
        /// </summary>
        /// <returns></returns>
        public ActionResult admin_list()
        {
            return View();
        }
        /// <summary>
        /// 系统管理
        /// </summary>
        /// <returns></returns>
        public ActionResult charts_1()
        {
            return View();
        }
        public ActionResult charts_2()
        {
            return View();
        }
        public ActionResult charts_3()
        {
            return View();
        }
        public ActionResult charts_4()
        {
            return View();
        }
        public ActionResult charts_5()
        {
            return View();
        }
        public ActionResult charts_6()
        {
            return View();
        }
        public ActionResult charts_7()
        {
            return View();
        }

        /// <summary>
        /// 会员管理
        /// </summary>
        /// <returns></returns>
        public ActionResult member_list()
        {
            return View();
        }
        public ActionResult member_del()
        {
            return View();
        }
        public ActionResult member_level()
        {
            return View();
        }
        public ActionResult member_scoreoperation()
        {
            return View();
        }
        public ActionResult member_record_browse()
        {
            return View();
        }
        public ActionResult member_record_download()
        {
            return View();
        }
        public ActionResult member_record_share()
        {
            return View();
        }
        /// <summary>
        /// 商品管理
        /// </summary>
        /// <returns></returns>
        public ActionResult article_list()
        {
            return View();
        }
        /// <summary>
        /// 评论管理
        /// </summary>
        /// <returns></returns>
        public ActionResult comment_list()
        {
            return View();
        }



    }
}