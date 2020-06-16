using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_5
{
    class AdapterBayBank : BayBank, Interface1
    {
        public void Oplata(double summa, int kard)
        {
            Oplatite_Specific(kard, summa);
        }
    }
}
