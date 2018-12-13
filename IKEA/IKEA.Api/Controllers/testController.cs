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
    [RoutePrefix("test")]
    public class testController : ApiController
    {
        #region 地址测试连接
        [Dependency]
        public IAddress_Services Address { get; set; }
        /// <summary>
        /// 根据主键ID查询单条地址信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetAddressByID")]
        [HttpGet]
        public TAdderss GetAddressByID(int id)
        {
            var i = Address.GetAddressByID(id);
            return i;
        }

        /// <summary>
        /// 根据用户ID查询用户地址信息
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        [Route("GetAddressesByUserID")]
        [HttpGet]
        public IEnumerable<TAdderss> GetAddressesByUserID(int UserID)
        {
            var i = Address.GetAddressesByUserID(UserID);
            return i;
        }

        #endregion

        #region 颜色测试连接
        [Dependency]
        public IColor_Services color { get; set; }
        /// <summary>
        /// 根据ID找颜色对象
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        [Route("GetColorById")]
        [HttpGet]
        public TColor GetColorById(int id)
        {
            var i = color.GetColorById(id);
            return i;
        }

        /// <summary>
        /// 获取所有颜色
        /// </summary>
        /// <returns></returns>
        [Route("GetColors")]
        [HttpGet]
        public IEnumerable<TColor> GetColors()
        {
            var i = color.GetColors();
            return i;
        }
        #endregion

        #region 优惠券测试连接
        [Dependency]
        public IDisCount_Services discount { get; set; }
        /// <summary>
        /// 根据ID优惠券
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDisCount")]
        public TDisCount GetDisCount(int id)
        {
            var i = discount.GetDisCount(id);
            return i;
        }
        /// <summary>
        /// 查询优惠券
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDisCounts")]
        public IEnumerable<TDisCount> GetDisCounts()
        {
            var i = discount.GetDisCounts();
            return i;
        }
        #endregion

        #region 评价表
        [Dependency]
        public IEvaluate_Services evaluate { get; set; }

        /// <summary>
        /// 根据ID查询评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEvaluate")]
        public Tevaluate GetEvaluate(int id)
        {
            var i = evaluate.GetEvaluate(id);
            return i;
        }
        /// <summary>
        /// 根据产品ID查询评价表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetTevaluates")]
        public IEnumerable<Tevaluate> GetTevaluates(int ProductID)
        {
            var i = evaluate.GetTevaluates(ProductID);
            return i;
        }
        #endregion

        #region 图片
        [Dependency]
        public IImage_Services image { get; set; }

        [HttpGet]
        [Route("GetImage")]
        /// <summary>
        /// 根据ID获取图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TImage GetImage(int id)
        {
            var i = image.GetImage(id);
            return i;
        }

        [HttpGet]
        [Route("GetImages")]
        /// <summary>
        ///  根据根据产品详情表查询图片
        /// </summary>
        /// <param name="ProductDetailID"></param>
        /// <returns></returns>
        public IEnumerable<TImage> GetImages()
        {
            var i = image.GetImages();
            return i;
        }
        #endregion

        #region 日志
        [Dependency]
        public ILogServices Log { get; set; }


        [HttpGet]
        [Route("GetLogs")]
        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<TLog> GetLogs(int id)
        {
            var i = Log.GetLogs(id);
            return i;
        }
        #endregion

        #region 管理员角色关系表
        [Dependency]
        public IManage_Role_Services manage_Role { get; set; }
        [HttpGet]
        [Route("GetManage")]
        /// <summary>
        /// 获取单个用户角色信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TManage_Role GetManage(int id)
        {
            var i = manage_Role.GetManage(id);
            return i;
        }

        [HttpGet]
        [Route("GetManages")]
        /// <summary>
        /// 获取所有管理员角色关系表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TManage_Role> GetManages(int ManageID)
        {
            var i = manage_Role.GetManages(ManageID);
            return i;
        }
        #endregion

        #region 管理员角色
        [Dependency]
        public IManager_Services manager { get; set; }
        [HttpGet]
        [Route("GetManagea")]
        /// <summary>
        /// 获取单个管理员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TManage GetManagea(int id)
        {
            var i = manager.GetManage(id);
            return i;
        }

        [HttpGet]
        [Route("GetManages")]
        /// <summary>
        /// 根据角色获取
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TManage> GetManages()
        {
            var i = manager.GetManages();
            return i;
        }
        #endregion

        #region 订单
        [Dependency]
        public IOrder_Services order { get; set; }
        /// <summary>
        /// 获取单个订单
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TOrder</returns>
        [HttpGet]
        [Route("GetOrder")]
        public TOrder GetOrder(int id)
        {
            var i = order.GetOrder(id);
            return i;
        }
        /// <summary>
        /// 根据用户ID获取所有订单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>IEnumerable<TOrder></returns>
        [HttpGet]
        [Route("GetOrders")]
        public IEnumerable<TOrder> GetOrders(int userID)
        {
            var i = order.GetOrders(userID);
            return i;
        }
        #endregion

        #region 订单详情
        [Dependency]
        public IOrderDetail_Services orderDetail { get; set; }

        /// <summary>
        /// 获取订单详情
        /// </summary>
        /// <param name="id">订单详情ID</param>
        /// <returns>TOrderDetail</returns>
        [HttpGet]
        [Route("GetOrderDetail")]
        public TOrderDetail GetOrderDetail(int id)
        {
            var i = orderDetail.GetOrderDetail(id);
            return i;
        }
        /// <summary>
        /// 根据订单id获取所有订单详情
        /// </summary>
        /// <param name="orderID">订单id</param>
        /// <returns>IEnumerable<TOrderDetail> </returns>
        [HttpGet]
        [Route("GetOrderDetails")]
        public IEnumerable<TOrderDetail> GetOrderDetails(int orderID)
        {
            var i = orderDetail.GetOrderDetails(orderID);
            return i;
        }
        #endregion

        #region 支付
        [Dependency]
        public IPayment_Services payment { get; set; }

        /// <summary>
        /// 根据ID获取支付信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPayment")]
        public TPayment GetPayment(int id)
        {
            var i = payment.GetPayment(id);
            return i;
        }
        /// <summary>
        /// 获取用户所有支付信息
        /// </summary>
        /// <param name="id">用户信息</param>
        /// <returns>IEnumerable<TPayment></returns>
        [HttpGet]
        [Route("GetPayments")]
        public IEnumerable<TPayment> GetPayments(int id)
        {
            var i = payment.GetPayments(id);
            return i;
        }
        #endregion

        #region 产品
        [Dependency]
        public IProduct_Services product { get; set; }
        /// <summary>
        /// 根据ID获取产品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        [HttpGet]
        [Route("GetProduct")]
        public TProduct GetProduct(int id)
        {
            var i = product.GetProduct(id);
            return i;
        }
        /// <summary>
        /// 获取所有产品信息
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        [HttpGet]
        [Route("GetProducts")]
        public IEnumerable<TProduct> GetProducts()
        {
            var i = product.GetProducts();
            return i;
        }
        #endregion

        #region 产品详情
        [Dependency]
        public IProductDetail_Services productDetail { get; set; }

        [HttpGet]
        [Route("GetTProductDetailId")]
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
        [Route("GetTProductDetail")]
        public IEnumerable<TProductDetail> GetTProductDetails()
        {
            var i = productDetail.GetTProductDetails();
            return i;
        }
        #endregion

        #region 产品尺寸
        [Dependency]
        public IProduct_Size_Services Product_Size { get; set; }

        [HttpGet]
        [Route("GetProduct_Size")]
        /// <summary>
        /// 获取单个尺寸信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TProduct_Size GetProduct_Size(int id)
        {
            var i = Product_Size.GetProduct_Size(id);
            return i;
        }

        [HttpGet]
        [Route("GetProduct_Sizes")]
        /// <summary>
        /// 获取所有尺寸信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public IEnumerable<TProduct_Size> GetProduct_Sizes()
        {
            var i = Product_Size.GetProduct_Sizes();
            return i;
        }
        #endregion

        #region 材质
        [Dependency]
        public IProduct_Texture_Services Product_Texture { get; set; }
        /// <summary>
        /// 获取单个材质信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProduct_Texture")]
        public TProduct_Texture GetProduct_Texture(int id)
        {
            var i = Product_Texture.GetProduct_Texture(id);
            return i;
        }

        /// <summary>
        /// 获取所有材质信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetProduct_Textures")]
        public IEnumerable<TProduct_Texture> GetProduct_Textures()
        {
            var i = Product_Texture.GetProduct_Textures();
            return i;
        }
        #endregion

        #region 产品类别
        [Dependency]
        public IProductType_Services ProductType { get; set; }

        [HttpGet]
        [Route("GetProducttype")]
        /// <summary>
        /// 获取单个产品类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TProductType GetProducttype(int id)
        {
            var i = ProductType.GetProduct(id);
            return i;
        }
        [HttpGet]
        [Route("GetProducts")]
        /// <summary>
        /// 获取所有产品类型
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public IEnumerable<TProductType> GetProducts(int pid)
        {
            var i = ProductType.GetProducts(pid);
            return i;
        }
        #endregion

        #region 权限
        [Dependency]
        public IRight_Services right { get; set; }

        #endregion

        #region 权限角色关联表
        [Dependency]
        public IRole_Right_Services role_Right { get; set; }
        #endregion

        #region 角色
        [Dependency]
        public IRole_Services role { get; set; }
        #endregion

        #region 购物车
        [Dependency]
        public ITrolley_Services trolley { get; set; }
        #endregion

        #region 购物车详情
        [Dependency]
        public ITrolleyDetail_Services trolleyDetail { get; set; }
        #endregion


    }
}
