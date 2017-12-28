using NUnit.Framework;

namespace AdventDay1InverseCaptcha
{
    [TestFixture]    
    public class InverseCaptchaTests
    {
        NextDigitSelectionAlgorithm alg;

        [SetUp]
        public void Init()
        {            
            alg = new NextDigitSelectionAlgorithm();            
        }

        [Test]
        public void NextDigitAlg_NullOrEmpty_Zero()
        {
            var sum = alg.CalcCaptchaSum(null);
            Assert.AreEqual(0, sum);

            var sum2 = alg.CalcCaptchaSum("");
            Assert.AreEqual(0, sum2);
        }

        [Test]
        public void NextDigitAlg_LengthOneString_Zero()
        {
            var sum = alg.CalcCaptchaSum("3");
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void NextDigitAlg_SameAdjacentNumbersPair_ThatRepeatingNumber()
        {
            var sum = alg.CalcCaptchaSum("112");
            Assert.AreEqual(1, sum);

            var sum2 = alg.CalcCaptchaSum("334");
            Assert.AreEqual(3, sum2);

            var sum3 = alg.CalcCaptchaSum("533");
            Assert.AreEqual(3, sum3);
        }

        [Test]
        public void NextDigitAlg_TwoPairsSameAdjacentNumbers_SumOfTheirRepeatingNumbers()
        {
            //example from problem description
            var sum = alg.CalcCaptchaSum("1122");
            Assert.AreEqual(3, sum);
        }

        [Test]
        public void NextDigitAlg_ManyPairsSameAdjacentNumbers_SumOfTheirRepeatingNumbers()
        {
            //example from problem description
            var sum = alg.CalcCaptchaSum("112244566");
            Assert.AreEqual(13, sum);
        }

        [Test]
        public void NextDigitAlg_FirstAndLastNumberSame_ItsValueInSum()
        {
            var sum = alg.CalcCaptchaSum("1231");
            Assert.AreEqual(1, sum);

            //example from problem description
            var sum2 = alg.CalcCaptchaSum("1111");
            Assert.AreEqual(4, sum2);

            var sum3 = alg.CalcCaptchaSum("123341");
            Assert.AreEqual(4, sum2);

            //example from problem description
            var sum4 = alg.CalcCaptchaSum("91212129");
            Assert.AreEqual(9, sum4);
        }

        [Test]
        public void NextDigitAlg_AllDifferentNumber_ZeroSum()
        {
            var sum = alg.CalcCaptchaSum("1234");
            Assert.AreEqual(0, sum);
        }        
    }
}
