using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloLibrary_1.Interfaces;

namespace DiabloLibrary_1.LiveObjects
{
    class Enemy : LiveObject, IAttackable
    {
        public Race Race { get; set; }
        


        public int Damage { get; set; }

        public int ArmorClass { get; set; }

        public int DamageReduction { get; set; }

        public int ToHit { get; set; }

        public int Level { get; set; }

        public bool IsHit(IAttackable Target) { return false; }

        public void Attack(IAttackable Target) { }

    }

    public enum Race
    {
        Beast = 1, Demon = 2, Undead = 3
    }
}
