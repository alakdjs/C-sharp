using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509041701_Operator4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("할당연산자 = ");
            int a = 20;
            int b = 30;
            float c = 1.2f;

            a = b; // 정수형 변수의 값을 정수형 변수에 할당
            Console.WriteLine($"a = {a}");

            // C#은 DataType의 처리가 엄격합니다.
            // 다른 타입간에는 명시적으로 형변환을 해야합니다.
            a = (int)c; // 실수값을 정수형변수에 대입할때는 반드시 형변환을 해야 합니다.
            Console.WriteLine($"a = {a}");

            c = a;  // 정수값을 실수형변수에 대입할때는 형변환을 하지 않아도 됩니다.
            Console.WriteLine($"c = {c}");

            // 할당연산자는 축약형을 지원합니다.
            a = a + 1;
            a += 1; // 축약형
            Console.WriteLine($"a = {a}");

            a = a - b;
            a -= b; // 축약형.
            Console.WriteLine($"a = {a}");
        }
    }
}
