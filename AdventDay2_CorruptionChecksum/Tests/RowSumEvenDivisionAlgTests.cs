using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventDay2_CorruptionChecksum;
using NUnit.Framework;

namespace Tests
{        
    [TestFixture]
    public class RowSumEvenDivisionAlgTests
    {
        RowSumEvenDivisionAlgorithm _calcAlg;

        [SetUp]
        public void Init()
        {
            _calcAlg = new RowSumEvenDivisionAlgorithm();
        }

        [Test]
        public void CalcRowSumEvenDivision_EmptyList_Zero()
        {            
            int sum = _calcAlg.Calculate(new List<int>());
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void CalcRowSumEvenDivision_DivisiblePair82_Result()
        {
            _calcAlg = new RowSumEvenDivisionAlgorithm();
            var numbers = new List<int>() { 5, 9, 2, 8 };
            int sum = _calcAlg.Calculate(numbers);
            Assert.AreEqual(4, sum);
        }
    }
}
