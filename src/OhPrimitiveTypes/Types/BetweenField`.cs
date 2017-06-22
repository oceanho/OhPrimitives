﻿using System;

namespace OhPrimitiveTypes
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

        public BetweenField()
            : this(DefaultTPrimitive, DefaultTPrimitive)
        {
        }

        public BetweenField(TPrimitive? min, TPrimitive? max)
            : base(min, max, CompareMode.GreaterThanOrEqual, CompareMode.LessThanOrEqaual)
        {
        }

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
