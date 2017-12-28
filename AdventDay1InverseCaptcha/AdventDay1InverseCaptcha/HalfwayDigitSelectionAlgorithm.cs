using System;

namespace AdventDay1InverseCaptcha
{
    public class HalfwayDigitSelectionAlgorithm
    {
        public int CalcCaptchaSum(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return 0;
                        
            var chars = input.ToCharArray();

            int sum = 0;
            int half = chars.Length / 2;

            for (int i = 0; i < half; i++)
            {
                if (chars[i] == chars[i + half])
                    sum += ConvertCharToInt(chars[i]);
            }

            return sum * 2;
       }

        private int ConvertCharToInt(char ch)
        {
            return Convert.ToInt32(ch) - Convert.ToInt32('0');
        }
    }
}