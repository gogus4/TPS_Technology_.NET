using System;
using System.Linq;

namespace DemoLinq
{
    class Program
    {
        static void Demo2()
        {
            var phrases = new[] { 
                "Une requête plus compliquée.",
                "Elle illustre l'usage du mot clé 'let'.",
                "Elle utilise les opérateurs Distinct et ToArray."
            };

            var q = from phrase in phrases
                    let mots = phrase.Split(' ', '\'')
                    from mot in mots
                    where mot.Length > 0
                    let premierLettre = mot.ToLower()[0]
                    where "aeiouy".Contains(premierLettre)
                    select mot;

            var leResultat = q.Distinct();

            var tableau = leResultat.ToArray();

            foreach (var s in tableau)
            {
                Console.WriteLine(s);
            }
        }

        static void Main(string[] args)
        {
            // Sample Linq
            var data = new int[] { 3, 7, 5, 10 };

            var q = from n in data where n > 6 select n;

            data[0] = 300;

            foreach (var n in q)
            {
                Console.WriteLine(n);
            }

            // Sample with words
            Demo2();

        }
    }
}