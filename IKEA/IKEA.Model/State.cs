using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    public enum State
    {
        /// <summary>
        /// 未审核
        /// </summary>
        Unchecked=1,
        /// <summary>
        /// 搁置
        /// </summary>
        Shelve=2,
        /// <summary>
        /// 驳回
        /// </summary>
        Reject=3,
        /// <summary>
        /// 通过
        /// </summary>
        Pass=4,
        /// <summary>
        /// 提交
        /// </summary>
        Submit=5

    }
}
