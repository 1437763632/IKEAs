using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using MySql.Data.MySqlClient;
    using Dapper;
    using IKEA.Model;
    using IServices;
    using Common;
    /// <summary>
    /// 产品详情表
    /// </summary>
    public class TProductDetailService : IProductDetail_Services
    {


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns></returns>

        public int Add(TProductDetail productDetail)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("insert into tproductdetail(ProductTypeID,ProductID,ProductSizeID,ProductTextureID,colorID,Price,ReaLPrice,Inventory,ReservedInventory) VALUES(@ProductTypeID,@ProductID,@ProductSizeID,@ProductTextureID,@colorID,Price,@ReaLPrice,@Inventory,@ReservedInventory)");
                int i = conn.Execute(sql, productDetail);
                return i;
            }
        }
        /// <summary>
        /// 根据ID修改产品详情信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Update(TProductDetail productDetail)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                string sql = string.Format("UPDATE tproductdetail set ProductTypeID =@ProductTypeID, ProductID =@ProductID, ProductSizeID =@ProductSizeID, ProductTextureID =@ProductTextureID, colorID =@colorID, Price =@Price, ReaLPrice =@ReaLPrice, Inventory =@Inventory, ReservedInventory =@ReservedInventory where Id =@ID");
                int i = conn.Execute(sql, new { Id = productDetail });
                return i;

            }
        }
        /// <summary>
        /// 根据ID删除单个产品详情信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                string sql = string.Format("DELETE FROM tproductdetail where Id=@Id");
                int i = conn.Execute(sql, new { Id = id });
                // int i = conn.Execute(sql, ID);
                return i;
            }
        }
        /// <summary>
        /// 获取单个产品详情信息
        /// </summary>
        /// <returns></returns>
        public TProductDetail GetTProductDetailId(int id)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                string sql = string.Format("select * from tproductdetail where Id=@Id");
                var result = conn.Query<TProductDetail>(sql, new { Id = id }).FirstOrDefault();
                return result;
            }
        }
        /// <summary>
        /// 根据产品ID获得产品详情列表
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
        public IEnumerable<TProductDetail> GetTProductDetail(int productID)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM ttrolleydetail where productID=@productID");
                var result = conn.Query<TProductDetail>(sql, productID).ToList();
                return result;
            }
        }

        TProductDetail IProductDetail_Services.GetTProductDetail(int productID)
        {
            throw new NotImplementedException();
        }
    }
}
