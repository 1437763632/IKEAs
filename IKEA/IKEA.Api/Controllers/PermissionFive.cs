using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IKEA.Model;
using IKEA.IServices;
using IKEA.Services;
using Unity.Attributes;
using System.Web.Http;

namespace IKEA.Api.Controllers
{
    [RoutePrefix("PermissionFive")]
    public class PermissionFive
    {
        /// <summary>
        /// 所有产品增删改查
        /// </summary>
        /// <param name="productDetail"></param>
        /// <returns>int</returns>
        //[Route("ProductOperation")]
        //[HttpGet]
        //public IHttpActionResult ProductOperation()
        //{

        //    var query = from p in product.GetTProductDetail(1)
        //                join c in color_Services.GetColors()
        //                on p.colorID equals c.Id
        //                join t in product_Texture_Services.GetProduct_Textures()
        //                on p.ProductTextureID equals t.Id

        //                select new
        //                {
        //                    Id = p.Id,
        //                    Colorname = c.Colorname,
        //                    Texture = t.Texture
        //                };
        //    // query.Where(r => r.p.ProductID.Equals(1));
        //    return Json<dynamic>(query);

        //}
    }
}