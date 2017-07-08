using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{    
    /// <summary>
    /// Internal class You should be not use it's
    /// </summary>
    public class _SortField : Field, IHasSortField, IField, IEqualityComparer<_SortField>
    {
        private int m_SortPriority;
        private SortMode m_SortMode;

        /// <summary>
        /// 实例化 <see cref="_SortField"/>
        /// </summary>
        public _SortField()
            : this(SortMode.Disable)
        {            
        }

        /// <summary>
        /// 实例化 <see cref="_SortField"/>
        /// </summary>
        public _SortField(SortMode sortMode)
            : this(sortMode, 0)
        {
        }

        /// <summary>
        /// 实例化 <see cref="_SortField"/>
        /// </summary>
        public _SortField(int priority)
            : this(SortMode.Asc, priority)
        {
        }


        /// <summary>
        /// 实例化 <see cref="_SortField"/>
        /// </summary>
        /// <param name="priority">权重</param>
        /// <param name="sortMode">排序模式</param>
        public _SortField(SortMode sortMode, int priority)
        {
            SortMode = sortMode;
            SortPriority = priority;
        }

        /// <summary>
        /// 获取或者设置字段排序模式
        /// </summary>
        public SortMode SortMode
        {
            get => m_SortMode;
            set => m_SortMode = value;
        }

        /// <summary>
        /// 获取或者设置字段排序权重（该值越大，排序越往后）
        /// </summary>
        public int SortPriority
        {
            get => m_SortPriority;
            set => m_SortPriority = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >=(_SortField left, _SortField right)
        {
            if (left != null && right == null)
            {
                return true;
            }

            if (left == null && right != null)
            {
                return false;
            }
            if (left.SortMode == SortMode.Disable && left.SortMode != right.SortMode)
            {
                return false;
            }
            if (right.SortMode == SortMode.Disable && left.SortMode != right.SortMode)
            {
                return true;
            }
            return (left.SortMode <= right.SortMode) || (left.SortPriority >= right.SortPriority);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <=(_SortField left, _SortField right)
        {
            return !(left >= right);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator >(_SortField left, _SortField right)
        {
            if (left != null && right == null)
            {
                return true;
            }

            if (left == null && right != null)
            {
                return false;
            }
            if (left.SortMode == SortMode.Disable && left.SortMode != right.SortMode)
            {
                return false;
            }
            if (right.SortMode == SortMode.Disable && left.SortMode != right.SortMode)
            {
                return true;
            }
            return (left.SortMode < right.SortMode) || (left.SortPriority > right.SortPriority);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator <(_SortField left, _SortField right)
        {
            return !(left > right);
        }

        /// <summary>
        /// 实现 <see cref="IComparable"/> 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            var other = obj as _SortField;
            if (other == null)
                throw new ArgumentException($"Type not match, {obj?.GetType()} can't convert as {typeof(_SortField)}");
            if (this < other)
                return -1;
            if (this == other)
                return 0;
            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool Equals(_SortField x, _SortField y)
        {
            return x.SortMode == y.SortMode && x.SortPriority == y.SortPriority;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public virtual int GetHashCode(_SortField obj)
        {
            return $"{obj.GetType().FullName}_{obj.SortMode}_{obj.SortPriority}".GetHashCode();
        }
    }
}
