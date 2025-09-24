using System;

namespace Monster
{
    internal class Zombie : Monster
    {
        private int _poisonAttackRegist;


        public override void GetDamage(int attack)
        {
            int damage = attack - (_defense + _poisonAttackRegist);

            if (damage > 0) { damage = 0; }

            _health -= damage;
        }

        public Zombie(string name, int health, int defense, int attack)
            : base(name, health, defense, attack) { }
    }
}
