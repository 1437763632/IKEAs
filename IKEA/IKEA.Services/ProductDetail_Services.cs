using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using Model;
    using IServices;
    using Common;
    using Dapper;
    using MySql.Data.MySqlClient;
    public class ProductDetail_Services : IProductDetail_Services
    {
        /// <summary>
        /// 添加产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        public int Add(TProductDetail productDetail)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TProductDetail(ProductID,ProductTypeID,ProductSizeID,ProductTextureID,colorID,Price,RealPrice,Inventory,ReservedInventory) value(@ProductID,@ProductTypeID,@ProductSizeID,@ProductTextureID,@colorID,@Price,@RealPrice,@Inventory,@ReservedInventory)");
                int i = conn.Execute(sql, productDetail);
                return i;
            }
        }

        /// <summary>
        /// 删除产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from TProductDetail where Id=@Id");
                int resaut = conn.Execute(sql, new { Id = id });
                return resaut;
            }
        }

        /// <summary>
        /// 根据ID获取产品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        public TProductDetail GetTProductDetailId(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("select Id, ProductID, ProductTypeID, ProductSizeID, ProductTextureID, colorID, Price, RealPrice, Inventory, ReservedInventory from TProductDetail where Id = @Id");
                var resaut = conn.Query<TProductDetail>(sql, new { Id=id}).SingleOrDefault();
                return resaut;
            }
        }

        

        public TProductDetail GetTProductDetail(int productID)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select Id, ProductID, ProductTypeID, ProductSizeID, ProductTextureID, colorID, Price, RealPrice, Inventory, ReservedInventory from TProductDetail where ProductID=@ProductID");
                var i = conn.Query<TProductDetail>(sql, new { ProductID= productID }).SingleOrDefault();
                return i;
            }
        }



        /// <summary>
        /// 修改产品详情
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        public int Update(TProductDetail productDetail)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TProductDetail set ProductID=@ProductID,ProductTypeID=@ProductTypeID,ProductSizeID=@ProductSizeID,ProductTextureID=@ProductTextureID,colorID=@colorID,Price=@Price,RealPrice=@RealPrice,Inventory=@Inventory,ReservedInventory=@ReservedInventory where Id=@Id");
                var i = conn.Execute(sql, productDetail);
                return i;
            }
        }

        /// <summary>
        /// 获取所有产品详情
        /// </summary> 
        /// <param name="productID"></param>
        /// <returns> IEnumerable<TProduct></returns>

       public IEnumerable<TProductDetail> GetTProductDetails()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select Id, ProductID, ProductTypeID, ProductSizeID, ProductTextureID, colorID, Price, RealPrice, Inventory, ReservedInventory from TProductDetail");
                var i = conn.Query<TProductDetail>(sql, null).ToList();

                return i;
            }
        }
    }
}
