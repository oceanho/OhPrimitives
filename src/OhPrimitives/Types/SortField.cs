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
            : this(sortMode, 0)
        {
        }

        /// <summary>
        /// 实例化 <see cref="SortField"/>
        /// </summary>
        public SortField(int priority)
            : this(SortMode.Asc, priority)
        {
        }


        /// <summary>
        /// 实例化 <see cref="SortField"/>
        /// </summary>
        /// <param name="priority">权重</param>
        /// <param name="sortMode">排序模式</param>
        public SortField(SortMode sortMode, int priority)
        {
            SortMode = sortMode;
            SortPriority = priority;
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
            if (left != null && right == null)
            {
                return true;
            }

            if (left == null && right != null)
            {
                return false;
            }
            if (left.SortPriority == right.SortPriority)
            {
                return left.SortMode >= right.SortMode;
            }
            return left.SortPriority >= right.SortPriority;
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
            if (left != null && right == null)
            {
                return true;
            }

            if (left == null && right != null)
            {
                return false;
            }
            if (left.SortPriority == right.SortPriority)
            {
                return left.SortMode > right.SortMode;
            }
            return left.SortPriority > right.SortPriority;
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

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="left"></param>
        ///// <param name="right"></param>
        ///// <returns></returns>
        //public static bool operator ==(SortField left, SortField right)
        //{            
        //    if (((right == null && left != null)) || ((right != null && left == null)))
        //        return false;
        //    return left.SortMode == right.SortMode && left.SortPriority == right.SortPriority;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="left"></param>
        ///// <param name="right"></param>
        ///// <returns></returns>
        //public static bool operator !=(SortField left, SortField right)
        //{
        //    return !(left == right);
        //}

        /// <summary>
        /// 实现 <see cref="IComparable"/> 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            var other = obj as SortField;
            if (other == null)
                throw new ArgumentException("Type not match");
            if (this < other)
                return -1;
            if (this == other)
                return 0;
            return 1;
        }

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override bool Equals(object obj)
        //{
        //    var other = (obj as SortField);
        //    return other == null ? false : this == other;
        //}
    }
}
