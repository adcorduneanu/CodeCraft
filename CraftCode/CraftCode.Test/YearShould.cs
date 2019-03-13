using NUnit.Framework;

namespace CraftCode.Test
{
    class YearShould
    {
        private Year year;

        [SetUp]
        public void Initialize()
        {
            year = new Year();
        }

        [TestCase(1600)]
        public void Be_Leap_Year_If_Is_Divisible_By_400(int year)
        {
            Assert.IsTrue(this.year.IsLeap(year));
        }

        [TestCase(1700)]
        public void Not_Be_Leap_Is_Divisible_By_100_But_Not_By_400(int year)
        {
            Assert.IsFalse(this.year.IsLeap(year));
        }

        [TestCase(1604)]
        public void Be_Leap_Year_If_Is_Divisible_By_4(int year)
        {
            Assert.IsTrue(this.year.IsLeap(year));
        }
    }
}
