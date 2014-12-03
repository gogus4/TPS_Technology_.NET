using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeParametre
{
    class Program
    {
        static void Main(string[] args)
        {
            var mille = new NamedObject<int>("Mille",1000);
            var pi = new NamedObject<double>("Pi", 3.141596);

            Console.WriteLine("{0}",mille);
            Console.WriteLine("{0}",pi);

            double x = (double)pi;
            int n = (int)mille;

            Console.WriteLine(x);
            Console.WriteLine(n);
        }
    }
}
