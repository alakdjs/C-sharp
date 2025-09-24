using System;
using System.Security.Cryptography.X509Certificates;

namespace Monster
{
    internal class Goblin : Monster
    {
        private int _physicalAttackRegist;  // 물리 공격 저항력


        public int PhysicalAttackRegist
        {
            get => _physicalAttackRegist;
        }


        public Goblin(string name, int health, int defense, int attack, int physicalRegistAttack)
            : base(name, health, defense, attack)
        {
            _physicalAttackRegist = physicalRegistAttack;
        }

        public override void GetDamage(int attack)
        {
            Console.WriteLine($"Goblin.GetDamge()");
            int damage = attack - (_defense + _physicalAttackRegist);

            if (damage <= 0) { damage = 0; }

            _health -= damage;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"물리공격저항력: {_physicalAttackRegist}");
        }


    }
}
