using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    public class TOrder
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用于ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 总数量
        /// </summary>
        public int SumNumber { get; set; }
        /// <summary>
        /// 总价格
        /// </summary>

        public int SumPrice { get; set; }
        /// <summary>
        /// 是否使用优惠券
        /// </summary>
        public bool IsOnSale { get; set; }
        /// <summary>
        /// 优惠券ID
        /// </summary>

        public  int DisCountD { get; set; }
        /// <summary>
        /// 实际支付价格
        /// </summary>
        public decimal RealPay { get; set; }
        /// <summary>
        /// 地址ID
        /// </summary>
        public int AddressID { get; set; }
        /// <summary>
        /// 是否支付
        /// </summary>
        public bool IsPayment { get; set; }
        /// <summary>
        /// 发货状态
        /// </summary>
        public int State { get; set; }
    }
}
