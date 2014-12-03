using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIterateur
{
    class Program
    {
        static IEnumerable<string> MesStringsAMoi()
        {
            yield return "A";

            yield return "B";

            yield return "C";

            yield return "D";

            for (var n = 0; n < 2; n++)
            {
                yield return n.ToString();


            }
        }

        static void Main(string[] args)
        {
            foreach (var s in MesStringsAMoi())
            {
                Console.WriteLine(s);
            }

            var it = MesStringsAMoi();
            var enumerateur = it.GetEnumerator();

            while (enumerateur.MoveNext())
            {
                Console.WriteLine("Ici avec le while {0}", enumerateur.Current);
            }
        }
    }
}
