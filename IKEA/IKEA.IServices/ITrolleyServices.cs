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
    public  interface ITrolleyServices
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

        int Delete(int id);

        TTrolley GetTrolley(int id);

        IEnumerable<TTrolley> GetTrolleys();
    }
}
