using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 字段有效比较模式常量类
    /// </summary>
    public static class CompareModes
    {
        #region RangeField{TPrimitive}
        /// <summary>
        /// <see cref="RangeField{TPrimitive}"/> 最大值有效比较模式
        /// </summary>
        public const CompareMode RangeFieldMaxValidModes = CompareMode.LessThan;

        /// <summary>
        /// <see cref="RangeField{TPrimitive}"/> 最小值有效比较模式
        /// </summary>
        public const CompareMode RangeFieldMinValidModes = CompareMode.GreaterThan;
        #endregion

        #region BetweenField{TPrimitive}
        /// <summary>
        /// <see cref="BetweenField{TPrimitive}"/> 最大值有效比较模式
        /// </summary>
        public const CompareMode BetweenFieldMaxValidModes = CompareMode.LessThanOrEqaual;

        /// <summary>
        /// <see cref="BetweenField{TPrimitive}"/> 最小值有效比较模式
        /// </summary>
        public const CompareMode BetweenFieldMinValidModes = CompareMode.GreaterThanOrEqual;
        #endregion

        #region FreeDomRangeField{TPrimitive}
        /// <summary>
        /// <see cref="FreeDomRangeField{TPrimitive}"/> 最大值有效比较模式
        /// </summary>
        public const CompareMode FreeDomRangeFieldMaxValidModes = CompareMode.LessThan | CompareMode.LessThanOrEqaual;

        /// <summary>
        /// <see cref="FreeDomRangeField{TPrimitive}"/> 最小值有效比较模式
        /// </summary>
        public const CompareMode FreeDomRangeFieldMinValidModes = CompareMode.GreaterThan | CompareMode.GreaterThanOrEqual;
        #endregion

        #region EqualsField{TPrimitive}/ContainsField{TPrimitive}/LikeField{TPrimitive}/CompareField{TPrimitive}

        /// <summary>
        /// <see cref="EqualsField{TPrimitive}"/> 有效比较模式
        /// </summary>
        public const CompareMode EqualsFieldValidModes = CompareMode.Equal;

        /// <summary>
        /// <see cref="ContainsField{TPrimitive}"/> 有效比较模式
        /// </summary>
        public const CompareMode ContainsFieldValidModes = CompareMode.Contains | CompareMode.NotContains;

        /// <summary>
        /// <see cref="LikeField{TPrimitive}"/> 有效比较模式
        /// </summary>
        public const CompareMode LikeFieldValidModes = CompareMode.LeftLike | CompareMode.RightLike | CompareMode.FullSearchLike;

        /// <summary>
        /// <see cref="CompareField{TPrimitive}"/> 有效比较模式
        /// </summary>
        public const CompareMode CompareFieldValidModes = CompareMode.Equal | CompareMode.NotEqual | CompareMode.LessThan | CompareMode.LessThanOrEqaual | CompareMode.GreaterThan | CompareMode.GreaterThanOrEqual;
        #endregion
    }
}
