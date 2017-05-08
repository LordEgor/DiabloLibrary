using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiabloLibrary_1.Interfaces;
using DiabloLibrary_1.Skills;

namespace DiabloLibrary_1.LiveObjects
{
    public class Hero : LiveObject, IAttackable, ITalk, ITrade
    {
        Skill RightMouseSkill;
        Skill LeftMouseSkill;

        void RightMouseClick()
        {
            RightMouseSkill.Action();
        }
        void LeftMouseClick()
        {
            LeftMouseSkill.Action();
        }



        public int Damage { get; set; }

        public int ArmorClass { get; set; }

        public int DamageReduction { get; set; }

        public int ToHit { get; set; }

        public int Level { get; set; }

        public bool IsHit(IAttackable Target) { return false; }

        public void Attack(IAttackable Target) { }

        public void TalkTo(ITalk Target) { }

        public int Gold { get; set; }

        public void Buy(object Item) { }

        public void Sell(object Item) { }

        public void Trade(ITrade Target) { }
    }

    class HeroClass
    {
        object Model;       //моделька класса
        string Name;        //имя класса
        
        int BaseHealth;         //здравие
        int BaseMana;           //мана
        int BaseStrength;       //сила
        int BaseAgility;        //ловкость
        int BaseIntelligence;   //интеллект  
        int BaseVitality;       //живучесть, конституция

        Skill BaseSkill;    //базовый скилл
    }
}
