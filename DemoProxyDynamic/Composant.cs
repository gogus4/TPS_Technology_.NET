using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProxyDynamic
{
    interface IComposant
    {
        string Echo(string s);
    }

    class Composant : IComposant
    {
        public string Echo(string s)
        {
            return s;
        }
    }
}
