using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 优惠券服务接口
    /// </summary>
    public interface IDisCountServices
    {
        /// <summary>
        /// 添加优惠券
        /// </summary>
        /// <param name="disCount">优惠券对象</param>
        /// <returns></returns>
        int Add(TDisCount disCount);
        /// <summary>
        /// 获取优惠券
        /// </summary>
        /// <returns></returns>
        IEnumerable<TDisCount> GetDisCounts();
       /// <summary>
       /// 获取优惠券
       /// </summary>
       /// <param name="UserID">用户ID</param>
       /// <returns></returns>
        IEnumerable<TDisCount> GetDisCounts(int UserID);
        /// <summary>
        /// 获取单个优惠券
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        TDisCount GetDisCount(int id);
        /// <summary>
        /// 修改优惠券
        /// </summary>
        /// <param name="disCount">优惠券对象</param>
        /// <returns></returns>
        int Update(TDisCount disCount);
        /// <summary>
        /// 删除优惠券
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        int Delete(int id);

    }
}
