using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 定义一个表示拥有单值不相等比较操作的字段
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class NotEqualsField<TPrimitive> : CompareField<TPrimitive>
        where TPrimitive : IConvertible, IComparable
    {
        /// <summary>
        /// 实例化 <see cref="NotEqualsField{TPrimitive}"/>
        /// </summary>
        public NotEqualsField()
            : this(default(TPrimitive))
        {
        }

        /// <summary>
        /// 实例化 <see cref="NotEqualsField{TPrimitive}"/>
        /// </summary>
        /// <param name="value">Value</param>
        public NotEqualsField(TPrimitive value)
            : base(value, CompareMode.NotEqual)
        {
        }

        /// <summary>
        /// 获取或者设置比较模式（有效值：<see cref="CompareMode.NotEqual"/>）
        /// </summary>
        public override CompareMode CompareMode
        {
            get => base.CompareMode;
            set
            {
                if (value != CompareMode.NotEqual)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareMode.Equal.ToString()}");
                }
                base.CompareMode = value;
            }
        }
    }
}
