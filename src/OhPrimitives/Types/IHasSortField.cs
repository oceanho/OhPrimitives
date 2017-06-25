using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives
{
    /// <summary>
    /// 定义一个表示拥有排序功能的字段接口
    /// </summary>
    public interface IHasSortField : IField
    {
        /// <summary>
        /// 获取或者设置字段排序模式
        /// </summary>
        SortMode SortMode { get; set; }

        /// <summary>
        /// 获取或者设置字段排序权重（该值越大，排序越往后）
        /// </summary>
        int SortPriority { get; set; }
    }
}
