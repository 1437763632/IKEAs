using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 地址接口层
    /// </summary>
    public interface IAddress_Services
    {
        /// <summary>
        /// 获取用户地址
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
        IEnumerable<TAdderss> GetAddressesByUserID(int UserID);
        /// <summary>
        /// 添加地址
        /// </summary>
        /// <param name="adderss"></param>
        /// <returns>返回受影响行数</returns>
        int Add(TAdderss adderss);
        /// <summary>
        /// 删除地址
        /// </summary>
        /// <param name="id"></param>
        /// <returns>返回受影响函数</returns>
        int Delete(int id);
        /// <summary>
        /// 修改地址信息
        /// </summary>
        /// <param name="adderss"></param>
        /// <returns>返回受影响行数</returns>
        int Update(TAdderss adderss);
        /// <summary>
        /// 获取单个地址信息
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        TAdderss GetAddressByID(int id);
    }
}
