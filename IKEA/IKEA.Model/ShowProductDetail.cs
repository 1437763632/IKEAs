using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
   public class ShowProductDetail
    {
        /// <summary>
        /// //主键id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// //产品id
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        ///  //产品类别id
        /// </summary>
        public int ProductTypeID { get; set; }

        public List<TProductType> productTypes { get; set; }
        /// <summary>
        /// //产品尺寸id
        /// </summary>
        public List<TProduct_Size> product_Sizes { get; set; }
        public int ProductSizeID { get; set; }
        /// <summary>
        /// //产品材质id
        /// </summary>
        public List<TProduct_Texture> product_Textures { get; set; }
        public int ProductTextureID { get; set; }
        /// <summary>
        ///   //颜色id
        /// </summary>
        public List<TColor> colors { get; set; }
        public int colorID { get; set; }
        /// <summary>
        ///  //标注
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        ///  //实际价格
        /// </summary>
        public decimal RealPrice { get; set; }
        /// <summary>
        ///  //产品库存
        /// </summary>
        public int Inventory { get; set; }
        /// <summary>
        ///  //预留库存量
        /// </summary>
        public int ReservedInventory { get; set; }
    }
}
