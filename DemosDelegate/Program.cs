
using System;
namespace DemosDelegate
{
    delegate void Trace(string message);

    class Program
    {
        static void F(string s)
        {
            Console.WriteLine("Ici F s = '{0}'", s);
        }

        static void G(string s)
        {
            Console.WriteLine("Ici G s = '{0}'", s);
        }

        static void DemosDelegate(Trace t, string message)
        {
            if ((t != null) && (message != null))
                t(message);
        }

        static void Main(string[] args)
        {
            #region Event Sample

            var meteoParis = new Meteo();

            meteoParis.TropChaud += F;
            meteoParis.TropFroid += G;

            for (var n = 0; n < 23; n++) meteoParis.PlusChaud();
            for (var n = 0; n < 70; n++) meteoParis.MoinsChaud();

            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Delegate With Method Instance
            var b1 = new Bidon("Toto");
            var b2 = new Bidon("Titi");

            Trace tb = b1.Afficher;
            tb += b2.Afficher;

            tb("Bidon");
            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Delegate Method
            DemosDelegate(F, "Demo de F");
            DemosDelegate(G, "Demo de G");
            DemosDelegate(G, null);
            #endregion

            Console.WriteLine(Environment.NewLine);

            #region Delegate Simple
            Trace t = F;

            t("un F");

            t += G;

            t("F et G");

            t += G;

            t("un F et deux G");

            // t -= F;

            t("Deux G");

            t -= G;

            t("Un G");

            t -= G;

            if (t != null)
                t("Vide");
            #endregion
        }
    }
}