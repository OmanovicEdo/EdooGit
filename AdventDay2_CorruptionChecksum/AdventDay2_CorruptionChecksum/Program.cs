using System;
using System.IO;

namespace AdventDay2_CorruptionChecksum
{
    class Program
    {
        static void Main(string[] args)
        {
            string puzzleInput = File.ReadAllText(@"..\..\PuzzleInput.txt");
                        
            var cc = new ChecksumCalculator(new RowSumSubstractionAlgorithm());            
            int sum = cc.CalcChecksum(puzzleInput);

            Console.WriteLine(sum);
            Console.WriteLine("------------");

            var cc2 = new ChecksumCalculator(new RowSumEvenDivisionAlgorithm());
            int sum2 = cc2.CalcChecksum(puzzleInput);
            Console.WriteLine(sum2);
            Console.Read();

        }
    }
}
