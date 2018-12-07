using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 操作日志表
    /// </summary>
    public class TLog
    {
        /// <summary>
        /// 日志ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 操作内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
