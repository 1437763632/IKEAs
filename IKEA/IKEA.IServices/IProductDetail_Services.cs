using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 产品详情接口
    /// </summary>
    public interface IProductDetail_Services
    {
        /// <summary>
        /// 添加产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        int Add(TProductDetail productDetail);
        /// <summary>
        /// 修改产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        int Update(TProductDetail productDetail);
        /// <summary>
        /// 删除产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 根据ID获取产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        IEnumerable<TProductDetail> GetTProductDetailId(int id);
        /// <summary>
        /// 获取产品详情
        /// </summary> 
        /// <param name="productID"></param>
        /// <returns> IEnumerable<TProduct></returns>
       IEnumerable< TProductDetail > GetTProductDetails();
    }
}
