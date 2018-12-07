using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 日志管理
    /// </summary>
    public interface ILogServices
    {
        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="log"></param>
        /// <returns></returns>
        int Add(TLog log);
        /// <summary>
        /// 获取日志
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        IEnumerable<TLog> GetLogs(int id);
    }
}
