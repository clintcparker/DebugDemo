using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DebugDemo.Library.Collatz
{
    public class CollatzCompute
    {
        public readonly Dictionary<int, int> CycleCache;

        public CollatzCompute()
        {
            CycleCache = new Dictionary<int, int>();
        }


        public Output CalculateMaxCycles(Input input)
        {
            var maxCycleLength = 0;
            for (var i = input.Start; i < input.End; i++)
            {
                var cycleLength = ComputeCycleLength(i);
                if (cycleLength > maxCycleLength)
                {
                    maxCycleLength = cycleLength;
                }
            }


            return new Output
            {
                Input = input,
                Value = maxCycleLength
            };
        }

        private int ComputeCycleLength(int i)
        {
            long tempNum = i;
            var cycles = 1;
            while (tempNum > 1)
            {
                if (tempNum%2 == 0)
                {
                    tempNum = tempNum/2;
                }
                else
                {
                    tempNum = 3*tempNum + 1;
                }
                cycles++;
            }
            return cycles;
        }
    }
}
