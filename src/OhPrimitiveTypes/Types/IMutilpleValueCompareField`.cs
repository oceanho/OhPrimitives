using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 定义一个表示拥有多值比较能力的接口
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public interface IMutilpleValueCompareField<TPrimitive> : ICompareField
        where TPrimitive : IConvertible, IComparable
    {
        /// <summary>
        /// 获取或者设置用于比较的 Values
        /// </summary>
        TPrimitive[] Values { get; set; }
    }
}
