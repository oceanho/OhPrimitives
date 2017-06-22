using System;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 一个表示最小，最大（不包含最小值和最大值）的区间段比较字段类
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class RangeField<TPrimitive> : FreeDomRangeField<TPrimitive>
        where TPrimitive : struct, IConvertible, IComparable
    {
        private CompareMode m_maxCompareMode = CompareMode.LessThan;
        private CompareMode m_minCompareMode = CompareMode.GreaterThan;

        /// <summary>
        /// 实例化 <see cref=" RangeField{TPrimitive}"/>
        /// </summary>
        public RangeField()
            : this(DefaultTPrimitive, DefaultTPrimitive)
        {
        }

        /// <summary>
        /// 实例化 <see cref=" RangeField{TPrimitive}"/>
        /// </summary>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        public RangeField(TPrimitive? min, TPrimitive? max)
            : base(min, max, CompareMode.GreaterThan, CompareMode.LessThan)
        {
        }

        /// <summary>
        /// 获取或者设置最小值的比较模式（有效值：<see cref="CompareMode.GreaterThan"/>）
        /// </summary>
        public override CompareMode MinCompareMode
        {
            get => m_minCompareMode;
            set
            {
                if (value != CompareMode.GreaterThan)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareMode.GreaterThan.ToString()}");
                }
                m_minCompareMode = value;
            }
        }

        /// <summary>
        /// 获取或者设置最大值的比较模式（有效值：<see cref="CompareMode.LessThan"/>）
        /// </summary>
        public override CompareMode MaxCompareMode
        {
            get => m_maxCompareMode;
            set
            {
                if (value != CompareMode.LessThan)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareMode.LessThan.ToString()}");
                }
                m_maxCompareMode = value;
            }
        }
    }
}
