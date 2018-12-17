using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IKEA.Api.Controllers
{
    using IKEA.IServices;
    using IKEA.Model;

    using IKEA.Services;
    using Unity.Attributes;


    /// <summary>
    /// 商品控制器
    /// </summary>
    [RoutePrefix("ShoppingCar")]
    public class ShoppingCarController : ApiController
    {
        /// <summary>
        /// 产品尺寸
        /// </summary>
        [Dependency]
        public IProduct_Size_Services product_Size { get; set; }
        /// <summary>
        /// 产品
        /// </summary>
        [Dependency]
        public IProduct_Services product_Services { get; set; }
        /// <summary>
        /// 产品类型
        /// </summary>
        [Dependency]
        public IProductType_Services productType_Services { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [Dependency]
        public IAddress_Services address { get; set; }
        #region  产品尺寸信息
        /// <summary>
        /// 添加产品尺寸信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public int Add(TProduct_Size product_Size)
        {

            int i = this.product_Size.Add(product_Size);
                return i;
         
        }

        /// <summary>
        /// 删除产品尺寸信息
        /// </summary>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public int Delete(int id)
        {

            int i = this.product_Size.Delete(id);
                return i;
           
        }

        /// <summary>
        /// 获取单个尺寸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetProduct_Size")]
        [HttpGet]
        public TProduct_Size GetProduct_Size(int id)
        {

            var i = this.product_Size.GetProduct_Size(id);
                return i;
           
        }

        /// <summary>
        /// 获取所有尺寸信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        [Route("GetProduct_Sizes")]
        [HttpGet]
        public IEnumerable<TProduct_Size> GetProduct_Sizes()
        {

            var i = this.product_Size.GetProduct_Sizes();
                return i;
           
        }

        /// <summary>
        /// 修改产品尺寸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("product_Size")]
        [HttpPut]
        public int Update(TProduct_Size product_Size)
        {

            var i = this.product_Size.Update(product_Size);
                return i;         
        }

        #endregion

        #region 产品类型表
        [Route("getProductType")]
        [HttpGet]
        public IHttpActionResult getProductType(int ProductTypeID)
        {
            
               // var sql = string.Format("SELECT* from tproducttype where PID = (SELECT ProductTypeID FROM tproduct where id = ID)");
            ///根据产品id获取产品信息
            //var i = product_Services.GetProducts().Where(r=>r.id.Equals(ProductTypeID)).FirstOrDefault();
            //根据产品类型id获取旗下所有产品类型信息
            var query = productType_Services.GetProducts(ProductTypeID);
            return Json<dynamic>(query);
                          
        }
        #endregion

        #region
        /// <summary>
        /// 添加地址
        /// </summary>
        /// <returns></returns>
        [Route("AddAddress")]
        [HttpPost]
        public int AddAddress(TAdderss adderss)
        {
            var i = this.address.Add(adderss);
            return i;
        }
        /// <summary>
        /// 根据用户ID获取地址信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        [Route("GetAddress")]
        [HttpGet]
        public IHttpActionResult GetAddress(int UserID)
        {
            var address = this.address.GetAddressesByUserID(UserID);
            return Json<dynamic>(address);
        }
        [Route("DelAddress")]
        [HttpGet]
        public int DelAddress(int ID)
        {
            var i = this.address.Delete(ID);
            return i;
        }
        /// <summary>
        /// 根据主键ID获取单个地址信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route("GetAdderssID")]
        [HttpGet]
        public TAdderss GetAdderssID(int ID)
        {
            var result = this.address.GetAddressByID(ID);
            return result;
        }
        /// <summary>
        /// 修改地址
        /// </summary>
        /// <param name="uptAddress"></param>
        /// <returns></returns>
        [Route("UpdateAddres")]
        [HttpPost]
        public int UpdateAddres(TAdderss uptAddress)
        {
            var result = this.address.Update(uptAddress);
            return result;
        }

       



        #endregion
    }
}
