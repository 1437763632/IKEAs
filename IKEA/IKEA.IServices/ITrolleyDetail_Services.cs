using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 购物车详情接口
    /// </summary>
    public interface ITrolleyDetail_Services
    {
        /// <summary>
        /// 添加购物车详情
        /// </summary>
        /// <param name="trolleyDetail"></param>
        /// <returns></returns>
        int Add(TTrolleyDetail trolleyDetail );
        /// <summary>
        /// 修改购物车详情
        /// </summary>
        /// <param name="trolleyDetail"></param>
        /// <returns></returns>
        int Update(TTrolleyDetail trolleyDetail);
        /// <summary>
        /// 获取单个购物车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TTrolleyDetail GetTTrolleyDetail(int id);
        /// <summary>
        /// 删除购物车详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 获取所有购物车详情信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<TTrolleyDetail> GetTrolleyDetails();
    }
}
