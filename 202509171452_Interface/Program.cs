using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509171452_Interface
{
    // interface
    // 행동규약
    // 1. 인터페이스는 메소드, 이벤트, 인덱서, 프로퍼티만 가질 수 있습니다.
    // 2. 접근제어자를 사용할 수 없고, 모든 겂이 public 으로 선언됩니다.
    // 3. 구현부가 없습니다.
    // 4. interface를 추가한 클래스는 interface에 선언된 메소드를 구현할 책임을 갖습니다.
    // 5. interface는 다중으로 추가할 수 있습니다.

    interface Move
    {
        void Start();
        void Stop();
        void Acceleration();
    }

    class Car : Move
    {
        private string _modelName;
        private float _maxSpeed;

        public Car(string modelName, float maxSpeed)
        {
            _modelName = modelName;
            _maxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine($"{_modelName}이 출발합니다.");
        }

        public void Stop()
        {
            Console.WriteLine($"{_modelName}이 정지합니다.");
        }

        public void Acceleration()
        {
            Console.WriteLine($"{_modelName}이 가속을 합니다.");
        }
    }

    class Ship : Move
    {
        private string _name;
        private float _maxSpeed;

        public Ship(string name, float maxSpeed)
        {
            _name = name;
            _maxSpeed = maxSpeed;
        }

        public void Start()
        {
            Console.WriteLine($"{_name}이 출항합니다.");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name}이 입항합니다.");
        }

        public void Acceleration()
        {
            Console.WriteLine($"{_name}이 가속합니다.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("GV80", 280.0f);
            Ship ship = new Ship("쾌속선", 50.0f);

            Move move = car;

            move.Start();
            move.Stop();
            move.Acceleration();

            move = ship;

            move.Start();
            move.Stop();
            move.Acceleration();

            Console.WriteLine();

            Move[] moveArray = new Move[] {car, ship};

            foreach(var obj in moveArray)
            {
                obj.Start();
                obj.Acceleration();
                obj.Stop();

                Console.WriteLine();
            }
        }
    }
}
