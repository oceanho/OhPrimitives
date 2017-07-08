using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

using OhPrimitives;
using System.Linq;

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
            var myfield = new SortField<int>();
            myfield.SortPriority.ShouldBe(0);
            myfield.SortMode.ShouldBe(SortMode.Disable);

            var myfield2 = new SortField<int>(1);
            myfield2.SortPriority.ShouldBe(1);
            myfield2.SortMode.ShouldBe(SortMode.Asc);

            var myfield3 = new SortField<int>(SortMode.Desc);
            myfield3.SortPriority.ShouldBe(0);
            myfield3.SortMode.ShouldBe(SortMode.Desc);

            var myfield4 = new SortField<int>(SortMode.Desc, 2);
            myfield4.SortPriority.ShouldBe(2);
            myfield4.SortMode.ShouldBe(SortMode.Desc);

            var myfield5 = new SortField<int>(SortMode.Asc, 2);
            var myfield6 = new SortField<int>(SortMode.Desc, 2);

            (myfield < myfield2).ShouldBe(true);
            (myfield < myfield3).ShouldBe(true);
            (myfield2 > myfield3).ShouldBe(true);
            (myfield < myfield4).ShouldBe(true);

            (myfield2 > myfield3).ShouldBe(true);
            (myfield3 < myfield4).ShouldBe(true);

            (myfield2 < myfield4).ShouldBe(false);
            (myfield5 > myfield6).ShouldBe(true);
        }
        #endregion

        #region Verify_SortOperatorShouldBeWork

        [Fact]
        public void Verify_SortOperatorShouldBeWork()
        {
            var sort = new MySortTest()
            {
                Id = new SortField<int>(SortMode.Asc, 1),
                Name = new SortField<string>(SortMode.Disable)
            };

            // Id最小，Name 最大
            var sort2 = new MySortTest()
            {
                Id = new SortField<int>(SortMode.Desc, 1),
                Name = new SortField<string>(SortMode.Asc, 2)
            };

            var sort3 = new MySortTest()
            {
                Id = new SortField<int>(SortMode.Asc, 2),
                Name = new SortField<string>(SortMode.Disable)
            };

            var list = new List<MySortTest>() {
                sort,
                sort2,
                sort3
            };

            var orderbyIdList = list.OrderBy(p => p.Id);
            orderbyIdList.LastOrDefault().ShouldBe(sort3); // Id 排序最大
            orderbyIdList.FirstOrDefault().ShouldBe(sort2);// Id 排序最小


            var orderbyNameList = list.OrderBy(p => p.Name);
            orderbyIdList.FirstOrDefault().ShouldBe(sort2); // Name 排序最大

            var orderbyNameDescendingList = list.OrderByDescending(p => p.Name);
        }
        #endregion
    }

    internal class MySortTest
    {
        public SortField<int> Id { get; set; }
        public SortField<String> Name { get; set; }
    }
}
