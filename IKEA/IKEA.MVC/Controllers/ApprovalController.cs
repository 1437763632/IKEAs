using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IKEA.MVC.Controllers
{
    public class ApprovalController : Controller
    {
        // GET: Approval
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 开始demo
        /// </summary>
        /// <returns></returns>
        public ActionResult Start()
        {
            return View();
        }
        /// <summary>
        /// 添加流程信息
        /// </summary>
        /// <returns></returns>
        public ActionResult AddApproval()
        {
            return View();
        }
        /// <summary>
        /// 添加条件信息
        /// </summary>
        /// <returns></returns>
        public ActionResult AddConditions()
        {
            return View();
        }
        /// <summary>
        /// 添加节点信息
        /// </summary>
        /// <returns></returns>
        public ActionResult AddNode()
        {
            return View();
        }

        /// <summary>
        /// 添加节点信息
        /// </summary>
        /// <returns></returns>
        public ActionResult AddFlowConfig()
        {
            return View();
        }

        /// <summary>
        /// 显示配置信息
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowFlow()
        {
            return View();
        }
        /// <summary>
        /// 展示详情界面
        /// </summary>
        /// <returns></returns>
        public  ActionResult Detail()
        {
            return View();
        }
    }
}