using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEA.Model
{
    /// <summary>
    /// 节点表
    /// </summary>
    public class Node
    {
        /// <summary>
        /// id 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// 节点描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 节点负责角色
        /// </summary>
        public int NodeRole { get; set; }
    }
}
