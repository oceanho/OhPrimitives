using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

using OhPrimitiveTypes;

namespace OhPrimitiveTypes.Test.Fields
{
    public class HasMaxFieldTest
    {
        public HasMaxFieldTest()
        {
        }
    }

    public class MyHasMaxField<TPrimitive> : Field, IHasMaxField<TPrimitive>
        where TPrimitive : struct, IConvertible, IComparable
    {
        private TPrimitive? m_Max;
        private CompareMode m_Mode;
        public TPrimitive? Max
        {
            get => m_Max;
            set => m_Max = value;
        }
        public CompareMode MaxCompareMode
        {
            get => m_Mode;
            set => m_Mode = value;
        }
    }
}
