using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_5
{
    class AdapterPrivetBank : PrivetBank, Interface1
    {
        public void Oplata(double summa, int kard)
        {
            OplataSpecific(summa, kard);
        }
    }

}
