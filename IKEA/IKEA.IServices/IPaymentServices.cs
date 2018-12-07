using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 支付服务接口
    /// </summary>
    public interface IPaymentServices
    {
        /// <summary>
        /// 添加支付
        /// </summary>
        /// <param name="payment"></param>
        /// <returns>int</returns>
        int Add(IKEA.Model.TPayment payment);
        /// <summary>
        /// 修改支付信息
        /// </summary>
        /// <param name="payment"></param>
        /// <returns>int</returns>
        int Update(TPayment payment);
        /// <summary>
        /// 删除支付
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int id);
        /// <summary>
        /// 根据ID获取支付信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TPayment GetPayment(int id);
        /// <summary>
        /// 获取用户所有支付信息
        /// </summary>
        /// <param name="id">用户信息</param>
        /// <returns>IEnumerable<TPayment></returns>
        IEnumerable<TPayment> GetPayments(int id);
    }
}
