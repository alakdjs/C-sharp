using System;


namespace Monster
{
    internal abstract class Monster // 추상클래스
    {
        protected string _name;   // 몬스터명
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

        protected abstract void GetDamage(int attack); // 추상메소드


        public void Attack(Monster enemy)
        {
            Console.WriteLine($"Attack(Monster)");
            int oldHealth = enemy._health;

            enemy.GetDamage(_attack);

            Console.WriteLine($"{_name}이 {enemy._name}을 공격해서 {enemy._name}의 생명력이 {oldHealth}에서 {enemy._health}로 내려감");

        }

        // Goblin, Slime이 있습니다.
        // Damage 처리하는 방식도 변경하세요..



        public void Info()
        {
            Console.WriteLine($"몬스터명: {_name}\n생명력: {_health}\n방어력: {_defense}\n공격력: {_attack}");
        }
    }
}
