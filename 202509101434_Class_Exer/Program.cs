using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509101434_Class_Exer
{
    // 손흥민을 축구게임에서 필요로 하는 데이타를 뽑고
    // 클래스를 만들고 객체를 생성해서 데이타를 저장하고 출력해보세요....

    class SoccerSon
    {
        private int _age;
        private string _name;
        private string _position;
        private float _weight;
        private int _speed;
        private int _num;
        private string _skill;

        public int Age
        {
            set{ _age = value; }
            get => _age;
        }

        public string Name
        {
            set { _name = value; }
            get => _name;
        }

        public string Position
        {
            set { _position = value; }
            get => _position;
        }

        public float Weight
        {
            set { _weight = value; }
            get => _weight;
        }

        public int Speed
        {
            set { _speed = value; }
            get => _speed;
        }

        public int Num
        {
            set { _num = value; }
            get => _num;
        }

        public string Skill
        {
            set { _skill = value; }
            get => _skill;
        }

        // 생성자는 클래스명과 동일한 이름의 메소드입니다.
        // 리턴값은 없습니다.
        // 생성자는 반드시 필요하기 때문에 생성자 없으면 컴파일러는 기본생성자를 자동으로 만들어 넣어줍니다.
        // 기본생성자 인자를 받지 않는 생성자

        // 생성자에서 주로 하는 작업은
        // 멤버필드의 초기화 작업이나 객체가 생성되기위해 선행되어야 하는 작업을 생성자합니다.
        // 기본생성자, 인자를 받는 생성자, 복사생성자

        // 인자를 받는 생성자가 하나라도 있는 경우
        // 컴파일러는 기본생성자를 자동으로 만들어주지 않습니다.
        // 기본생성자 만들고 안만들고는 개발자의 몫입니다.
        // 기본 생성자가 없다는 것은 어떤 의미인가요?


        public SoccerSon()  // 기본생성자
        {
            Console.WriteLine($"SoccerSon 기본 생성자");
        }

        public SoccerSon(int age, string name, string position, float weight, int speed, int num, string skill)
        {
            Console.WriteLine($"인자를 7개 받는 생성자");
            _age = age;
            _name = name;
            _position = position;
            _weight = weight;
            _speed = speed;
            _num = num;
            _skill = skill;
        }

        public SoccerSon(string name)
        {
            Console.WriteLine($"인자를 1개 받는 생성자");
            _age = 0;
            _name = name;
            _position = "없음";
            _weight = 0;
            _speed = 0;
            _num = 0;
            _skill = "없음";
        }

        public void Run()
        {
            Console.WriteLine($"{_speed} 속도로 달립니다.");
        }

        public void Shoot()
        {
            Console.WriteLine($"{_skill} 로 상대 수비를 뚫고 공을 찹니다.");
        }

        public void Info()
        {
            Console.WriteLine($"나이: {_age}");
            Console.WriteLine($"이름: {_name}");
            Console.WriteLine($"포지션: {_position}");
            Console.WriteLine($"몸무게: {_weight}");
            Console.WriteLine($"스피드: {_speed}");
            Console.WriteLine($"등번호: {_num}");
            Console.WriteLine($"스킬: {_skill}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 객체를 생성할 때 자동으로 호출되어지는 메소드가 있습니다.
            // 이 메소드(method)가 호출되어야지만 온전한 객체가 생성됩니다.
            // 이 메소드를 생성자라고 합니다.

            SoccerSon son = new SoccerSon();
            son.Age = 33;
            son.Name = "손흥민";
            son.Position = "striker";
            son.Weight = 78.5f;
            son.Speed = 86;
            son.Num = 7;
            son.Skill = "점멸";

            son.Run();
            son.Shoot();

            son.Info();
            Console.WriteLine();

            SoccerSon son2 = new SoccerSon(333, "손흥민2", "스트라이커", 788.55f, 866, 77, "오버헤드킥");
            son2.Info();
            Console.WriteLine();

            SoccerSon son3 = new SoccerSon("손흥민3");
            son3.Info();
        }
    }
}
