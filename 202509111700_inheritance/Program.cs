using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace _202509111700_inheritance
{
    // 상속
    // 일반화 (generalization)

    // 동물농장 시뮬레이션
    // 돼지, 소, 닭

    class Pig
    {
        // 속성
        private string _name;   // 이름
        private float _weight; // 몸무게
        private float _height;  // 신장
        private float _age; // 나이
        private float _healthRate;  // 건강지수

        public Pig(string name, float weight, float height, float age, float healthRate)
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

    class Cow
    {
        private string _name;
        private float _weight;
        private float _height;
        private float _age;
        private float _healthRate;

        public Cow(string name, float weight, float height, float age, float healthRate)
        {
            _name = name;
            _weight = weight;
            _height = height;
            _age = age;
            _healthRate = healthRate;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name}가 음매합니다.");
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

    class Chicken
    {
        string _name;
        float _weight;
        float _height;
        float _age;
        float _healthRate;
        bool _isFly;

        private void Fly()
        {
            Console.WriteLine($"{_name}이 납니다.");
        }

        private string GetKind()
        {
            if(_isFly)
            {
                return "나는 닭";
            }
            else
            {
                return "못나는 닭";
            }
        }

        public Chicken(string name, float weight, float height, float age, float healthRate, bool isFly)
        {
            _name = name;
            _weight = weight;
            _height = height;
            _age = age;
            _healthRate = healthRate;
            _isFly = isFly;
        }

        public void Speak()
        {
            Console.WriteLine($"{_name}이 꼬끼오합니다.");
        }

        public void Run()
        {
            if (_isFly)
            {
                Fly();
            }
            else
            {
                Console.WriteLine($"{_name}이 뜁니다.");
            }
        }

        public void Eat()
        {
            Console.WriteLine($"{_name}이 먹습니다.");
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
            Console.WriteLine($"이름: {_name}\n몸무게: {_weight}\n신장: {_height}\n나이: {_age}\n건강지수: {GetHealth()}\n종류: {GetKind()} ");
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

            pig.Speak();
            cow.Speak();
            flyChicken.Speak();
            notFlyChicken.Speak();

            Console.WriteLine();

            pig.Run();
            cow.Run();
            flyChicken.Run();
            notFlyChicken.Run();

            Console.WriteLine();

            pig.Info();
            Console.WriteLine();

            cow.Info();
            Console.WriteLine();

            flyChicken.Info();
            Console.WriteLine();

            notFlyChicken.Info();
        }
    }
}
