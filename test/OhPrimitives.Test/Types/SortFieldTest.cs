using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

using OhPrimitives;

namespace OhPrimitives.Test
{
    public class SortFieldTest
    {
        public SortFieldTest()
        {

        }

        #region Verify_BaseOperatorShouldBeWork

        [Fact]
        public void Verify_BaseOperatorShouldBeWork()
        {
            var myfield = new SortField();
            myfield.SortPriority.ShouldBe(0);
            myfield.SortMode.ShouldBe(SortMode.Default);


            var myfield2 = new SortField(1);
            myfield2.SortPriority.ShouldBe(1);
            myfield2.SortMode.ShouldBe(SortMode.Asc);
                        
            var myfield3 = new SortField(SortMode.Asc);
            myfield3.SortPriority.ShouldBe(0);
            myfield3.SortMode.ShouldBe(SortMode.Asc);

            var myfield4 = new SortField(2,SortMode.Desc);
            myfield4.SortPriority.ShouldBe(2);
            myfield4.SortMode.ShouldBe(SortMode.Desc);

            var myfield5 = new SortField(2, SortMode.Asc);
            var myfield6 = new SortField(2, SortMode.Desc);

            (myfield < myfield2).ShouldBe(true);
            (myfield < myfield3).ShouldBe(true);
            (myfield < myfield4).ShouldBe(true);

            (myfield2 > myfield3).ShouldBe(true);
            (myfield2 < myfield4).ShouldBe(true);
            (myfield3 < myfield4).ShouldBe(true);

            (myfield5 >= myfield6).ShouldBe(true);
        }
        #endregion
    }
}
