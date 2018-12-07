using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 购物车服务接口
    /// </summary>
    public  interface ITrolley_Services
    {
        /// <summary>
        /// 添加购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        int Add(TTrolley trolley);
        /// <summary>
        /// 修改购物车
        /// </summary>
        /// <param name="trolley"></param>
        /// <returns></returns>
        int Update(TTrolley trolley);
        /// <summary>
        /// 删除购物车
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 获取单个购物车信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TTrolley GetTrolley(int id);
        /// <summary>
        /// 获取购物车信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<TTrolley> GetTrolleys();
    }
}
