using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IKEA.Api.Controllers
{
    using IKEA.Model;
    using IKEA.IServices;
    using IKEA.Services;
    using Unity.Attributes;
    /// <summary>
    /// 产品详情
    /// </summary>
    [RoutePrefix("wyTProductDetail")]
    public class TProductDetailController : ApiController
    {
        [Dependency]
        public IProductDetail_Services product { get; set; }

       

        [Dependency]
        public IColor_Services color_Services { get; set; }

        [Dependency]
        public IProduct_Texture_Services product_Texture_Services { get; set; }
        /// <summary>
        /// 添加产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        [Route("Add")]
        [HttpPost]
        public int Add(TProductDetail productDetail)
        {
            var i = this.product.Add(productDetail);
            return i;
        }

        /// <summary>
        /// 删除产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpGet]
        public int Delete(int id)
        {
            var i = this.product.Delete(id);
            return i;
        }

        /// <summary>
        /// 根据ID获取产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        [Route("Getid")]
        [HttpGet]
        public TProductDetail GetTProductDetailId(int id)
        {
            var count = this.product.GetTProductDetailId(id);
            return count;
        }


        /// <summary>
        /// 获取产品详情
        /// </summary> 
        /// <param name="productID"></param>
        /// <returns> IEnumerable<TProduct></returns>
        [Route("GetproductID")]
        [HttpGet]
        public TProductDetail GetTProductDetail(int productID)
        {
            var resault = product.GetTProductDetail(productID);
            return resault.FirstOrDefault();
        }

        /// <summary>
        /// 修改产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        [Route("Update")]
        [HttpPut]
        public int Update(TProductDetail productDetail)
        {

            var count = this.product.Update(productDetail);
            return count;
        }
        /// <summary>
        /// 修改产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        [Route("SSS")]
        [HttpGet]
        public IHttpActionResult SSS()
        {
            var query = from p in product.GetTProductDetail(1)
                        join c in color_Services.GetColors()
                        on p.colorID equals c.Id
                        join t in product_Texture_Services.GetProduct_Textures()
                        on p.ProductTextureID equals t.Id
                        
                        select new
                        {
                            Id =p.Id,
                            Colorname =c.Colorname,
                            Texture= t.Texture
                        };
           // query.Where(r => r.p.ProductID.Equals(1));
            return Json<dynamic>(query);
            
        }

    }
}
