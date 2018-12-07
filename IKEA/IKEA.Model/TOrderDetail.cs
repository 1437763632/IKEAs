using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 订单详情表
    /// </summary>
    public class TOrderDetail
    {
        /// <summary>
        /// id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// 商品ID 
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// 商品详情ID
        /// </summary>
        public int ProductDetailID { get; set; }
        /// <summary>
        /// 单品购买数量
        /// </summary>
        public int BuyNumber { get; set; }
        /// <summary>
        /// 标注价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 实际价格
        /// </summary>
        public decimal RealPrice { get; set; }
        /// <summary>
        ///  消费金额
        /// </summary>
        public decimal Consume { get; set; }
    }
}
