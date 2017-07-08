using System;
using System.Collections.Generic;
using System.Text;

using OhPrimitives.Extension;

namespace OhPrimitives
{
    /// <summary>
    /// 一个表示支持单值比较功能的字段类
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class CompareField<TPrimitive> : SortField<TPrimitive>, ISingleValueCompareField<TPrimitive>, IField<TPrimitive>, ICompareField
        where TPrimitive : IConvertible, IComparable
    {
        private TPrimitive m_value;
        private CompareMode m_compareMode = CompareMode.Default;

        /// <summary>
        /// 实例化 <see cref="CompareField{TPrimitive}"/>
        /// </summary>
        public CompareField()
            : this(default(TPrimitive))
        {
        }

        /// <summary>
        /// 实例化 <see cref="CompareField{TPrimitive}"/>
        /// </summary>
        /// <param name="value">Value</param>
        public CompareField(TPrimitive value)
            : this(value, CompareMode.Default)
        {
        }

        /// <summary>
        /// 实例化 <see cref="CompareField{TPrimitive}"/>
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="compareMode">Mode</param>
        public CompareField(TPrimitive value, CompareMode compareMode)
        {
            Value = value;
            CompareMode = compareMode;
        }

        /// <summary>
        /// 获取或者设置 Value
        /// </summary>
        public virtual TPrimitive Value
        {
            get => m_value;
            set => m_value = value;
        }

        /// <summary>
        /// 获取或者设置比较模式（有效比较比较模式为：<see cref="CompareModes.CompareFieldValidModes"/>）
        /// </summary>
        public virtual CompareMode CompareMode
        {
            get => m_compareMode;
            set
            {
                if (!CompareModes.CompareFieldValidModes.IsInclude(value))
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareModes.CompareFieldValidModes.ToString()}");
                }
                m_compareMode = value;
            }
        }
    }
}
