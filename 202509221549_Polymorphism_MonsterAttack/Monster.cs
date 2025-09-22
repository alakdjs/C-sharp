using System;
using System.Threading.Tasks;

namespace Monster
{
    internal class Monster
    {
        protected string _name;  // 몬스터명
        protected int _health;    // 생명력
        protected int _defense;   // 방어력
        protected int _attack;    // 공격력

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int Defense
        {
            get => _defense;
        }

        public string Name
        {
            get => _name;
        }

        public Monster(string name, int health, int defense, int attack)
        {
            _name = name;
            _health = health;
            _defense = defense;
            _attack = attack;
        }

        public void Attack(Monster enemy)
        {
            int oldHealth = enemy._health;
            int damage = _attack - enemy._defense;

            if (damage < 0)
            {
                damage = 0;
            }

            enemy._health -= damage;
            Console.WriteLine($"{_name}이 {enemy._name}을 공격해서 {enemy._name}의 생명력이 {oldHealth}에서 {enemy._health}로 내려감");
        }

        public void Info()
        {
            Console.WriteLine($"몬스터명: {_name}\n생명력: {_health}\n방어력: {_defense}\n공격력: {_attack}");
        }
    }
}
