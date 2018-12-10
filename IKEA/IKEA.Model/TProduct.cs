using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 产品表
    /// </summary>
    public class TProduct 
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int id { get; set; } 
        /// <summary>
        /// 类别表_产品类别id
        /// </summary>
        public int ProductTypeID { get; set; } 
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }      
        /// <summary>
        /// 最低价格
        /// </summary>
        public decimal ProductMinPrice { get; set; }        
        /// <summary>
        /// 最高价格
        /// </summary>
        public decimal ProductMaxPrice { get; set; }       
        /// <summary>
        /// 第一张图片
        /// </summary>
        public string ProductImage { get; set; }
        /// <summary>
        /// 是否上架
        /// </summary>
        public bool IsPutaway { get; set; }                 
    }
}
