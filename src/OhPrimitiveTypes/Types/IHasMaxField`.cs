using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 定义一个表示值拥最小值比较能力的接口
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public interface IHasMaxField<TPrimitive> : IField
        where TPrimitive : struct, IConvertible, IComparable
    {
        /// <summary>
        /// 获取或者设置最大值
        /// </summary>
        TPrimitive? Max { get; set; }

        /// <summary>
        /// 获取或者设置最大值比较模式
        /// </summary>
        CompareMode MaxCompareMode { get; }
    }
}
