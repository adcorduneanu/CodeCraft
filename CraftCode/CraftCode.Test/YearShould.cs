using NUnit.Framework;

namespace CraftCode.Test
{
    class YearShould
    {
        [Test]
        public void Be_Leap_Year_If_Is_Divisible_By_400()
        {
            Assert.IsTrue(new Year(1600).IsLeap());
        }
        
        [Test]
        public void Not_Be_Leap_Is_Divisible_By_100_But_Not_By_400()
        {
            Assert.IsFalse(new Year(1700).IsLeap());
        }

        [Test]
        public void Be_Leap_Year_If_Is_Divisible_By_4()
        {
            Assert.IsTrue(new Year(1604).IsLeap());
        }
    }
}
