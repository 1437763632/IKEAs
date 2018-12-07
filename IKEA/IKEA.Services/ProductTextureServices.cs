using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Model;
    using IServices;
    public class ProductTextureServices : IProductTextureServices
    {
        /// <summary>
        /// 添加材质信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public int Add(TProduct_Texture product_Texture)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取所有材质信息
        /// </summary>
        /// <returns></returns>
        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取单个材质信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TProduct_Texture GetProduct_Texture(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public IEnumerable<TProduct_Texture> GetProduct_Textures()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(TProduct_Texture product_Texture)
        {
            throw new NotImplementedException();
        }
    }
}
