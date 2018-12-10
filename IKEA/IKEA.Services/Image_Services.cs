using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Services
{
    using IKEA.Model;
    using MySql.Data.MySqlClient;
    using IServices;
    using IKEA.Common;
    using Dapper;
    public class Image_Services : IImage_Services
    {
        /// <summary>
        /// 添加图片
        /// </summary>
        /// <param name="imageList"></param>
        /// <returns></returns>
        public int Add(IEnumerable<TImage> imageList)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("INSERT into timage(ProductID,ProductDetailID,ImageUrl,isUsed) VALUES(@ProductID,@ProductDetailID,@ImageUrl,@isUsed)");
                int i = conn.Execute(sql, imageList);
                return i;
            }
        }
        /// <summary>
        /// 删除图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("DELETE FROM timage WHERE Id = @Id");
                int i = conn.Execute(sql, new { Id = id });
                return i;
            }
        }
        /// <summary>
        /// 根据ID获取图片
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TImage GetImage(int id)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM timage WHERE Id = @Id");
                var result = conn.Query<TImage>(sql, new { Id = id }).SingleOrDefault();
                return result;
            }
        }
        /// <summary>
        ///  根据根据产品详情表查询图片
        /// </summary>
        /// <param name="ProductDetailID"></param>
        /// <returns></returns>
        public IEnumerable<TImage> GetImages(int ProductDetailID)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("SELECT * FROM timage where ProductDetailID=@ProductDetailID");
                var result = conn.Query<TImage>(sql, new { ProductDetailID = ProductDetailID }).ToList();
                return result;
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public int Update(TImage image)
        {
            using (MySqlConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("UPDATE timage SET ProductID=ProductID , ProductDetailID=ProductDetailID,ImageUrl=ImageUrl,isUsed=isUsed WHERE id = Id");
                int i = conn.Execute(sql, image);
                return i;
            }
        }
    }
}
