using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace AdventDay1InverseCaptcha
{
    class Program
    {
        static void Main(string[] args)
        {
            InverseCaptcha ic = new InverseCaptcha();

            string puzzleInput = File.ReadAllText(@"..\..\..\PuzzleInput.txt");

            int sum = ic.CalcCaptchaSum(puzzleInput);

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
