using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 支付表
    /// </summary>
    public class TPayment
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 订单Id
        /// </summary>
        public int OrderID
        { get; set; }
        /// <summary>
        ///  用户ID
        /// </summary>
        public int UserID { get; set; }
        /// < summary>
        /// 支付类型
        /// </summary>
        public int PayType { get; set; }
        /// <summary>
        /// 支付账号
        /// </summary>
        public string PayNumber { get; set; }
        /// <summary>
        ///  支付金额
        /// </summary>
        public decimal PayMoney { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public DateTime Paytime { get; set; }

    }
}
