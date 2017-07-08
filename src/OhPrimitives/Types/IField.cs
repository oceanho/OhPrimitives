using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 一个表示字段的接口
    /// </summary>
    public interface IField
    {
        /// <summary>
        /// 过滤器开关
        /// </summary>
        FilterSwitch FilterSwitch { get; set; }
    }
}
