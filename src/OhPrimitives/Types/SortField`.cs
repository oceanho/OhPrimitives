using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 表示拥有排序功能的字段类，该类实现了 <see cref="IHasSortField"/> 接口
    /// </summary>
    public class SortField<TPrimivite> : _SortField, IHasSortField, IField
    {
        private int m_SortPriority;
        private SortMode m_SortMode;

        /// <summary>
        /// 实例化 <see cref="SortField{TPrimivite}"/>
        /// </summary>
        public SortField()
            : this(SortMode.Disable)
        {
        }

        /// <summary>
        /// 实例化 <see cref="SortField{TPrimivite}"/>
        /// </summary>
        public SortField(SortMode sortMode)
            : this(sortMode, 0)
        {
        }

        /// <summary>
        /// 实例化 <see cref="SortField{TPrimivite}"/>
        /// </summary>
        public SortField(int priority)
            : this(SortMode.Asc, priority)
        {
        }


        /// <summary>
        /// 实例化 <see cref="SortField{TPrimivite}"/>
        /// </summary>
        /// <param name="priority">权重</param>
        /// <param name="sortMode">排序模式</param>
        public SortField(SortMode sortMode, int priority)
            : base(sortMode, priority)
        {
        }
    }
}
