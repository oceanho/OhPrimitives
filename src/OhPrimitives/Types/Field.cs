using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 字段基类
    /// </summary>
    public abstract class Field : IField
    {
        private FilterSwitch m_FilterSwitch;

        /// <summary>
        /// 实例化 <see cref="Field"/>
        /// </summary>
        public Field()
        {
            m_FilterSwitch = FilterSwitch.Open;
        }

        /// <summary>
        /// 过滤器开关
        /// </summary>
        public FilterSwitch FilterSwitch
        {
            get => m_FilterSwitch;
            set => m_FilterSwitch = value;
        }
    }
}
