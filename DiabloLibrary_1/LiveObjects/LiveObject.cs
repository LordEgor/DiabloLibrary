using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloLibrary_1.Interfaces;
using DiabloLibrary_1;

namespace DiabloLibrary_1.LiveObjects
{
    public abstract class LiveObject : GameObject, IMovable
    {
        public int CurrentHealth;
        public int MaxHealth;
        Position Position;

        public void MoveTo(Position NewPos)
        {
            this.Position = NewPos;
        }
    }
}
