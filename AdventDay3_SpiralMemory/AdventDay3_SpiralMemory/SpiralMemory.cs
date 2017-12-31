using System;

namespace AdventDay3_SpiralMemory
{
    public class SpiralMemory
    {        
        public MemData FindNumberCount(int maxIterations, int targetNumber)
        {            
            MemData memData = new MemData(1,1,1);

            for (; memData.Iteration < maxIterations; memData.Iteration++)
            {
                memData.TotalNumberCount += 4 * memData.SquareWidth + 4;

                memData.SquareWidth += 2;
                if (memData.TotalNumberCount >= targetNumber)
                    break;
            }

            return memData;
        }

        public int FindStepCount(int targetNumber)
        {
            if (targetNumber == 1)
                return 0;

            MemData memData = FindNumberCount(1000, targetNumber);
                                                
            
            int possibleSteps = Math.Abs(memData.BotAxisNumber - targetNumber);

            if (possibleSteps <= memData.SquareWidth / 2)
                return memData.Iteration + possibleSteps;

            possibleSteps = Math.Abs(memData.LeftAxisNumber - targetNumber);

            if (possibleSteps <= memData.SquareWidth / 2)
                return memData.Iteration + possibleSteps;

            possibleSteps = Math.Abs(memData.TopAxisNumber - targetNumber);

            if (possibleSteps <= memData.SquareWidth / 2)
                return memData.Iteration + possibleSteps;

            possibleSteps = Math.Abs(memData.RightAxisNumber - targetNumber);

            if (possibleSteps <= memData.SquareWidth / 2)
                return memData.Iteration + possibleSteps;

            return memData.Iteration;
        }
    }
}