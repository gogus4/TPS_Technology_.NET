using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    delegate int Suivant();

    class Generateur
    {
        public static int nbPassage { get; set; }

        internal static Suivant Fibonacci()
        {
            var a = 0;
            var b = 1;

            return delegate()
            {
                var s = a + b;
                a = b;
                b = s;

                return s;
            };
        }

        internal static Suivant Syracuse(int nbStart)
        {
            var a = nbStart;
            nbPassage = 0;

            Console.WriteLine(nbStart);

            return delegate()
            {
                if (a % 2 == 0) a = a / 2;

                else a = (a * 3) + 1;

                nbPassage++;

                return a;
            };
        }

        internal static Predicate<int> SuperieurA(int min)
        {
            return delegate(int element)
            {
                return element > min;
            };
        }

        internal static Action<int> Afficher()
        {
            return delegate(int element)
            {
                Console.WriteLine(element);
            };
        }
    }
}
