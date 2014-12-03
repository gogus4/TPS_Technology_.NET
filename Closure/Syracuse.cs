using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    delegate long Next();

    class Syracuse
    {
        static internal Next GetGenerator(long start)
        {
            return delegate()
            {
                start = (start % 2 == 0) ? start / 2 : 3 * start + 1;

                return start;
            };
        }

        static internal long Count(long start)
        {
            var g = GetGenerator(start);

            var n = 1;

            while (g() != 1) n++;

            return n;
        }

        static internal void Max(long limit, out long n, out long count)
        {
            count = 0;
            n = 0;

            for (var k = 2L; k < limit; k++)
            {
                var c = Count(k);

                if (c > count)
                {
                    count = c;
                    n = k;
                }
            }
        }
    }
}
