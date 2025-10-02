using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021453_Null_Operator
{
    // null operator

    class Car
    {
        public int? _weight = null; // Nullable
        public void Move()
        {
            Console.WriteLine($"Car가 움직입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            car = null;

            if(car != null)
            {
                car.Move();
            }
            else
            {
                Console.WriteLine($"car가 null입니다.");
            }

            // Null Conditional operator
            car?.Move();

            car = new Car();

            car._weight = 10;

            // ?? Null 병합연산자
            int weight = car._weight ??= 0;

            Console.WriteLine($"car._weight = {weight}");

            car._weight = null;

            weight = car._weight ??= 0;
            Console.WriteLine($"car._weight = {weight}");

            // Nullable
            int a;
            // a = null; // 값타입은 null 대입이 안됨..

            int? b; // Nullable

            b = null;

            Console.WriteLine($"b에 값이 {b.HasValue}");
            Console.WriteLine($"b != null {b != null}");
            
            b = 3;
            Console.WriteLine($"b에 값이 {b.HasValue}");
            Console.WriteLine($"b != null {b != null}");
            Console.WriteLine($"b.value = {b.Value}");
        }
    }
}
