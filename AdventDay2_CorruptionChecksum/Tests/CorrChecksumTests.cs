using AdventDay2_CorruptionChecksum;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class CorruptionChecksumTests
    {
        ChecksumCalculator cc;
        
        [SetUp]
        public void Init()
        {            
            IRowCalculator calcSubstract = new RowSumSubstractionAlgorithm();
            cc = new ChecksumCalculator(calcSubstract);
        }

        [Test]
        public void CalcChecksum_EmptyInput_ThrowsArguementException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                cc.CalcChecksum("");
            });
        }

        [Test]
        public void CalcChecksum_NullInput_ThrowsArguementException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                cc.CalcChecksum(null);
            });
        }

        [Test]
        public void CalcChecksum_NonNumberInput_ThrowsArgementException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                cc.CalcChecksum("a23 32");
            });
        }

        [Test]
        public void CalcChecksum_CalcSumOneRow_ProperResult()
        {
            int sum = cc.CalcChecksum("5 1 9 5");
            Assert.AreEqual(8, sum);
        }

        [Test]
        public void CalcChecksum_ParseMultipleRows_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => { cc.CalcChecksum("5 1 9 5\n5 1 9 5"); });
            Assert.DoesNotThrow(() => { cc.CalcChecksum("5 1 9 5\n5 1 9 5\n45 6 7"); });
            Assert.DoesNotThrow(() => { cc.CalcChecksum("5\t1\t9\t5\n5\t1\t9\t5"); });
            Assert.DoesNotThrow(() => { cc.CalcChecksum("5\t1\t9\t5\n5\t1\t9\t5\r\n"); });
        }

        [Test]
        public void CalcChecksum_CalcSumTwoRows_ProperResult()
        {
            int sum = cc.CalcChecksum("5 1 9 5\n5 1 9 5");
            Assert.AreEqual(16, sum);
        }

        //problem example
        [Test]
        public void CalcChecksum_CalcSumManyRows_ProperResult()
        {
            int sum = cc.CalcChecksum("5 1 9 5\n 7 5 3  \n2 4 6 8");
            Assert.AreEqual(18, sum);
        }

        [Test]        
        public void CalcChecksum_CalcSumManyRows_RawSumDivisionAlg_ProperResult()
        {
            cc = new ChecksumCalculator(new RowSumEvenDivisionAlgorithm());
            int sum = cc.CalcChecksum("5 9 2 8\n9 4 7 3\n3 8 6 5");
            Assert.AreEqual(9, sum);
        }
    }
}
