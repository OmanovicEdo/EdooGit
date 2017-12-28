using System;

using System.IO;

namespace AdventDay1InverseCaptcha
{
    class Program
    {
        static void Main(string[] args)
        {            
            var nd = new NextDigitSelectionAlgorithm();
            var hd = new HalfwayDigitSelectionAlgorithm();

            string puzzleInput = File.ReadAllText(@"..\..\..\PuzzleInput.txt");

            Console.WriteLine("Next digit algorithm");
            Console.WriteLine(nd.CalcCaptchaSum(puzzleInput));            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Halfway digit algorithm");
            Console.WriteLine(hd.CalcCaptchaSum(puzzleInput));
            Console.ReadLine();
        }
    }
}
