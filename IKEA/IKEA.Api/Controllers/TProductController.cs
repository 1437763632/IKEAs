﻿using IKEA.IServices;
using IKEA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;
using IKEA.Services;
using Unity.Attributes;

namespace IKEA.Api.Controllers
{
    [RoutePrefix("TProduct")]
    public class TProductController : ApiController
    {
        [Unity.Attributes.Dependency]
        public IProduct_Services product { get; set; }
        /// <summary>
        /// 添加产品
        /// </summary>
        /// <param name="product"></param>
        /// <returns>int</returns>
        [Route("Add")]
        [HttpPost]
        public int Add(TProduct product)
        {
            var i = this.product.Add(product);
            return i;
        }
        /// <summary>
        /// 删除产品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("Delete")]
        [HttpDelete]
        public int Delete(int id)
        {
            var i = this.product.Delete(id);
            return i;
        }
        /// <summary>
        /// 根据ID获取产品信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TProduct</returns>
        [Route("GetProduct")]
        [HttpGet]
        public TProduct GetProduct(int id)
        {
            var count = this.product.GetProduct(id);
            return count;
        }
        /// <summary>
        /// 获取所有产品信息
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        [Route("GetProducts")]
        [HttpGet]
        public IEnumerable<TProduct> GetProducts()
        {
            var result = this.product.GetProducts();
            return result;
        }
        /// <summary>
        /// 修改产品信息
        /// </summary>
        /// <param name="product"></param>
        /// <returns>int</returns>
        [Route("Update")]
        [HttpPut]
        public int Update(TProduct product)
        {
            var count = this.product.Update(product);
            return count;
        }
        /// <summary>
        /// 获取所有椅子
        /// </summary>        
        /// <returns>IEnumerable<TPayment></returns>
        [Route("GetProductchair")]
        [HttpGet]
        public IEnumerable<TProduct> GetProductchair(int PID)
        {
            var result = this.product.GetProductchair(PID);
            return result;
        }
    }
}
