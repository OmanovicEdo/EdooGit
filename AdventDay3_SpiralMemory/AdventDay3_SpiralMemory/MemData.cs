using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay3_SpiralMemory
{
    public class MemData
    {
        public MemData(int iteration, int squareWidth, int totalNumberCount)
        {
            Iteration = iteration;
            SquareWidth = squareWidth;
            TotalNumberCount = totalNumberCount;
        }

        public int Iteration { set; get; }
        public int SquareWidth { set; get; }
        public int TotalNumberCount { set; get; }

        public int BotAxisNumber { get { return TotalNumberCount - SquareWidth / 2; } }
        public int LeftAxisNumber { get { return BotAxisNumber - (SquareWidth - 1); } }        
        public int TopAxisNumber { get { return LeftAxisNumber - (SquareWidth - 1); } }
        public int RightAxisNumber { get { return TopAxisNumber - (SquareWidth - 1); } }
    }
}
