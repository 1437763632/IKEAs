using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 地址表
    /// </summary>
    public class TAdderss
    {
        /// <summary>
        /// id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 地址名
        /// </summary>
        public string AddressName { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
    }
}
