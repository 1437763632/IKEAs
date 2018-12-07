using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 评价服务接口
    /// </summary>
    public interface IEvaluateServices
    {
        /// <summary>
        /// 添加评价
        /// </summary>
        /// <param name="evaluate"></param>
        /// <returns></returns>
        int Add(Tevaluate evaluate);
        /// <summary>
        /// 获取单个评价
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Tevaluate GetEvaluate(int id);
        /// <summary>
        /// 获取评价
        /// </summary>
        /// <param name="ProductID">产品ID</param>
        /// <returns></returns>
        IEnumerable<Tevaluate> GetTevaluates(int ProductID);
        /// <summary>
        /// 修改评价
        /// </summary>
        /// <param name="evaluate">评价实体</param>
        /// <returns></returns>
        int Update(Tevaluate evaluate);
        /// <summary>
        /// 删除评价
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        int Delete(int id);
    }
}
