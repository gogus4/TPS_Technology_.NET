using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 3, 7, 5, 10 };

            var q = from n in data where n > 6 select n;

            data[0] = 300;

            foreach(var n in q)
            {
                Console.WriteLine(n);
            }
        }
    }
}