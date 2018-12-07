using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 产品尺寸服务接口
    /// </summary>
    public interface IProductSizeServices
    {
        /// <summary>
        /// 添加产品尺寸信息
        /// </summary>
        /// <param name="product_Size"></param>
        /// <returns></returns>
        int Add(TProduct_Size product_Size);
        /// <summary>
        /// 删除产品尺寸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 修改产品尺寸信息
        /// </summary>
        /// <param name="product_Size"></param>
        /// <returns></returns>
        int Update(TProduct_Size product_Size);
        /// <summary>
        /// 获取单个产品尺寸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TProduct_Size GetProduct_Size(int id);
        /// <summary>
        /// 获取所有产品尺寸信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<TProduct_Size> GetProduct_Sizes();
    }
}
