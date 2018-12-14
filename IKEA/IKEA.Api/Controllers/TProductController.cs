using IKEA.IServices;
using IKEA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using IKEA.Services;
using Unity.Attributes;

namespace IKEA.Api.Controllers
{
    [RoutePrefix("TProduct")]
    public class TProductController : ApiController
    {
        [Unity.Attributes.Dependency]
        public IProduct_Services Product { get; set; }

        [Unity.Attributes.Dependency]
        public IProductDetail_Services ProductDetail { get; set; }
        [Unity.Attributes.Dependency]
        public IProduct_Size_Services Product_Sizes{ get; set; }
        [Unity.Attributes.Dependency]
        public ITrolley_Services Trolley_Services { get; set; }
        [Unity.Attributes.Dependency]
        public ITrolleyDetail_Services trolleyDetail_Services { get; set; }
        [Unity.Attributes.Dependency]
        public IProduct_Texture_Services product_Texture_Services { get; set; }
        /// <summary>
        /// 添加产品
        /// </summary>
        /// <param name="product"></param>
        /// <returns>int</returns>
        [Route("Add")]
        [HttpPost]
        public int Add(TProduct product)
        {
            var i = this.Product.Add(product);
            return i;
        }
        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public int Delete(int id)
        {
            var i = this.Product.Delete(id);
            return i;
        }
        /// <summary>
        /// 根据ID获取产品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        [Route("GetProduct")]
        [HttpGet]
        public TProduct GetProduct(int id)
        {
            var count = this.Product.GetProduct(id);
            return count;
        }
        /// <summary>
        /// 获取所有产品信息
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        [Route("GetProducts")]
        [HttpGet]
        public IEnumerable<TProduct> GetProducts()
        {
            var result = this.Product.GetProducts();
            return result;
        }
        /// <summary>
        /// 修改产品信息
        /// </summary>
        /// <param name="product"></param>
        /// <returns>int</returns>
        [Route("Update")]
        [HttpPut]
        public int Update(TProduct product)
        {
            var count = this.Product.Update(product);
            return count;
        }
        /// <summary>
        /// 获取所有椅子
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        [Route("GetProductchair")]
        [HttpGet]
        public IEnumerable<TProduct> GetProductchair(int ProductTypeId)
        {
            var result = this.Product.GetProductchair(ProductTypeId);
            return result;
        }


        [Route("GetCarList")]
        [HttpGet]
        public IHttpActionResult GetCarList()
        {
            var query = from P in Product.GetProducts()
                        join T in ProductDetail.GetTProductDetails()
                        on P.id equals T.ProductID
                        join S in Product_Sizes.GetProduct_Sizes()
                        on T.ProductSizeID equals S.Id
                        select new
                        {
                            P.IsPutaway,
                            P.ProductImage,
                            P.ProductMaxPrice,
                            P.ProductMinPrice,
                            P.ProductName,
                            P.ProductTypeID,
                            T.Inventory,
                            T.Price,
                            T.ProductID,
                            T.ProductSizeID,
                            T.ProductTextureID,                            
                            T.RealPrice,
                            T.ReservedInventory,
                            S.ProductSize
                        };
            return Json<dynamic>(query);

        }
        /// <summary>
        /// 获取用户所有订单信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        [Route("GetCart")]
        [HttpGet]
        public IHttpActionResult GetCart(int userid=1)
        {
            ///获取用户所有订单
            var query =  Trolley_Services.GetTrolleys().Where(u=>u.UserID.Equals(userid));
            //联查获取订单详情信息
            var query1 = from q in query
                    join d in trolleyDetail_Services.GetTrolleyDetails()
                    on q.Id equals d.TrolleyID
                    select new
                    {
                        q.SumNumber,
                        q.p_Sum,
                        d.Id,
                        d.Price,
                        d.ProductDetailID,
                        d.ProductID,
                        d.RealPrice,
                        d.TrolleyID
                    };
            //联查获取所需信息
            var query2 = from q in query1
                         join p in Product.GetProducts()
                         on q.ProductID equals p.id
                         join d in ProductDetail.GetTProductDetails()
                         on q.ProductDetailID equals d.Id
                         join s in Product_Sizes.GetProduct_Sizes()
                         on d.ProductSizeID equals s.Id
                         join t in product_Texture_Services.GetProduct_Textures()
                         on d.ProductTextureID equals t.Id
                         select new
                         {
                             q.Id,
                             q.Price,
                             q.ProductDetailID,
                             q.ProductID,
                             q.RealPrice,
                             q.SumNumber,
                             q.TrolleyID,
                             p.ProductImage,
                             p.ProductName,
                             d.ProductSizeID,
                             s.ProductSize,
                             d.ProductTextureID,
                             t.Texture

                         };
            var resault = Json<dynamic>(query2);
            return resault;
        }
    }
}
