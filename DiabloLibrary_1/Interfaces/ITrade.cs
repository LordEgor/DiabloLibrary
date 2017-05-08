using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloLibrary_1.Interfaces
{
    interface ITrade        //торгуем!
    {
        int Gold { get; set; }           //trader's money
        void Buy(object Item);
        void Sell(object Item);
        void Trade(ITrade Target);
    }
}
