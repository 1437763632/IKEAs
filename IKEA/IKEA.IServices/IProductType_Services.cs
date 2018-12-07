using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 产品类型服务接口
    /// </summary>
    public interface IProductType_Services
    {
        /// <summary>
        /// 添加产品类型
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        int Add(TProductType productType);
        /// <summary>
        /// 修改产品类型
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        int Update(TProductType productType);
        /// <summary>
        /// 删除产品类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 根据ID获取产品类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProductType</returns>
        TProductType GetProduct(int id);
        /// <summary>
        /// 获取所有产品类型
        /// </summary> 
        /// <param name="pid"></param>
        /// <returns> IEnumerable<TProductType ></returns>
        IEnumerable<TProductType > GetProducts(int pid);
    }
}
