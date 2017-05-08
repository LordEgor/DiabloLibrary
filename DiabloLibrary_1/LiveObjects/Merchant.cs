using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloLibrary_1.Interfaces;

namespace DiabloLibrary_1.LiveObjects
{
    class Merchant : NPC, ITrade
    {
        public int Gold { get; set; }

        public void Buy(object Item) { }

        public void Sell(object Item) { }

        public void Trade(ITrade Target) { }
    }
}
