using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 定义一个表示拥有单值相等比较操作的字段
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class EqualsField<TPrimitive> : CompareField<TPrimitive>, IField<TPrimitive>, ICompareField
        where TPrimitive : IConvertible, IComparable
    {
        /// <summary>
        /// 实例化 <see cref="EqualsField{TPrimitive}"/>
        /// </summary>
        public EqualsField()
            : this(default(TPrimitive))
        {
        }

        /// <summary>
        /// 实例化 <see cref="EqualsField{TPrimitive}"/>
        /// </summary>
        /// <param name="value">Value</param>
        public EqualsField(TPrimitive value)
            : base(value, CompareMode.Equal)
        {
        }

        /// <summary>
        /// 获取或者设置比较模式（有效比较比较模式为：<see cref="CompareModes.EqualsFieldValidModes"/>）
        /// </summary>
        public override CompareMode CompareMode
        {
            get => base.CompareMode;
            set
            {
                if (value != CompareModes.EqualsFieldValidModes)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareModes.EqualsFieldValidModes.ToString()}");
                }
                base.CompareMode = value;
            }
        }
    }
}
