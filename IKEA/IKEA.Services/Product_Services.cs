﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using IKEA.Common;
using IKEA.IServices;
using IKEA.Model;
using MySql.Data.MySqlClient;

using JiebaNet.Analyser;
using JiebaNet.Segmenter;

namespace IKEA.Services
{
    public class Product_Services : IProduct_Services
    {
        /// <summary>
        /// 添加产品
        /// </summary>
        /// <param name="product"></param>
        /// <returns>int</returns>
        public int Add(TProduct product)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                //string sql = string.Format("insert into TProduct (ProductTypeID,ProductName,ProductMinPrice,ProductMaxPrice,ProductImage,IsPutaway) values(@ProductTypeID,@ProductName,@ProductMinPrice,@ProductMaxPrice,@ProductImage,@IsPutaway)");
                string sql = string.Format("insert into TProduct (ProductTypeID,ProductName,ProductMinPrice,ProductMaxPrice,ProductImage) values(@ProductTypeID,@ProductName,@ProductMinPrice,@ProductMaxPrice,@ProductImage)");
                int i = conn.Execute(sql, product);
                return i;
            }
        }
        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("delete from TProduct where Id=@Id");
                int i = conn.Execute(sql, id);
                return i;
            }
        }
        /// <summary>
        /// 根据ID获取产品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        public TProduct GetProduct(int id)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {

               
                string sql = string.Format("select * from TProduct where Id=@Id");
                var i = conn.Query<TProduct>(sql, new {Id=id }).SingleOrDefault();

                return i;
            }
        }
        /// <summary>
        /// 获取所有产品信息
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        public IEnumerable<TProduct> GetProducts()
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TProduct");
                var i = conn.Query<TProduct>(sql, null).ToList();
                return i;
            }
        }
        /// <summary>
        ///搜索商品名称获取模糊商品信息
        /// </summary>
        /// <param name="productName"></param>
        /// <returns></returns>
        public IEnumerable<TProduct> GetProductName(string productName)
        {
            var segmenter = new JiebaSegmenter();

            //productName = segmenter.Cut(productName,cutAll:true).ToString();
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TProduct where ProductName like @ProductName");
                //IEnumerable <string> sql = segmenter.Cut(string.Format("select * from TProduct where ProductName  like  @ProductName"), cutAll:true);
                var result = conn.Query<TProduct>(sql, new { ProductName ="%"+ productName+"%" }).ToList();
                return result;
            }
        }
        /// <summary>
        /// 修改产品信息
        /// </summary>
        /// <param name="product"></param>
        /// <returns>int</returns>
        public int Update(TProduct product)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("update TProduct set ProductTypeID=@ProductTypeID,ProductName=@ProductName,ProductMinPrice=@ProductMinPrice,ProductMaxPrice=@ProductMaxPrice,ProductImage=@ProductImage,IsPutaway=@IsPutaway where Id=@Id");
                var i = conn.Execute(sql, product);
                return i;
            }
        }
        /// <summary>
        /// 获取所有椅子
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        public IEnumerable<TProduct> GetProductchair(int ProductTypeId)
        {
            using (System.Data.IDbConnection conn = DapperHelper.GetConnString())
            {
                string sql = string.Format("select * from TProduct where ProductTypeID =@ProductTypeID");
                var i = conn.Query<TProduct>(sql, new { ProductTypeID=ProductTypeId}).ToList();
                return i;
            }
        }
    }
}
