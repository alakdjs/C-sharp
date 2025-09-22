using System;

using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Monster
{
    internal class Vampire : Monster
    {
        public Vampire(string name, int health, int defense, int attack)
            : base(name, health, defense, attack) { }

        public new void Attack(Monster enemy)
        {
            int oldHealth = enemy.Health;
            int damage = _attack - enemy.Defense;

            if (damage < 0)
            {
                damage = 0;
            }

            enemy.Health -= damage;
            _health += damage;
            Console.WriteLine($"{_name}이 {enemy.Name}을 공격해서 {enemy.Name}의 생명력이 {oldHealth}에서 {enemy.Health}로 내려감\n{_name}는 {damage}만큼 체력을 흡혈.");

        }
    }
}
