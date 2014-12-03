using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Program
    {
        static void TestRadio(IRadio radio, string station)
        {
            radio.Station = station;

            IEgaliseur eg = radio as IEgaliseur;

            if (eg != null)
            {
                eg.Aigues = 200;
                eg.Graves = 330;
            }

            if (radio is IEgaliseur)
            {
                var eg2 = (IEgaliseur)radio;
                eg2.Graves = 300;
            }

            radio.Marche();
        }

        static void Main(string[] args)
        {
            IRadio sony = new Sony.Radio();
            IRadio philips = new Philips.Radio();

            TestRadio(sony, "RFM");
            TestRadio(philips, "NRJ");

            /*sony.Marche();
            sony.Station = "RFM";
            sony.Marche();*/
        }
    }
}