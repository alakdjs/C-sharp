using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _202509111700_inheritance
{
    // 상속
    // 일반화 (generalization)

    // 동물농장 시뮬레이션
    // 돼지, 소, 닭

    // 상속의 장점
    // 1. 코드 재사용성
    // 2. 유지보수 용이성
    // 3. 확장성
    // 4. 다형성의 기반 구조를 제공

    class Stock
    {
        // 속성
        private string _name;   // 이름
        private float _weight; // 몸무게
        private float _height;  // 신장
        private float _age; // 나이
        private float _healthRate;  // 건강지수

        protected string Name
        {
            get { return _name; }
        }

        public Stock(string name, float weight, float height, float age, float healthRate)
        {
            _name = name;
            _weight = weight;
            _height = height;
            _age = age;
            _healthRate = healthRate;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name}가 꿀꿀합니다.");
        }

        public void Run()
        {
            Console.WriteLine($"{_name}가 뜁니다.");
        }

        public void Eat()
        {
            Console.WriteLine($"{_name}가 먹습니다.");
        }

        string GetHealth()
        {
            if (_healthRate >= 90)
            {
                return "매우 건강";
            }
            else if (70 < _healthRate && _healthRate < 90)
            {
                return "건강";
            }
            else if (60 < _healthRate && _healthRate <= 70)
            {
                return "보통";
            }
            else if (40 < _healthRate && _healthRate <= 60)
            {
                return "미흡";
            }
            else
            {
                return "치료 요망";
            }
        }

        public void Info()
        {
            Console.WriteLine($"이름: {_name}\n몸무게: {_weight}\n신장: {_height}\n나이: {_age}\n건강지수: {GetHealth()}\n");
        }

    }

    class Pig : Stock 
    {
        public Pig(string name, float weight, float height, float age, float healthRate)
            : base(name, weight, height, age, healthRate) { }
    }

    class Cow : Stock
    {
        public Cow(string name, float weight, float height, float age, float healthRate)
            : base(name, weight, height, age, healthRate) { }
    }

    class Chicken : Stock
    {
        bool _isFly;

        private void Fly()
        {
            Console.WriteLine($"{Name}이 납니다.");
        }

        private string GetKind()
        {
            if (_isFly)
            {
                return "나는 닭";
            }
            else
            {
                return "못나는 닭";
            }
        }

        public Chicken(string name, float weight, float height, float age, float healthRate, bool isFly)
            : base(name, weight, height, age, healthRate)
        {
            _isFly = isFly;
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name}이 꼬끼오 합니다.");
        }

        public new void Run()
        {
            if (_isFly)
            {
                Fly();
            }
            else
            {
                base.Run();
            }
        }

        public new void Info() // 메소드 Hiding
        {
            base.Info();
            Console.WriteLine($"\n종류: {GetKind()}");
        }

    }

    class Sheep : Stock
    {
        private bool _type; // true: 털 양, false: 고기 양

        public Sheep(string name, float weight, float height, float age, float healthRate, bool type)
            : base(name, weight, height, age, healthRate)
        {
            _type = type;
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name}가 음메에에에 합니다.");
        }

        public new void Info()
        {
            base.Info();
            string type = _type ? "털양" : "고기양";
            Console.WriteLine($"종류: {type}");
        }
    }

    class Fish : Stock
    {
        private bool _eat;
        public Fish(string name, float weight, float height, float age, float healthRate, bool eat)
            : base(name, weight, height, age, healthRate) 
        {
            _eat = eat;
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name}가 뻐끔뻐끔 합니다.");
        }

        public new void Info()
        {
            base.Info();
            string eat = _eat ? "식용물고기" : "관상물고기";
            Console.WriteLine($"종류: {eat}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig("돼지", 200.0f, 150.0f, 4.3f, 80.0f);
            Cow cow = new Cow("소", 350.0f, 200.0f, 2.3f, 75.0f);
            Chicken flyChicken = new Chicken("나는 닭", 4.3f, 1.2f, 1.5f, 60.0f, true);
            Chicken notFlyChicken = new Chicken("못나는 닭", 3.8f, 1.4f, 1.0f, 40.0f, false);
            Sheep purSheep = new Sheep("털양", 200.0f, 150.0f, 1.8f, 60.0f, true);
            Sheep beefSheep = new Sheep("고기양", 180.0f, 140.0f, 2.0f, 40.0f, false);
            Fish eatFish = new Fish("식용물고기", 10.0f, 30.0f, 1.0f, 50.0f, true);
            Fish seeFish = new Fish("관상물고기", 50.0f, 120.0f, 1.0f, 80.0f, false);

            pig.Speak();
            cow.Speak();
            flyChicken.Speak();
            notFlyChicken.Speak();
            purSheep.Speak();
            beefSheep.Speak();
            eatFish.Speak();
            seeFish.Speak();

            Console.WriteLine();

            pig.Run();
            cow.Run();
            flyChicken.Run();
            notFlyChicken.Run();
            purSheep.Run();
            beefSheep.Run();
            eatFish.Run();
            seeFish.Run();

            Console.WriteLine();

            pig.Info();
            Console.WriteLine();

            cow.Info();
            Console.WriteLine();

            flyChicken.Info();
            Console.WriteLine();

            notFlyChicken.Info();
            Console.WriteLine();

            purSheep.Info();
            Console.WriteLine();

            beefSheep.Info();
            Console.WriteLine();

            eatFish.Info();
            Console.WriteLine();

            seeFish.Info();
            Console.WriteLine();

        }
    }
}
