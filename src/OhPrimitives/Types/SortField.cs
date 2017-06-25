using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 表示拥有排序功能的字段类，该类实现了 <see cref="IHasSortField"/> 接口
    /// </summary>
    public class SortField : Field, IHasSortField, IField
    {
        private int m_SortPriority;
        private SortMode m_SortMode;

        /// <summary>
        /// 实例化 <see cref="SortField"/>
        /// </summary>
        public SortField()
            : this(SortMode.Default)
        {
        }

        /// <summary>
        /// 实例化 <see cref="SortField"/>
        /// </summary>
        public SortField(SortMode sortMode)
            : this(0, sortMode)
        {
        }

        /// <summary>
        /// 实例化 <see cref="SortField"/>
        /// </summary>
        public SortField(int sortPriority)
            : this(sortPriority, SortMode.Asc)
        {
        }


        /// <summary>
        /// 实例化 <see cref="SortField"/>
        /// </summary>
        /// <param name="sortPriority">权重</param>
        /// <param name="sortMode">排序模式</param>
        public SortField(int sortPriority, SortMode sortMode)
        {
            SortMode = sortMode;
            SortPriority = sortPriority;
        }

        /// <summary>
        /// 获取或者设置字段排序模式
        /// </summary>
        public SortMode SortMode { get => m_SortMode; set => m_SortMode = value; }

        /// <summary>
        /// 获取或者设置字段排序权重（该值越大，排序越往后）
        /// </summary>
        public int SortPriority { get => m_SortPriority; set => m_SortPriority = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >=(SortField left, SortField right)
        {
            return (left.SortMode == SortMode.Default && right.SortMode != left.SortMode) ? false : (left.SortPriority >= right.SortPriority);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <=(SortField left, SortField right)
        {
            return !(left >= right);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >(SortField left, SortField right)
        {
            return (left.SortMode == SortMode.Default && right.SortMode != left.SortMode) ? false : (left.SortPriority > right.SortPriority);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <(SortField left, SortField right)
        {
            return !(left > right);
        }
    }
}
