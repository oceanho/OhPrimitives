using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 字段排序模式
    /// </summary>
    [Flags]
    public enum SortMode : int
    {
        /// <summary>
        /// 默认排序模式：不排序
        /// </summary>
        Default = 0,

        /// <summary>
        /// 默认排序模式为：升序
        /// </summary>
        Asc = 1,

        /// <summary>
        /// 默认排序模式为：降序
        /// </summary>
        Desc = 2,
    }
}
