
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OhPrimitives.Extension;

namespace OhPrimitives
{
    /// <summary>
    /// 一个表示包含指定数据项比较功能的字段类
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class ContainsField<TPrimitive> : SortField, IMutilpleValueCompareField<TPrimitive>
        where TPrimitive : IConvertible, IComparable
    {
        private TPrimitive[] m_values;
        private CompareMode m_compareMode = CompareMode.Default;

        private static readonly CompareMode _allowCompareModes = CompareMode.Contains | CompareMode.NotContains;

        /// <summary>
        /// 实例化 <see cref="ContainsField{TPrimitive}"/>
        /// </summary>
        public ContainsField()
            : this(new List<TPrimitive>())
        { }

        /// <summary>
        /// 指定 <paramref name="values"/> 实例化 <see cref="ContainsField{TPrimitive}"/>
        /// </summary>
        /// <param name="values"></param>
        public ContainsField(IEnumerable<TPrimitive> values)
        {
            m_values = values.ToArray();
        }

        /// <summary>
        /// 获取或者设置比较的值数组
        /// </summary>
        public TPrimitive[] Values
        {
            get => m_values;
            set => m_values = value;
        }

        /// <summary>
        /// 获取或者设置比较模式，有效比较模式 <see cref="CompareMode.Contains"/> / <see cref="CompareMode.NotContains"/> 
        /// </summary>
        public CompareMode CompareMode
        {
            get => m_compareMode;
            set
            {
                if (!_allowCompareModes.IsInclude(value))
                {
                    throw new ArgumentException($"invalid value.it's value should be {_allowCompareModes.ToString()}");
                }
                m_compareMode = value;
            }
        }
    }
}
