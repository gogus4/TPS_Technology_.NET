using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    interface IRadio
    {
        string Station { get; set; }
        void Marche();
    }

    interface IEgaliseur
    {
        int Graves { set; }
        int Aigues { set; }
    }
}


