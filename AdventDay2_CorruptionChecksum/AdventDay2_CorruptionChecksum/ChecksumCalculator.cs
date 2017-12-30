using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventDay2_CorruptionChecksum
{
    public class ChecksumCalculator
    {
        IRowCalculator _calcAlgorithm;

        public ChecksumCalculator(IRowCalculator calcAlgorithm)
        {
            _calcAlgorithm = calcAlgorithm;
        }

        public int CalcChecksum(string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentException("Unable to convert input to numbers");

            string[] rows = input.Replace("\r\n", "\n").Split('\n');

            int sum = 0;
            foreach (var row in rows)
            {
                if (string.IsNullOrEmpty(row))
                    continue;
                var numbers = FindNumbers(row);
                sum += _calcAlgorithm.Calculate(numbers);
            }

            return sum;
        }

        private List<int> FindNumbers(string row)
        {
            string rowCleaned = RemoveInvalidChars(row);
            var splitInput = rowCleaned.Split(' ');
            return ParseToNumbers(splitInput);            
        }
        
        private string RemoveInvalidChars(string row)
        {
            string s = row.Replace('\t', ' ');
            return s;
        }

        private List<int> ParseToNumbers(string[] splitInput)
        {
            var numbers = new List<int>();

            foreach (string s in splitInput)
            {
                if (SkipWhiteSpaces(s))
                    continue;

                if (int.TryParse(s.Trim(), out int res))
                    numbers.Add(res);
                else
                    throw new ArgumentException("Unable to convert input to numbers");
            }

            return numbers;
        }

        private static bool SkipWhiteSpaces(string s)
        {
            return s.Trim() == string.Empty;
        }
    }
}