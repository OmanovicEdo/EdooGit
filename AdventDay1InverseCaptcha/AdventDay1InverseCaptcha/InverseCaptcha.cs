using System;

namespace AdventDay1InverseCaptcha
{
    public class InverseCaptcha
    {
        public int CalcCaptchaSum(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length == 1)
                return 0;

            input = AddCyclicityToString(input);
            var chars = input.ToCharArray();

            int sum = 0;
            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == chars[i + 1])
                    sum += ConvertCharToInt(chars[i]);
            }

            return sum;
        }

        //adding first char to the end of  input string simulates cyclic nature of the input number
        private static string AddCyclicityToString(string input)
        {
            input += input[0];
            return input;
        }

        private int ConvertCharToInt(char ch)
        {
            return Convert.ToInt32(ch) - Convert.ToInt32('0');
        }
    }
}
