using System;
using System.Collections.Generic;
using System.Text;

namespace OhPrimitives.Extension
{
    internal static class CompareModeExtension
    {
        public static bool IsInclude(this CompareMode modes, CompareMode mode)
        {
            // 位与运算，计算出来的结果，如果不等于 mode，则表示mode不包含于modes中
            return (modes & mode) == mode;
        }
    }
}
