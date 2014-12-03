using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radio;

namespace Philips
{
    class Radio : IRadio, IEgaliseur
    {
        string laStation = "France Info";
        int nivGrave = 50;
        int nivAigue = 45;

        string IRadio.Station
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

        void IRadio.Marche()
        {
            Console.WriteLine("Vous écouter {0} sur une Philips, Grave = {1} et Aigue {2}", laStation, nivGrave, nivAigue);
        }

        int IEgaliseur.Graves
        {
            set { nivGrave = value; }
        }

        int IEgaliseur.Aigues
        {
            set { nivAigue = value; }
        }
    }
}