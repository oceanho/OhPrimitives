using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 定义一个表示值拥最小值/最大值比较能力的接口
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public interface IHasMinMaxField<TPrimitive> : IHasMinField<TPrimitive>, IHasMaxField<TPrimitive>
        where TPrimitive : struct, IConvertible, IComparable
    {
    }
}
