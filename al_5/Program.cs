using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Interface1 int1 = new AdapterBetaBank();
            int1.Oplata(456464, 453);
            Interface1 int2 = new AdapterPrivetBank();
            int2.Oplata(5454, 546424);
            Interface1 int3 = new AdapterBayBank();
            int3.Oplata(5412124, 5454);
            Console.ReadLine();
        }
    }
}
