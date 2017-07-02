using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 字段比较模式
    /// </summary>
    [Flags]
    public enum CompareMode : int
    {
        /// <summary>
        /// 默认比较模式
        /// </summary>
        Default = Equal,

        /// <summary>
        /// 比较模式为：等于
        /// </summary>
        Equal = 2,

        /// <summary>
        /// 比较模式为：不等于
        /// </summary>
        NotEqual = 4,

        /// <summary>
        /// 比较模式为：小于
        /// </summary>
        LessThan = 8,

        /// <summary>
        /// 比较模式为：大于
        /// </summary>
        GreaterThan = 16,

        /// <summary>
        /// 比较模式为：小于或等于
        /// </summary>
        LessThanOrEqual = 32,

        /// <summary>
        /// 比较模式为：大于或者等于
        /// </summary>
        GreaterThanOrEqual = 64,

        /// <summary>
        /// 比较模式为：包含任意元素
        /// </summary>
        Contains = 128,

        /// <summary>
        /// 比较模式为：不包含任意元素
        /// </summary>
        NotContains = 256,

        /// <summary>
        /// 比较模式为：左边模糊相似（SQL表示为：XXX like 关键字% ）
        /// </summary>
        LeftLike = 512,

        /// <summary>
        /// 比较模式为：右边模糊相似（SQL表示为：XXX like %关键字 ）
        /// </summary>
        RightLike = 1024,

        /// <summary>
        /// 比较模式为：全模糊相似（SQL表示为：XXX like %关键字% ）
        /// </summary>
        FullSearchLike = 2048,
    }
}
