using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radio;

namespace Sony
{
    class Radio : IRadio
    {
        string laStation = "FIP";

        public string Station
        {
            get
            {
                return laStation;
            }
            set
            {
                laStation = value;
            }
        }

        public void Marche()
        {
            Console.WriteLine("Vous écouter {0} sur une Sony...", laStation);
        }
    }
}