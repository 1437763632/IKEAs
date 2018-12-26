using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 图片表
    /// </summary>
    public class TImage
    {
        /// <summary>
        /// 主键id
        /// </summary>
        public int Id { get; set; }                     
        /// <summary>
        /// 产品id
        /// </summary>
        public int ProductID { get; set; }              
        /// <summary>
        /// 产品详情id
        /// </summary>
        public int ProductDetailID { get; set; }        
        /// <summary>
        /// 图片路径
        /// </summary>
        public string ImageUrl { get; set; }            
        /// <summary>
        /// 是否启用
        /// </summary>
        //public bool isUsed { get; set; }                
    }
}
