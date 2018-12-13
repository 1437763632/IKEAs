using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 订单详情接口
    /// </summary>
    public interface IOrderDetail_Services
    {
        /// <summary>
        /// 根据订单id获取所有订单详情
        /// </summary>
        /// <param name="orderID">订单id</param>
        /// <returns>IEnumerable<TOrderDetail> </returns>
        IEnumerable<TOrderDetail> GetOrderDetails(int orderID);
        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="id">订单详情ID</param>
        /// <returns>TOrderDetail</returns>
        TOrderDetail GetOrderDetail(int id);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="orderDetail">订单详情实体</param>
        /// <returns>int</returns>
        int Update(TOrderDetail orderDetail);
        /// <summary>
        /// 查看所有订单
        /// </summary>
        /// <returns></returns>
        IEnumerable<TOrderDetail> GetOrderlist();
    }
}
