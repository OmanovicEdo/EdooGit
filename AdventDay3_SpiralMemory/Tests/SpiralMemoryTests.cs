using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventDay3_SpiralMemory;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class SpiralMemoryTest
    {
        SpiralMemory _spiralMemory;

        [SetUp]
        public void Init()
        {
            _spiralMemory = new SpiralMemory();
        }
                
        [Test]
        public void FindNumberCount_Square1_Total1Numbers()
        {
            MemData mem = _spiralMemory.FindNumberCount(1, 1000);
            Assert.AreEqual(mem.SquareWidth, 1);
            Assert.AreEqual(mem.Iteration, 1);
            Assert.AreEqual(mem.TotalNumberCount, 1);                        
        }

        [Test]
        public void FindNumberCount_Square2_Total9Numbers()
        {
            MemData mem = _spiralMemory.FindNumberCount(2, 1000);
            Assert.AreEqual(mem.SquareWidth, 3);
            Assert.AreEqual(mem.Iteration, 2);
            Assert.AreEqual(mem.TotalNumberCount, 9);
        }

        [Test]
        public void FindNumberCount_Square3_Total25Numbers()
        {
            MemData mem = _spiralMemory.FindNumberCount(3, 1000);
            Assert.AreEqual(mem.SquareWidth, 5);
            Assert.AreEqual(mem.Iteration, 3);
            Assert.AreEqual(mem.TotalNumberCount, 25);

        }

        [Test]
        public void FindNumberCount_SquareWidth2_Total_325489_Numbers()
        {
            MemData mem = _spiralMemory.FindNumberCount(1000, 325489);

            Assert.GreaterOrEqual(mem.TotalNumberCount, 325489);
            //total number should count slighlty over 325489 - until fnishing a square
            //we use two other informations from MemData class to find number of steps to reach our number
        }

        [Test]
        public void FindStepCount_BaseSquareOfOne()
        {
            int stepCount = _spiralMemory.FindStepCount(1);
            Assert.AreEqual(stepCount, 0);
        }

        [Test]
        public void FindStepCount_OnMainAxisIteration2_StepCount1()
        {
            int stepCount = _spiralMemory.FindStepCount(4);
            Assert.AreEqual(stepCount, 1);

            int stepCount2 = _spiralMemory.FindStepCount(6);
            Assert.AreEqual(stepCount2, 1);
        }

        [Test]
        public void FindStepCount_OnMainAxisIteration2_StepCount2()
        {
            int stepCount = _spiralMemory.FindStepCount(15);
            Assert.AreEqual(stepCount, 2);

            int stepCount2 = _spiralMemory.FindStepCount(23);
            Assert.AreEqual(stepCount2, 2);
        }


        [Test]
        public void FindStepCount_OffMainAxisIteration2_BottomTargetNumber_StepCount2()
        {
            int stepCount = _spiralMemory.FindStepCount(24);
            Assert.AreEqual(stepCount, 3);            
        }


        [Test]
        public void FindStepCount_OffMainAxisIteration2_LeftTargetNumber_StepCount2()
        {
            int stepCount = _spiralMemory.FindStepCount(20);
            Assert.AreEqual(stepCount, 3);

            int stepCount2 = _spiralMemory.FindStepCount(21);
            Assert.AreEqual(stepCount2, 4);
        }

        [Test]
        public void FindStepCount_OffMainAxisIteration2_TopTargetNumber_StepCount2()
        {
            int stepCount = _spiralMemory.FindStepCount(16);
            Assert.AreEqual(stepCount, 3);
            int stepCount2 = _spiralMemory.FindStepCount(14);
            Assert.AreEqual(stepCount2, 3);
            int stepCount3 = _spiralMemory.FindStepCount(13);
            Assert.AreEqual(stepCount3, 4);
        }

        [Test]
        public void FindStepCount_OffMainAxisIteration2_RightTargetNumber_StepCount2()
        {
            int stepCount = _spiralMemory.FindStepCount(12);
            Assert.AreEqual(stepCount, 3);

            int stepCount2 = _spiralMemory.FindStepCount(10);
            Assert.AreEqual(stepCount2, 3);
            int stepCount3 = _spiralMemory.FindStepCount(13);
            Assert.AreEqual(stepCount3, 4);
        }

    }
}

