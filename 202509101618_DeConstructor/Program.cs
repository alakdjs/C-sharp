using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509101618_DeConstructor
{
    // 소멸자의 호출 시점
    // 가비지 콜렉터(garbase collector)
    class Cat
    {
        public Cat()
        {
            Console.WriteLine("Cat 기본 생성자");
            Name  = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Console.WriteLine($"{_Name} Cat 인자 2개를 받는 생성자");
            Name = _Name;
            Color = _Color;
        }

        // 소멸자: 객체가 소멸될 때 호출 되어지는 메소드
        // C#에서는 garbase collector가 참조되지 않는 객체를 가끔씩 정리하는 작업을 합니다.
        // 정리 작업중에 소멸자가 호출되는데 소멸자의 호출 시점을 알 수가 없습니다.
        // C#에서는 될 수 있으면 소멸자에서 작업을 안하는 것이 좋습니다.
        ~Cat() // 소멸자
        {
            Console.WriteLine("Cat 소멸자");
            Console.WriteLine($"{Name} : 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class MainApp
    {
        public static void Sample()
        {
            Cat mons = new Cat("몬스", "회색");
            mons.Meow();
        }
        static void Main(string[] args)
        {
            Sample();
            Console.WriteLine();
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            GC.Collect();   // 가비지 컬렉터 작동
            Console.ReadLine(); // 멈춤 입력 대기

            Console.WriteLine();
            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
