using System;

using Unity;

namespace IKEA.Api
{
    using IKEA.IServices;
    using IKEA.Services;

    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IAddress_Services, Address_Services>();    //地址
          
            container.RegisterType<IColor_Services, ColorServices>();  //  颜色

            container.RegisterType<IDisCount_Services, DisCount_Services>();// 优惠券

            container.RegisterType<IEvaluate_Services, Evaluate_Services>();// 评价
            
            container.RegisterType<IImage_Services, Image_Services>();// 图片

            container.RegisterType<ILogServices, LogServices>();// 日志

            container.RegisterType<IManage_Role_Services, Manage_Role_Services>();// 管理员角色关联表

            container.RegisterType<IManager_Services, Manager_Services>();// 管理员

            container.RegisterType<IOrder_Services, Order_Services>();// 订单

            container.RegisterType<IOrderDetail_Services, OrderDetail_Services>();// 订单详情

            container.RegisterType<IPayment_Services, Payment_Services>();// 支付

            container.RegisterType<IProduct_Services, Product_Services>();// 产品

            container.RegisterType<IProductDetail_Services, ProductDetail_Services>();// 产品详情

            container.RegisterType<IProduct_Size_Services, ProductSizeServices>();// 产品尺寸

            container.RegisterType<IProduct_Texture_Services, ProductTextureServices>();// 产品材质

            container.RegisterType<IProductType_Services, ProductType_Services>();// 产品类型

            container.RegisterType<IRight_Services, Right_Services>();//   权限
           
            container.RegisterType<IRole_Right_Services, Role_Right_Services>();// 角色权限

            container.RegisterType<IRole_Services, Role_Services>();// 角色 

            container.RegisterType<ITrolley_Services, Trolley_Services>();// 购物车

            container.RegisterType<ITrolleyDetail_Services, TrolleyDetail_Services>();// 购物车详情

            container.RegisterType<IUser_Services, User_Services>();// 用户

            container.RegisterType<IApprovalServices, ApprovalServices>();// 流程控制

        }
    }
}