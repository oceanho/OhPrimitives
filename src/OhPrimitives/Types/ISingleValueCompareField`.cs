using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 定义一个表示拥有单值比较能力的接口
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public interface ISingleValueCompareField<TPrimitive> : ICompareField
        where TPrimitive : IConvertible, IComparable
    {
        /// <summary>
        /// 获取或者设置用于比较的Value
        /// </summary>
        TPrimitive Value { get; set; }
    }
}
