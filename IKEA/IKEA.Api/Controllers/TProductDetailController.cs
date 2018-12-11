﻿using System;
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

        #region 属性注入
        [Dependency]
        public IAddress_Services Address { get; set; }
        [Dependency]
        public IColor_Services color { get; set; }
        [Dependency]
        public IDisCount_Services discount { get; set; }
        [Dependency]
        public IImage_Services image { get; set; }
        [Dependency]
        public ILogServices Log { get; set; }
        [Dependency]
        public IManage_Role_Services manage_Role { get; set; }
        [Dependency]
        public IManager_Services manager { get; set; }
        [Dependency]
        public IOrder_Services order { get; set; }
        [Dependency]
        public IOrderDetail_Services orderDetail { get; set; }
        [Dependency]
        public IPayment_Services payment { get; set; }
        [Dependency]
        public IProduct_Services product { get; set; }
        [Dependency]
        public IProductDetail_Services productDetail { get; set; }
        [Dependency]
        public IProduct_Size_Services Product_Size { get; set; }
        [Dependency]
        public IProduct_Texture_Services Product_Texture { get; set; }
        [Dependency]
        public IProductType_Services ProductType { get; set; }
        [Dependency]
        public IRight_Services right { get; set; }

        [Dependency]
        public IRole_Right_Services role_Right { get; set; }
        [Dependency]
        public IRole_Services role { get; set; }
        [Dependency]
        public ITrolley_Services trolley { get; set; }

        [Dependency]
        public ITrolleyDetail_Services trolleyDetail { get; set; }

        #endregion
       

        #region 产品详情
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
        [HttpGet]
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
        /// <summary>
        /// 根据ID获取产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        public TProductDetail GetTProductDetailId(int id)
        {
            var i = productDetail.GetTProductDetailId(id);
            return i;
        }

        /// <summary>
        /// 获取所有产品详情
        /// </summary> 
        /// <param name="productID"></param>
        /// <returns> IEnumerable<TProduct></returns>
        [HttpGet]
        [Route("GetTProductDetails")]
        public IEnumerable<TProductDetail> GetTProductDetails()
        {
            var i = productDetail.GetTProductDetails();
            return i;
        }


        /// <summary>
        /// 获取产品详情
        /// </summary> 
        /// <param name="productID"></param>
        /// <returns> IEnumerable<TProduct></returns>
        [Route("GetproductID")]
        [HttpGet]
        public TProductDetail GetTProductDetail()
        {
            var resault = productDetail.GetTProductDetails();
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

            var count = this.productDetail.Update(productDetail);
            return count;
        }

        #endregion
        #region 产品


        #endregion



        /// <summary>
        /// 查看产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        [Route("SSS")]
        [HttpGet]
        public IHttpActionResult SSS(int productID)
        {

            var query = from p in productDetail.GetTProductDetails( )
                        join c in color.GetColors()
                        on p.colorID equals c.Id
                        join t in Product_Texture.GetProduct_Textures()
                        on p.ProductTextureID equals t.Id


                        select new
                        {
                            Id = p.Id,
                            Colorname = c.Colorname,
                            Texture = t.Texture
                        };
            // query.Where(r => r.p.ProductID.Equals(1));
            return Json<dynamic>(query);

        }


        
    }
}
