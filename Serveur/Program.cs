using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using ESGI;

namespace Serveur
{
    class Program
    {
        static void Main(string[] args)
        {
            var canal = new TcpChannel(12345);

            ChannelServices.RegisterChannel(canal, false);

            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(Bidon),
                "CalcESGI",
                WellKnownObjectMode.SingleCall
                );

            Console.ReadLine();
        }
    }

    class Bidon : MarshalByRefObject, ICalcul
    {
        ICalcul calc = new Calculatrice();

        public long Ajouter(long a, long b)
        {
            Console.WriteLine("Ajouter {0} et {1}", a, b);
            return calc.Ajouter(a, b);
        }

        public double Multiplier(double a, double b)
        {
            Console.WriteLine("Multiplier {0} et {1}", a, b);
            return calc.Multiplier(a, b);
        }
    }
}
