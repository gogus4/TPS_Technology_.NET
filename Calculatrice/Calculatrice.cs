using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESGI
{
    public class Calculatrice : ICalcul
    {
        public long Ajouter(long a, long b)
        {
            return a + b;
        }

        public double Multiplier(double a, double b)
        {
            return a * b;
        }
    }
}
