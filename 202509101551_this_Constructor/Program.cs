using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509101551_this_Constructor
{
    // this: 클래스의 현재 인스턴스를 가리키는 키워드
    // this Constructor
    class Monster
    {
        private int _health, attack, _defense;

        public Monster()
        {
            Console.WriteLine("기본생성자");
            this._health = 0;
        }

        public Monster(int attack) : this()
        {
            Console.WriteLine("인자를 1개 받는 생성자");
            this.attack = attack;
        }

        public Monster(int attack, int defense) : this(attack)
        {
            Console.WriteLine("인자를 2개 받는 생성자");
            _defense = defense;
        }

        public void Info()
        {
            Console.WriteLine($"생명력: {_health}, 공격력: {attack}, 방어력: {_defense}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
                Monster a = new Monster(); // 기본 생성자 호출
                a.Info();

                Console.WriteLine();

                Monster b = new Monster(50); // 인자를 1개 받는 생성자 호출
                b.Info();

                Console.WriteLine();

                Monster c = new Monster(50, 30); // 인자를 2개 받는 생성자 호출
                c.Info();
        }
    }
}
