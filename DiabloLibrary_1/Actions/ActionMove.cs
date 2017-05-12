using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloLibrary_1.Actions
{
    class ActionMove : ActionBase
    {
        //движение
        //паттерн SingleTon
        private static ActionMove instance;

        public static ActionMove GetInstance()
        {
            if (instance == null)
                instance = new ActionMove();
            return instance;
        }

        public override void Action()
        {
          // Здесь нужно описать движение. Возможно, вызов стороннего метода MoveTo(Position pos)  
        }

        private ActionMove()
        {

        }
    }
}
