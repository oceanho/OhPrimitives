using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 过滤器开关枚举，用于控制字段的过滤有效性
    /// </summary>
    public enum FilterSwitch : byte
    {
        /// <summary>
        /// 开启过滤器（默认值）
        /// </summary>
        Open = 1,

        /// <summary>
        /// 关闭过滤器
        /// </summary>
        Close = 2
    }
}
