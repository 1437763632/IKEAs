using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 审批表
    /// </summary>
    public class Approval
    {
        /// <summary>
        /// id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 审批名称
        /// </summary>
        public string ApproveName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否可修改
        /// </summary>
        public bool IsModified { get; set; }
        /// <summary>
        /// 是否可撤销
        /// </summary>
        public bool IsCanceled { get; set; }
    }
}
