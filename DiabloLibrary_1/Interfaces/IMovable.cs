using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloLibrary_1;
using DiabloLibrary_1.Actions;

namespace DiabloLibrary_1.Interfaces
{
    interface IMovable
    {
        int Speed { get; set; }
        ActionMove Move { get; set; }
    }
}
