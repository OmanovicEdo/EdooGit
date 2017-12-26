using NUnit.Framework;

namespace AdventDay1InverseCaptcha
{
    [TestFixture]
    public class InverseCaotchaTests
    {
        InverseCaptcha ic;

        [SetUp]
        public void Init()
        {
            ic = new InverseCaptcha();
        }

        [Test]
        public void Given_NullOrEmpty_ReturnsZero()
        {
            var sum = ic.CalcCaptchaSum(null);
            Assert.AreEqual(0, sum);

            var sum2 = ic.CalcCaptchaSum("");
            Assert.AreEqual(0, sum2);
        }

        [Test]
        public void Given_LengthOneString_ExpectsZero()
        {
            var sum = ic.CalcCaptchaSum("3");
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Given_SameAdjacentNumbersPair_ReturnsThatRepeatingNumber()
        {
            var sum = ic.CalcCaptchaSum("112");
            Assert.AreEqual(1, sum);

            var sum2 = ic.CalcCaptchaSum("334");
            Assert.AreEqual(3, sum2);

            var sum3 = ic.CalcCaptchaSum("533");
            Assert.AreEqual(3, sum3);
        }

        [Test]
        public void Given_TwoPairsSameAdjacentNumbers_ReturnsSumOfTheirRepeatingNumbers()
        {
            //example from problem description
            var sum = ic.CalcCaptchaSum("1122");
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void Given_ManyairsSameAdjacentNumbers_ReturnsSumOfTheirRepeatingNumbers()
        {
            //example from problem description
            var sum = ic.CalcCaptchaSum("112244566");
            Assert.AreEqual(13, sum);
        }

        [Test]
        public void Given_FirstAndLastNumberSame_ExpextItsValueInSum()
        {
            var sum = ic.CalcCaptchaSum("1231");
            Assert.AreEqual(1, sum);

            //example from problem description
            var sum2 = ic.CalcCaptchaSum("1111");
            Assert.AreEqual(4, sum2);

            var sum3 = ic.CalcCaptchaSum("123341");
            Assert.AreEqual(4, sum2);

            //example from problem description
            var sum4 = ic.CalcCaptchaSum("91212129");
            Assert.AreEqual(9, sum4);
        }

        [Test]
        public void Given_AllDifferentNumber_ExpextZeroSum()
        {
            var sum = ic.CalcCaptchaSum("1234");
            Assert.AreEqual(0, sum);
        }        
    }
}
