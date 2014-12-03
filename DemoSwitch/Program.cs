using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitch
{
    enum Couleur
    {
        Rouge,
        Vert,
        Bleu
    }

    class Program
    {
        const string toto = "toto";
        const string titi = "titi";

        static void Main(string[] args)
        {
            var couleur = Couleur.Rouge;

            #region Demo 1
            switch (couleur)
            {
                case Couleur.Rouge:
                    var n = 13;
                    goto case Couleur.Vert;

                case Couleur.Vert:
                    // Ici pour Rouge ou vert
                    break;
                case Couleur.Bleu:
                    break;
                default:
                    break;
            }

            #endregion

            #region Demo 2
            var s = "toto";

            switch (s)
            {
                case toto:
                    break;

                case titi:
                    break;

                case "tata":
                    break;

                default:
                    break;
            }
            #endregion
        }
    }
}
