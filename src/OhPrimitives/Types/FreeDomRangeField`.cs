
using System;
using System.Collections.Generic;
using System.Text;

using OhPrimitives.Extension;

namespace OhPrimitives
{
    /// <summary>
    /// 一个表示最小，最大（自定义比较模式）的区间段比较字段类
    /// </summary>
    /// <typeparam name="TPrimitive"></typeparam>
    public class FreeDomRangeField<TPrimitive> : Field, IHasMinMaxField<TPrimitive>
        where TPrimitive : struct, IConvertible, IComparable
    {

        private TPrimitive? m_min;
        private TPrimitive? m_max;

        private CompareMode m_maxCompareMode = CompareMode.LessThanOrEqaual;
        private CompareMode m_minCompareMode = CompareMode.GreaterThanOrEqual;

        /// <summary>
        /// TPrimitive default
        /// </summary>
        protected static readonly TPrimitive DefaultTPrimitive = default(TPrimitive);

        private static readonly CompareMode _maxAllowCopareModes = CompareMode.LessThan | CompareMode.LessThanOrEqaual;
        private static readonly CompareMode _minAllowCopareModes = CompareMode.GreaterThan | CompareMode.GreaterThanOrEqual;

        /// <summary>
        /// 实例化 <see cref="FreeDomRangeField{TPrimitive}"/>
        /// </summary>
        public FreeDomRangeField()
            : this(DefaultTPrimitive, DefaultTPrimitive)
        { }

        /// <summary>
        /// 实例化 <see cref="FreeDomRangeField{TPrimitive}"/>
        /// </summary>
        /// <param name="min">Min value</param>
        /// <param name="max">Max value</param>
        public FreeDomRangeField(TPrimitive? min, TPrimitive? max)
            : this(min, max, CompareMode.GreaterThanOrEqual, CompareMode.LessThanOrEqaual)
        {
        }

        /// <summary>
        /// 实例化 <see cref="FreeDomRangeField{TPrimitive}"/>
        /// </summary>
        /// <param name="minCompareMode">最小值比较模式</param>
        /// <param name="maxCompareMode">最大值比较模式</param>
        public FreeDomRangeField(CompareMode minCompareMode, CompareMode maxCompareMode)
            : this(DefaultTPrimitive, DefaultTPrimitive, minCompareMode, maxCompareMode)
        {
        }

        /// <summary>
        /// 实例化 <see cref="FreeDomRangeField{TPrimitive}"/>
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <param name="minCompareMode">最小值比较模式</param>
        /// <param name="maxCompareMode">最大值比较模式</param>
        public FreeDomRangeField(TPrimitive? min, TPrimitive? max, CompareMode minCompareMode, CompareMode maxCompareMode)
        {
            m_min = min;
            m_max = max;
            MinCompareMode = minCompareMode;
            MaxCompareMode = maxCompareMode;
        }

        /// <summary>
        /// 获取或者设置最小值
        /// </summary>
        public virtual TPrimitive? Min
        {
            get => m_min;
            set => m_min = value;
        }

        /// <summary>
        /// 或轻或或者设置最大值
        /// </summary>
        public virtual TPrimitive? Max
        {
            get => m_max;
            set => m_max = value;
        }

        /// <summary>
        /// 获取或者设置最小值比较模式，（有效比较比较模式为：CompareMode.GreaterThan , CompareMode.GreaterThanOrEqual）
        /// </summary>
        public virtual CompareMode MinCompareMode
        {
            get => m_minCompareMode;
            set
            {
                if (!_minAllowCopareModes.IsInclude(value))
                {                    
                    throw new ArgumentException($"invalid value.it's value should be {_minAllowCopareModes.ToString()}");
                }
                m_minCompareMode = value;
            }
        }

        /// <summary>
        /// 获取或者设置最大值比较模式（有效比较比较模式为：ompareMode.LessThan , CompareMode.LessThanOrEqaual）
        /// </summary>
        public virtual CompareMode MaxCompareMode
        {
            get => m_maxCompareMode;
            set
            {
                if (!_maxAllowCopareModes.IsInclude(value))
                {
                    throw new ArgumentException($"invalid value.it's value should be {_maxAllowCopareModes.ToString()}");
                }
                m_maxCompareMode = value;
            }
        }
    }
}
