using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509121603_Inheritance_Specialization
{
    // 상속
    // 특수화
    // 동물 농장 시뮬레이션
    // 돼지, 소, 닭

    class Animal
    {
        protected string _name;
        private float _age;
        private float _weight;
        private float _healthRate;


        public Animal(string name, float age, float weight, float healthRate)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _healthRate = healthRate;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name} 이(가) 말합니다.");
        }

        public void Eat()
        {
            Console.WriteLine($"{_name} 이(가) 먹습니다.");
        }
        
        public void Run()
        {
            Console.WriteLine($"{_name} 이(가) 뜁니다.");
        }

        public void CheckHealthRate()
        {
            if(_healthRate <= 100 && _healthRate > 80)
            {
                Console.WriteLine($"{_name}의 건강이 아주 좋습니다.");
            }
            else if (_healthRate <= 80 &&  _healthRate > 60)
            {
                Console.WriteLine($"{_name}의 건강이 좋습니다");
            }
            else if( _healthRate <= 60 &&  _healthRate > 40)
            {
                Console.WriteLine($"{_name}의 건강이 보통입니다.");
            }
            else
            {
                Console.WriteLine($"{_name}의 건강이 안좋습니다. 검사가 필요합니다.");
            }
        }

        public void Info()
        {
            Console.WriteLine($"이름: {_name}\n나이: {_age}\n체중: {_weight}");
            Console.WriteLine($"건강상태: ");
            CheckHealthRate();
        }
    }

    class Cow : Animal
    {
        public Cow(string name, float age, float weight, float healthRate)
            : base(name, age, weight, healthRate) { }

        public new void Speak()
        {
            Console.WriteLine($"{_name}가 음메합니다.");
        }
    }

    class Pig : Animal
    {
        public Pig(string name, float age, float weight, float healthRate) 
            : base(name, age, weight, healthRate) { }

        public new void Speak()
        {
            Console.WriteLine($"{_name}가 꿀꿀합니다.");
        }
    }

    class Chicken : Animal
    {
        private bool _isFly;

        private void Fly()
        {
            Console.WriteLine($"{_name}이 납니다.");
        }

        public Chicken(string name, float age, float weight, float healthRate, bool isFly)
            : base(name, age, weight, healthRate)
        {
            _isFly = isFly;
        }

        public new void Speak()
        {
            Console.WriteLine($"{_name}이 꼬끼오 합니다.");
        }

        public new void Run()
        {
            if(_isFly)
            {
                Fly();
            }
            else
            {
                base.Run();
            }
        }

        public new void Info()
        {
            base.Info();
            if(_isFly)
            {
                Console.WriteLine("종류: 나는 닭");
            }
            else
            {
                Console.WriteLine("종류: 못나는 닭");
            }
        }
    }

    class Dolphin : Animal
    {
        private void Swim()
        {
            Console.WriteLine($"{_name}이 헤엄칩니다.");
        }

        public Dolphin(string name, float age, float weight, float healthRate)
            : base(name, age, weight, healthRate) { }

        public new void Speak()
        {
            Console.WriteLine($"{_name}가 끽끽합니다.");
        }

        public new void Run()
        {
            Swim();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig("돼지", 2.8f, 200.0f, 65.0f);
            Cow cow = new Cow("소", 1.9f, 240.0f, 83.0f);
            Chicken flyChicken = new Chicken("나는 닭", 2.9f, 4.0f, 90.0f, true);
            Chicken notFlyChicken = new Chicken("못 나는 닭", 0.8f, 3.0f, 90.0f, false);
            Dolphin dolphin = new Dolphin("돌고래", 3.0f, 230.0f, 45.0f);

            pig.Speak();
            cow.Speak();
            flyChicken.Speak();
            notFlyChicken.Speak();
            dolphin.Speak();

            Console.WriteLine();

            pig.Eat();
            cow.Eat();
            flyChicken.Eat();
            notFlyChicken.Eat();
            dolphin.Eat();

            Console.WriteLine();

            pig.Info();
            Console.WriteLine();

            cow.Info();
            Console.WriteLine();

            flyChicken.Info();
            Console.WriteLine();

            notFlyChicken.Info();
            Console.WriteLine();

            dolphin.Info();
            Console.WriteLine();
        }
    }
}
