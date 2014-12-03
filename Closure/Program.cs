using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Predicate and Display
            var liste = new List<int>() { 212, 14, 75, 33, 331 };

            var critere = Generateur.SuperieurA(80);
            var afficheur = Generateur.Afficher();

            var listeGrand = liste.FindAll(critere);
            listeGrand.ForEach(afficheur);

            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Fibonacci
            var Fibo1 = Generateur.Fibonacci();

            var next = Fibo1();

            while (next < 100)
            {
                Console.WriteLine(next);
                next = Fibo1();
            }

            var Fibo2 = Generateur.Fibonacci();

            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());
            Console.WriteLine("Fibo 2 {0}", Fibo2());

            while (next < 300)
            {
                Console.WriteLine(next);
                next = Fibo1();
            }
            #endregion

            #region Syracuse

            Console.WriteLine(Environment.NewLine + "SYRACUSE");

            int nbPassage = 1;
            var syracuse = Generateur.Syracuse(98765432);

            var nb = syracuse();

            while (nb != 1)
            {
                Console.WriteLine(nb);
                nb = syracuse();
            }

            Console.WriteLine(string.Format("Nombre de passage : {0}", Generateur.nbPassage));

            #region SYRACUSE CORRECTION
            long n = 14;
            long count = 0;

            var t1 = DateTime.Now;

            Syracuse.Max(10000, out n, out count);

            var t2 = DateTime.Now;

            var s = (t2 - t1).TotalSeconds;

            Console.WriteLine("N = {0} Count  = {1} T {2}ms",n,count,s);

            #endregion

            #endregion
        }
    }
}
