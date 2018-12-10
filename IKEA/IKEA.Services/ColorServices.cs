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

   public class ColorServices : IColor_Services

    {
        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public int Add(TColor color)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("insert into tColor(Colorname) value(@Colorname)");
                int i = conn.Execute(sql, color);
                return i;
            }
        }


        /// <summary>
        /// 删除颜色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

                string sql = string.Format("delete from tColor where Id=@id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }

        /// <summary>
        /// 根据ID找颜色对象
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public TColor GetColorById(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from tColor where Id=@Id");
                var result = conn.Query<TColor>(sql, new { Id = id }).SingleOrDefault();
                return result;
            }
        }

        /// <summary>
        /// 获取所有颜色
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TColor> GetColors()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from tColor ");
                var i = conn.Query<TColor>(sql, null).ToList();
                return i;
            }
        }

        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <param name="color">颜色对象</param>
        /// <returns></returns>
        public int Update(TColor color)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update tColor set Colorname=@Colorname where Id=@Id");
                var i = conn.Execute(sql, color);
                return i;
            }
        }
    }
}
