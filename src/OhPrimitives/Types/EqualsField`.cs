using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 定义一个表示拥有单值相等比较操作的字段
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class EqualsField<TPrimitive> : CompareField<TPrimitive>
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
        /// 获取或者设置比较模式（有效比较比较模式为：CompareMode.Equal）
        /// </summary>
        public override CompareMode CompareMode
        {
            get => base.CompareMode;
            set
            {
                if (value != CompareMode.Equal)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareMode.Equal.ToString()}");
                }
                base.CompareMode = value;
            }
        }
    }
}
