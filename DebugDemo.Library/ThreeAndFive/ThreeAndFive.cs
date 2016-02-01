using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DebugDemo.Library.Collatz;

namespace DebugDemo.Library.ThreeAndFive
{
    public class ThreeAndFive
    {
        public Output FindSum(Input input)
        {
            var sum = 0;

            //Edit & Continue :)
            //for (var i = input.Start; i < input.End; i++)
            //{
            //    if (i%3 == 0 || i%5 == 0)
            //    {
            //        sum += i;
            //    }
            //}

            return new Output {Input = input,Value = sum};
        }
    }
}
