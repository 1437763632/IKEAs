using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 权限管理接口
    /// </summary>
    public interface IRightServices
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        int Add(TRight right);
        /// <summary>
        /// 修改权限信息
        /// </summary>
        /// <param name="right"></param>
        /// <returns></returns>
        int Update(TRight right);
        /// <summary>
        /// 根据ID获取权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TRight GetRight(int id);
    }
}
