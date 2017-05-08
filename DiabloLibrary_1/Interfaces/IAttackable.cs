using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiabloLibrary_1.Interfaces
{
    interface IAttackable
    {
        /// <summary>
        /// наносимый урон
        /// </summary>
        int Damage { get; set; }
        /// <summary>
        /// класс доспехов
        /// </summary>
        int ArmorClass { get; set; }
        /// <summary>
        /// снижение урона
        /// </summary>
        int DamageReduction { get; set; }
        /// <summary>
        /// шанс попасть
        /// </summary>
        int ToHit { get; set; }
        /// <summary>
        /// уровень текущего объекта, который реализует этот интерфейс
        /// </summary>
        int Level { get; set; }

        bool IsHit(IAttackable Target);     //был ли атакован Target - цель
        void Attack(IAttackable Target);    //атака цели Target
    }
}
