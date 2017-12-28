using AdventDay1InverseCaptcha;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class HalfwayDigitAlgTests
    {
        HalfwayDigitSelectionAlgorithm _alg;

        [SetUp]
        public void Init()
        {
            _alg = new HalfwayDigitSelectionAlgorithm();
        }

        [Test]
        public void HwayDigitSel_NullOrEmpty_Zero()
        {
            var sum = _alg.CalcCaptchaSum(null);
            Assert.AreEqual(0, sum);

            var sum2 = _alg.CalcCaptchaSum("");
            Assert.AreEqual(0, sum2);
        }

        [Test]
        public void HwayDigitSel_LengthOneString_Zero()
        {
            var sum = _alg.CalcCaptchaSum("3");
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void HwayDigitSel_FourHalfwayCounterpartsCircular_TheirSum()
        {                        
            int sum = _alg.CalcCaptchaSum("1212");
            Assert.AreEqual(sum, 6);
        }

        [Test]
        public void HwayDigitSel_NoHalfwayCounterparts_Zero()
        {            
            int sum = _alg.CalcCaptchaSum("1221");
            Assert.AreEqual(sum, 0);
        }

        [Test]
        public void HwayDigitSel_OtherExampleInputs_ExampleOutputs()
        {
            int sum = _alg.CalcCaptchaSum("123425");
            Assert.AreEqual(sum, 4);

            int sum2 = _alg.CalcCaptchaSum("123123");
            Assert.AreEqual(sum2, 12);

            int sum3 = _alg.CalcCaptchaSum("12131415");
            Assert.AreEqual(sum, 4);
        }        
    }
}
