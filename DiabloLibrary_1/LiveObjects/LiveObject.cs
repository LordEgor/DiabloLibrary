using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloLibrary_1.Interfaces;
using DiabloLibrary_1;
using DiabloLibrary_1.Actions;

namespace DiabloLibrary_1.LiveObjects
{
    public abstract class LiveObject : GameObject, IMovable
    {
        public int CurrentHealth;
        public int MaxHealth;
        Position Position;



        public int Speed { get; set; }

        public ActionMove Move { get; set; }

        public LiveObject()
        {
            Move = ActionMove.GetInstance();
            //Move = null;
        }
    }
}
