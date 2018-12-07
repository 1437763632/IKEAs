using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 评价表
    /// </summary>
    public class Tevaluate
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        public int ShopID { get; set; }
        /// <summary>
        /// 评价
        /// </summary>
        public string Evaluate { get; set; }
        /// <summary>
        /// 星级
        /// </summary>
        public int StarLevel { get; set; }
        /// <summary>
        /// 评价时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Isdelete { get; set; }
    }
}
