using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509251518_AnonymousType
{
    class Test
    {
        int value;
        int value2;
    }

    // Anonymous Type(익명타입)
    // new {...}를 사용해야 함.
    // 익명 타입은 명시적으로 클래스를 정의하지 않고 임시로 타입을 생성할 수 있는 기능
    // 컴파일러가 내부적으로 클래스를 생성하므로, 일반적으로 참조 타입과 동일하게 동작
    // 변수를 할당 시 var 타입을 사용
    // 읽기 전용

    class Program
    {
        public static (bool isSuccess, float prob) ProbabilityCalculator(float prob)
        {
            bool isSuccess = true;
            float value = 2.3f * prob;

            return (isSuccess, value);
        }

        static void Main(string[] args)
        {
            var a = new { Name = "Monster", Age = 100 };
            // a.Name = "monster2"; // 읽기만 가능
            Console.WriteLine("Name:{0}, Age: {1}", a.Name, a.Age);

            var b = new { Subject = "Mathmetics", Scores = new int[] { 90, 80, 70, 60 } };

            Console.WriteLine("Subject:{0}, Scores:", b.Subject);
            foreach (var scores in b.Scores)
            {
                Console.WriteLine("{0} ", scores);
            }

            Console.WriteLine();

            var data = ProbabilityCalculator(10.0f);

            Console.WriteLine($"data = {data}");
        } 
    }
}
