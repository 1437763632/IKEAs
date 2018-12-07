using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 颜色服务接口
    /// </summary>
    public interface IColor_Services
    {
        /// <summary>
        /// 获取所有颜色
        /// </summary>
        /// <returns></returns>
        IEnumerable<TColor> GetColors();
        /// <summary>
        /// 添加颜色
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        int Add(TColor color);
        /// <summary>
        /// 删除颜色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 修改颜色
        /// </summary>
        /// <param name="color">颜色对象</param>
        /// <returns></returns>
        int Update(TColor color);
        /// <summary>
        /// 根据ID找颜色对象
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        TColor GetColorById(int id);
    }
}
