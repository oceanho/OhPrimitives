using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OhPrimitiveTypes.Extension;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 一个表示包含指定 <see cref="TPrimitive"/> 单值Like模糊比较功能的字段类
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class LikeField<TPrimitive> : Field, ISingleValueCompareField<TPrimitive>
        where TPrimitive : class, IConvertible, IComparable
    {
        private TPrimitive m_value;
        private CompareMode m_compareMode = CompareMode.FullSearchLike;

        private readonly static TPrimitive defaultPrimitive = default(TPrimitive);
        private static readonly CompareMode _allowCompareModes = CompareMode.LeftLike | CompareMode.RightLike | CompareMode.FullSearchLike;

        /// <summary>
        /// 实例化 <see cref="LikeField{TPrimitive}"/>
        /// </summary>
        public LikeField()
            : this(defaultPrimitive)
        {
        }


        /// <summary>
        ///  实例化 <see cref="LikeField{TPrimitive}"/>
        /// </summary>
        /// <param name="value">Value</param>
        public LikeField(TPrimitive value)
            : this(value, CompareMode.FullSearchLike)
        {
        }

        /// <summary>
        /// 实例化 <see cref="LikeField{TPrimitive}"/>
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="compareMode">Mode</param>
        public LikeField(TPrimitive value, CompareMode compareMode)
        {
            Value = value;
            CompareMode = compareMode;
        }

        /// <summary>
        /// 获取或者设置比较模式（有效比较比较模式为：<seealso cref="{CompareMode.LeftLike , CompareMode.RightLike , CompareMode.FullSearchLike}"/>）
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

        /// <summary>
        /// 获取或者设置进行比较的 <see cref="TPrimitive"/> Value
        /// </summary>
        public TPrimitive Value
        {
            get => m_value;
            set => m_value = value;
        }
    }
}
