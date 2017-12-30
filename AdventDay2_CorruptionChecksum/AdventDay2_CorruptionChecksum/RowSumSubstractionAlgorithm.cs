using System.Collections.Generic;
using System.Linq;

namespace AdventDay2_CorruptionChecksum
{
    public class RowSumSubstractionAlgorithm : IRowCalculator
    {
        public int Calculate(List<int> numbers)
        {
            return (numbers.Max() - numbers.Min());
        }
    }
}
