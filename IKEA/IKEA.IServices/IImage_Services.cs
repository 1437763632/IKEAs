using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 图片服务
    /// </summary>
    public interface IImage_Services
    {
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="imageList"></param>
        /// <returns></returns>
        int Add(IEnumerable<TImage> imageList);
        /// <summary>
        /// 根据产品详情ID获取图片
        /// </summary>
        /// <param name="ProductDetailID">产品详情表ID</param>
        /// <returns></returns>
        IEnumerable<TImage> GetImages( );
        /// <summary>
        /// 根据ID获取单个图片
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        TImage GetImage(int id);
        /// <summary>
        /// 修改图片信息
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        int Update(TImage image);
        /// <summary>
        /// 删除图片信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);

    }
}
