using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 产品材质服务接口
    /// </summary>
    public interface IProductTextureServices
    {
        /// <summary>
        /// 添加材质信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        int Add(TProduct_Texture product_Texture);
        /// <summary>
        /// 获取所有材质信息
        /// </summary>
        /// <returns></returns>
        IEnumerable<TProduct_Texture> GetProduct_Textures();
        /// <summary>
        /// 获取单个材质信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TProduct_Texture GetProduct_Texture(int id);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        int Update(TProduct_Texture product_Texture);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
    }
}
