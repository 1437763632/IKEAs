using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.IServices
{
    using IKEA.Model;
    /// <summary>
    /// 权限表接口
    /// </summary>
    public interface IRightServices
    {
        int Add(TRight right);
        
    }
}
