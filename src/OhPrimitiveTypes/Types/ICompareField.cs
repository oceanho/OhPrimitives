using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitiveTypes
{
    /// <summary>
    /// 定义一个表示拥有比较能力的顶级接口
    /// </summary>
    public interface ICompareField : IField
    {
        /// <summary>
        /// 获取或者设置比较模式
        /// </summary>
        CompareMode CompareMode { get; set; }
    }
}
