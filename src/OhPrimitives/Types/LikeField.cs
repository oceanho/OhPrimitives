using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OhPrimitives.Extension;

namespace OhPrimitives
{
    /// <summary>
    /// 一个表示包含指定单值Like模糊比较功能的字段类
    /// </summary>
    public class LikeField : SortField, ISingleValueCompareField<String>, IField<String>, ILikeField
    {
        private String m_value;
        private CompareMode m_compareMode = CompareMode.FullSearchLike;
        private readonly static String defaultPrimitive = default(String);

        /// <summary>
        /// 实例化 <see cref="LikeField"/>
        /// </summary>
        public LikeField()
            : this(defaultPrimitive)
        {
        }


        /// <summary>
        ///  实例化 <see cref="LikeField"/>
        /// </summary>
        /// <param name="value">Value</param>
        public LikeField(String value)
            : this(value, CompareMode.FullSearchLike)
        {
        }

        /// <summary>
        /// 实例化 <see cref="LikeField"/>
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="compareMode">Mode</param>
        public LikeField(String value, CompareMode compareMode)
        {
            Value = value;
            CompareMode = compareMode;
        }

        /// <summary>
        /// 获取或者设置比较模式（有效比较比较模式为：<see cref="CompareModes.LikeFieldValidModes"/>）
        /// </summary>
        public CompareMode CompareMode
        {
            get => m_compareMode;
            set
            {
                if (!CompareModes.LikeFieldValidModes.IsInclude(value))
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareModes.LikeFieldValidModes.ToString()}");
                }
                m_compareMode = value;
            }
        }

        /// <summary>
        /// 获取或者设置进行比较的 Value
        /// </summary>
        public String Value
        {
            get => m_value;
            set => m_value = value;
        }
    }
}
