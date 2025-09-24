using System;


namespace Monster
{
    internal class Snake : Monster
    {
        private int _poisonAttackRegist = 0;

        public Snake(string name, int health, int defense, int attack)
            : base(name, health, defense, attack) { }

        // snake 클래스 만드는 개발자
        // snake의 특수능력 반영하는 GetDamage 함수를 만들지 않았습니다.
        // snake은 Monster의 GetDamage 메소드가 호출되어 처리 되고 있습니다.
        // 몬스터가 추가될 경우 반드시 GetDamage메소드 추가 되도록 만드세요...


        protected override void GetDamage(int attack)
        {
            Console.WriteLine($"Snake.GetDamage()");
            int damage = attack - (_defense + _poisonAttackRegist);

            if (damage <= 0) { damage = 0; }

            _health -= damage;
        }

    }
}
