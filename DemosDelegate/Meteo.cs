using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosDelegate
{
    class Meteo
    {
        double temperature = 23.7;

        public event Trace TropChaud;
        public event Trace TropFroid;

        public void PlusChaud()
        {
            temperature += 1.1;

            if (temperature > 45)
            {
                if (TropChaud != null)
                {
                    TropChaud(String.Format("Trop chaud T = {0:F2}", temperature));
                }
            }
        }

        public void MoinsChaud()
        {
            temperature -= 0.9;

            if (temperature < -10)
            {
                if (TropFroid != null)
                {
                    TropFroid(String.Format("Trop froid T = {0:F3}", temperature));
                }
            }
        }

    }
}
