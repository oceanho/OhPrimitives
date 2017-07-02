using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OhPrimitives.Extension;

namespace OhPrimitives.Utils
{
    /// <summary>
    /// 字段比较helper
    /// </summary>
    public static class FieldCompareHelper
    {
        #region EqualsField<TPrimitive>.IsStatisfy

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrimitive"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsStatisfy<TPrimitive>(EqualsField<TPrimitive> field, TPrimitive value)
            where TPrimitive : struct, IConvertible, IComparable
        {
            if (field.CompareMode == CompareMode.Equal)
            {
                return field.Value.CompareTo(value) == 0;
            }
            return false;
        }
        #endregion

        #region ContainsField<TPrimitive>.IsStatisfy

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrimitive"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsStatisfy<TPrimitive>(ContainsField<TPrimitive> field, TPrimitive value)
            where TPrimitive : struct, IConvertible, IComparable
        {
            var result = false;
            if (field.CompareMode.IsInclude(CompareMode.Contains))
            {
                result = field.Values.FirstOrDefault(p => p.CompareTo(value) == 0).CompareTo(value) == 0;
            }
            if (!result)
            {
                if (field.CompareMode.IsInclude(CompareMode.NotContains))
                {
                    result = field.Values.FirstOrDefault(p => p.CompareTo(value) == 0).CompareTo(value) != 0;
                }
            }
            return result;
        }
        #endregion

        #region RangeField<TPrimitive>.IsStatisfy

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrimitive"></typeparam>
        /// <param name="field"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool IsStatisfy<TPrimitive>(RangeField<TPrimitive> field, TPrimitive min, TPrimitive max)
            where TPrimitive : struct, IConvertible, IComparable
        {
            var _min = field.Min.GetValueOrDefault();
            var _max = field.Max.GetValueOrDefault();

            var left = false;
            var right = false;
            if (field.Min == null)
            {
                left = true;
            }
            else
            {
                if (field.MinCompareMode == CompareMode.GreaterThan)
                {
                    left = min.CompareTo(_min) > 0 && min.CompareTo(_max) < 0;
                }
            }
            if (field.Max == null)
            {
                right = true;
            }
            {
                if (field.MaxCompareMode == CompareMode.LessThan)
                {
                    right = max.CompareTo(_min) > 0 && max.CompareTo(_max) < 0;
                }
            }
            if (field.Min == null && field.Max == null)
            {
                return false;
            }
            return left && right;
        }
        #endregion

        #region BetweenField<TPrimitive>.IsStatisfy

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TPrimitive"></typeparam>
        /// <param name="field"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool IsStatisfy<TPrimitive>(BetweenField<TPrimitive> field, TPrimitive min, TPrimitive max)
            where TPrimitive : struct, IConvertible, IComparable
        {

            var _min = field.Min.GetValueOrDefault();
            var _max = field.Max.GetValueOrDefault();

            var left = false;
            var right = false;

            if (field.Min == null)
            {
                left = true;
            }
            else
            {
                if (field.MinCompareMode == CompareMode.GreaterThanOrEqual)
                {
                    left = min.CompareTo(_min) >= 0 && min.CompareTo(_max) <= 0;
                }
            }
            if (field.Max == null)
            {
                right = true;
            }
            {
                if (field.MaxCompareMode == CompareMode.LessThanOrEqaual)
                {
                    right = max.CompareTo(_min) >= 0 && max.CompareTo(_max) <= 0;
                }
            }
            if (field.Min == null &&field.Max == null)
            {
                return false;
            }
            return left && right;
        }
        #endregion
    }
}
