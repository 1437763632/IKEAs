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
            container.RegisterType<IColor_Services, ColorServices>();

            container.RegisterType<IProductDetail_Services, ProductDetail_Services>();

            container.RegisterType<IProduct_Size_Services, ProductSizeServices>();

            container.RegisterType<IProduct_Texture_Services, ProductTextureServices>();

            container.RegisterType<IProductType_Services, ProductType_Services>();

            container.RegisterType<IRight_Services, Right_Services>();
            container.RegisterType<IProduct_Services, Product_Services>();
            container.RegisterType<IRole_Right_Services, Role_Right_Services>();

            container.RegisterType<IRole_Services, Role_Services>();

            container.RegisterType<ITrolley_Services, Trolley_Services>();

            container.RegisterType<ITrolleyDetail_Services, TrolleyDetail_Services>();
            container.RegisterType<IManager_Services, Manager_Services>();

        }
    }
}