using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 定义一个表示值拥最小值比较能力的接口
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public interface IHasMinField<TPrimitive> : IField
        where TPrimitive : struct, IConvertible, IComparable
    {
        /// <summary>
        /// 获取或者设置最小值
        /// </summary>
        TPrimitive? Min { get; set; }

        /// <summary>
        /// 获取或者设置最小值比较模式
        /// </summary>
        CompareMode MinCompareMode { get; }
    }
}
