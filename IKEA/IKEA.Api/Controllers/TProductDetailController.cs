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
       public IProductDetail_Services productDetail { get; set; }

        /// <summary>
        /// 添加产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        [Route("Add")]
        [HttpPost]
        public int Add(TProductDetail productDetail)
        {
            var i = this.productDetail.Add(productDetail);
            return i;
        }

        /// <summary>
        /// 删除产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public int Delete(int id)
        {
            var i = this.productDetail.Delete(id);
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
            var count = this.productDetail.GetTProductDetailId(id);
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
            var resault = productDetail.GetTProductDetail(productID);
            return resault;
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

            var count = this.productDetail.Update(productDetail);
            return count;
        }


    }
}
