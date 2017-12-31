using AdventDay3_SpiralMemory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class MemDataTests
    {
        [Test]
        public void BotAxisNumber_Iteration2Square_Expects23()
        {
            MemData mem = new MemData(3, 5, 25);
            Assert.AreEqual(23, mem.BotAxisNumber);
        }

        [Test]
        public void LeftAxisNumber_Iteration2Square_Expects19()
        {
            MemData mem = new MemData(3, 5, 25);
            Assert.AreEqual(19, mem.LeftAxisNumber);
        }

        [Test]
        public void TopAxisNumber_Iteration2Square_Expects15()
        {
            MemData mem = new MemData(3, 5, 25);
            Assert.AreEqual(15, mem.TopAxisNumber);
        }

    }
}
