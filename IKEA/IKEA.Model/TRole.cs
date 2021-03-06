﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    /// <summary>
    /// 角色表
    /// </summary>
    public class TRole
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public string RightID { get; set; }
        [NotMapped]
        public string RightNames { get; set; }
    }
}
