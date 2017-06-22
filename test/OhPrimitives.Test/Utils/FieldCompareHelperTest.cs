using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Shouldly;

using OhPrimitives;
using OhPrimitives.Utils;

namespace OhPrimitives.Test
{

    public class FieldCompareHelperTest
    {
        #region Verify_RangedField.IsStatisfy<int>_ShouldBeWork

        [Fact]
        public void Verify_RangedFieldIntIsStatisfy_ShouldBeWork()
        {
            var myfile = new RangeField<int>(10, 100);
            FieldCompareHelper.IsStatisfy(myfile, 9, 99).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 9, 100).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 101).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, -99).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 10).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 100).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, 11, 50).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 11, 99).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 45).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 98).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 97).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 98, 99).ShouldBe(true);
        }
        #endregion

        #region Verify_RangedField.IsStatisfy<long>_ShouldBeWork

        [Fact]
        public void Verify_RangedFieldLongIsStatisfy_ShouldBeWork()
        {
            var myfile = new RangeField<long>(10, 100);
            FieldCompareHelper.IsStatisfy(myfile, 9, 99).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 9, 100).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 101).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, -99).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 10).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 100).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, 11, 50).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 11, 99).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 45).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 98).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 97).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 98, 99).ShouldBe(true);
        }
        #endregion

        #region Verify_RangedField.IsStatisfy<DateTime>_ShouldBeWork

        [Fact]
        public void Verify_RangedFieldDateTimeIsStatisfy_ShouldBeWork()
        {
            var dt1 = DateTime.Now;
            var dt2 = DateTime.Now.AddYears(1);

            var myfile = new RangeField<DateTime>(dt1, dt2);

            FieldCompareHelper.IsStatisfy(myfile, dt1, dt2).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, dt1.AddDays(-1), dt2.AddDays(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddHours(-1), dt2.AddHours(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddMinutes(-1), dt2.AddMinutes(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddMinutes(-1), dt1.AddMinutes(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddSeconds(-1), dt2.AddSeconds(-1)).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, dt1.AddDays(1), dt2.AddSeconds(-1)).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddHours(1), dt2.AddHours(-1)).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddMinutes(1), dt2.AddMinutes(-1)).ShouldBe(true);
        }
        #endregion

        #region Verify_BetweenField.IsStatisfy<Int>_ShouldBeWork

        [Fact]
        public void Verify_BetweenFieldIntIsStatisfy_ShouldBeWork()
        {
            var myfile = new BetweenField<int>(10, 100);
            FieldCompareHelper.IsStatisfy(myfile, 9, 99).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 9, 100).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 101).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, -99).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, 10, 100).ShouldBe(true);

            FieldCompareHelper.IsStatisfy(myfile, 10, 50).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 11, 99).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 45).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 98).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 97).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 98, 99).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 10, 100).ShouldBe(true);
        }
        #endregion

        #region Verify_BetweenField.IsStatisfy<long>_ShouldBeWork

        [Fact]
        public void Verify_BetweenFieldLongIsStatisfy_ShouldBeWork()
        {
            var myfile = new BetweenField<long>(10, 100);
            FieldCompareHelper.IsStatisfy(myfile, 9, 99).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 9, 100).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, 101).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, 10, -99).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, 10, 100).ShouldBe(true);

            FieldCompareHelper.IsStatisfy(myfile, 10, 50).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 11, 99).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 45).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 98).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 12, 97).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 98, 99).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, 10, 100).ShouldBe(true);
        }
        #endregion

        #region Verify_BetweenField.IsStatisfy<DateTime>_ShouldBeWork

        [Fact]
        public void Verify_BetweenFieldDateTimeIsStatisfy_ShouldBeWork()
        {
            var dt1 = DateTime.Now;
            var dt2 = DateTime.Now.AddYears(1);

            var myfile = new BetweenField<DateTime>(dt1, dt2);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddDays(-1), dt2.AddDays(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddHours(-1), dt2.AddHours(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddMinutes(-1), dt2.AddMinutes(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddMinutes(-1), dt1.AddMinutes(-1)).ShouldBe(false);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddSeconds(-1), dt2.AddSeconds(-1)).ShouldBe(false);

            FieldCompareHelper.IsStatisfy(myfile, dt1.AddDays(1), dt2.AddSeconds(-1)).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddHours(1), dt2.AddHours(-1)).ShouldBe(true);
            FieldCompareHelper.IsStatisfy(myfile, dt1.AddMinutes(1), dt2.AddMinutes(-1)).ShouldBe(true);

            FieldCompareHelper.IsStatisfy(myfile, dt1, dt2).ShouldBe(true);
        }
        #endregion
    }
}
