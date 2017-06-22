using System;

namespace OhPrimitives
{
    /// <summary>
    /// 一个表示最小，最大（包含最小值和最大值）的区间段比较字段类
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class BetweenField<TPrimitive> : FreeDomRangeField<TPrimitive>
        where TPrimitive : struct, IConvertible, IComparable
    {
        private CompareMode m_maxCompareMode = CompareMode.LessThanOrEqaual;
        private CompareMode m_minCompareMode = CompareMode.GreaterThanOrEqual;

        /// <summary>
        /// 实例化 <see cref="BetweenField{TPrimitive}"/>
        /// </summary>
        public BetweenField()
            : this(DefaultTPrimitive, DefaultTPrimitive)
        {
        }

        /// <summary>
        /// 实例化 <see cref="BetweenField{TPrimitive}"/>
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        public BetweenField(TPrimitive? min, TPrimitive? max)
            : base(min, max, CompareMode.GreaterThanOrEqual, CompareMode.LessThanOrEqaual)
        {
        }

        /// <summary>
        /// 获取或者设置最小值比较模式（有效比较比较模式为：CompareMode.GreaterThanOrEqual）
        /// </summary>
        public override CompareMode MinCompareMode
        {
            get => m_minCompareMode;
            set
            {
                if (value != CompareMode.GreaterThanOrEqual)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareMode.GreaterThanOrEqual.ToString()}");
                }
                m_minCompareMode = value;
            }
        }

        /// <summary>
        /// 获取或者设置最大值比较模式（有效比较比较模式为：CompareMode.LessThanOrEqaual）
        /// </summary>
        public override CompareMode MaxCompareMode
        {
            get => m_maxCompareMode;
            set
            {
                if (value != CompareMode.LessThanOrEqaual)
                {
                    throw new ArgumentException($"invalid value.it's value should be {CompareMode.LessThanOrEqaual.ToString()}");
                }
                m_maxCompareMode = value;
            }
        }
    }
}
