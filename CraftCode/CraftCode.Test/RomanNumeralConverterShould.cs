using NUnit.Framework;

namespace CraftCode.Test
{
    public class RomanNumeralConverterShould
    {
        private RomanNumeralConverter romanNumberalConverter;

        [SetUp]
        public void Initialize()
        {
            romanNumberalConverter = new RomanNumeralConverter();
        }

        [TestCase(-1, null)]
        public void Return_Null_When_Converting_Numbers_Smaller_Than_1(int arrabicNumber, string romanNumber)
        {
            Assert.AreEqual(romanNumber, romanNumberalConverter.Convert(arrabicNumber));
        }

        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        public void Convert_Simple_Numbers_To_Roman_Letter(int arrabicNumber, string romanNumber)
        {
            Assert.AreEqual(romanNumber, romanNumberalConverter.Convert(arrabicNumber));
        }

        [TestCase(2, "II")]
        [TestCase(453, "CDLIII")]
        [TestCase(3949, "MMMCMXLIX")]
        [TestCase(9999, "MMMMMMMMMCMXCIX")]
        public void Convert_Complex_Numbers_To_Roman_Letters(int arrabicNumber, string romanNumber)
        {
            Assert.AreEqual(romanNumber, romanNumberalConverter.Convert(arrabicNumber));
        }
    }
}
