using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloLibrary_1
{
    class Quest : GameObject
    {
        int ReqiredLevel { get; set; }
        string Speech { get; set; }     //несколько спичей на каждый квест по персонажам
        object Task { get; set; }       //что вообще нужно сделать
        Reward Reward { get; set; }     
    }

    class Reward
    {
        int Gold;
        int Exp;
        object Item;

        //доп скилы ещё можно
        //ту би континьюед...
    }
}
