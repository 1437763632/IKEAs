using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 权限表
    /// </summary>
    public class TRight
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string RightName { get; set; }
        /// <summary>
        /// 权限路径
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsUser { get; set; }
    }
}
