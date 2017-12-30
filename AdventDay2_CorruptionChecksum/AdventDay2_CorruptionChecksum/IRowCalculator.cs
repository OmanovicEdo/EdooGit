using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventDay2_CorruptionChecksum
{
    public interface IRowCalculator
    {
        int Calculate(List<int> numbers);
    }
}
