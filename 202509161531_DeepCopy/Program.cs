using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509161531_DeepCopy
{
    class Wheel
    {
        float _size;
        float _depth;
        float _height = 0;

        public float Height
        {
            set { _height = value;  }
        }

        public Wheel(float size, float depth)
        {
            _size = size;
            _depth = depth;
        }

        public Wheel Copy()
        {
            return (Wheel)this.MemberwiseClone();
        }

        public void Info()
        {
            Console.WriteLine($"휠사이즈: {_size}, 휠폭: {_depth}, 높이: {_height}");
        }
    }

    class Engine
    {
        string _type;

        public Engine(string type)
        {
            _type = type;
        }

        public Engine Copy()
        {
            return (Engine)this.MemberwiseClone();
        }

        public void Info()
        {
            Console.WriteLine($"엔진타입: {_type}");
        }
    }

    class Car
    {
        public float _speed;
        public float _capacity;
        public Wheel _wheel;
        public Engine _engine;

        public Car(float speed, float capacity, float size, float depth, string type)
        {
            _speed = speed;
            _capacity = capacity;
            _wheel = new Wheel(size, depth);
            _engine = new Engine(type);
        }

        public Car DeepCopy()
        {
            Car t = (Car)this.MemberwiseClone();

            t._wheel = _wheel;
            t._engine = _engine;

            return t;
        }

        public void Info()
        {
            Console.WriteLine($"속도: {_speed}, 용량: {_capacity}");
            _wheel.Info();
            _engine.Info();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(200.0f, 60.0f, 29, 30, "4기통");

            car.Info();
            // Car class에 DeepCopy 메소드를 만들고 DeepCopy메소드 작동해서
            // 객체를 생성하고 생성된 값을 출력해보세요...

            Car car2 = car.DeepCopy();
            Console.WriteLine();

            car._wheel.Height = 1000;
            car.Info();
            Console.WriteLine();
            car2.Info();
        }
    }
}
