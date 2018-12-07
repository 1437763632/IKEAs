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

    public class ProductTextureServices : IProduct_Texture_Services
    {
        /// <summary>
        /// 添加材质信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public int Add(TProduct_Texture product_Texture)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into TProduct_Texture(Texture) value(@Texture)");
                int i = conn.Execute(sql, product_Texture);
                return i;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                
                string sql = string.Format("delete  Product(Id) where id=@Id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 获取单个材质信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TProduct_Texture GetProduct_Texture(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                MySqlParameter mySqlParameters = new MySqlParameter("@Id",id);
                string sql = string.Format("select * from TProduct_Texture where id=@Id");
                var i = conn.Query<TProduct_Texture>(sql, mySqlParameters).FirstOrDefault();
                return i;
            }
        }

        /// <summary>
        /// 获取所有材质信息
        /// </summary>
        /// <param name="product_Texture"></param>
        /// <returns></returns>
        public IEnumerable<TProduct_Texture> GetProduct_Textures()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                //MySqlParameter mySqlParameters = new MySqlParameter("@Id", id);
                string sql = string.Format("select * from TProduct_Texture ");
                var i = conn.Query<TProduct_Texture>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Update(TProduct_Texture product_Texture)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TProduct_Texture set Texture=@Texture where Id=@Id");
                var i = conn.Execute(sql, product_Texture);
                return i;
            }
        }
    }
}
