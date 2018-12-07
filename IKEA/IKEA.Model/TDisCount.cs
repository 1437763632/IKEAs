using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 优惠券表
    /// </summary>
    public class TDisCount
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 价值
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

    }
}
