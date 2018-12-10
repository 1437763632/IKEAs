

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 产品尺寸表
    /// </summary>
    public class TProduct_Size  
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 产品尺寸信息
        /// </summary>
        public string ProductSize { get; set; }
    }
}
