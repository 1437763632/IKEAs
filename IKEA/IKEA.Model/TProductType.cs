using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    public class TProductType  //类别表
    {
        /// <summary>
        /// //主键id
        /// </summary>
        public int Id { get; set; }  
        /// <summary>
        ///  //产品类别名称
        /// </summary>
        public int ProductTypeName { get; set; }   
        /// <summary>
        /// //产品类别所属
        /// </summary>
        public int PID { get; set; }                
    }
}
