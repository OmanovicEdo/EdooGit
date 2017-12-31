using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay3_SpiralMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            SpiralMemory sm = new SpiralMemory();
            int stepCount = sm.FindStepCount(1024);

            Console.WriteLine(stepCount);
            Console.ReadLine();
        }
    }
}
