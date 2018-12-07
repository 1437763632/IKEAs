using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 订单服务接口
    /// </summary>
    public interface IOrder_Services
    {
        /// <summary>
        /// 添加订单
        /// </summary>
        /// <param name="order">订单</param>
        /// <returns>int</returns>
        int Add(TOrder order);

        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns>int</returns>
        int Delete(int id);
        /// <summary>
        /// 修改订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns>int</returns>
        int Update(TOrder order);
        /// <summary>
        /// 获取单个订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TOrder</returns>
        TOrder GetOrder(int id);
        /// <summary>
        /// 根据用户ID获取所有订单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>IEnumerable<TOrder></returns>
        IEnumerable<TOrder> GetOrders(int userID);
    }
}
