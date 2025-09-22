using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    internal class Goblin : Monster
    {
        private int _physicalAttackRegist;

        public int PhysicalAttackRegist
        {
            get => _physicalAttackRegist;
        }

        public Goblin(string name, int health, int defense, int attack, int physicalRegistAttack)
            : base(name, health, defense, attack) { }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"물리공격저항력: {_physicalAttackRegist}");
        }
    }
}
