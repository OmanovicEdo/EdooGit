using System.Collections.Generic;

namespace AdventDay2_CorruptionChecksum
{
    public class RowSumEvenDivisionAlgorithm : IRowCalculator
    {
        public int Calculate(List<int> numbers)
        {
            int indexNum1 = -1;
            int indexNum2 = -1;

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i == j) //skip checking divisible with itself
                        continue;

                    if (numbers[i] % numbers[j] == 0)
                    {
                        indexNum1 = i;
                        indexNum2 = j;
                        break;
                    }
                }
            }

            if (indexNum1 == -1 || indexNum2 == -1)
                return 0;

            return numbers[indexNum1] / numbers[indexNum2];
        }
    }
}
