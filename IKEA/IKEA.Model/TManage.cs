﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 管理员表
    /// </summary>
   public class TManage
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string ManageName { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string ManageNumber { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string ManagePass { get; set; }
            
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 角色id
        /// </summary>
        public string RoleID { get; set; }
    }
}
