using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510011532_Lambda
{
    // 람다 표현식은 C#에서 간결한 형태로 익명함수로 작성하는 방법을 제공
    // 람다 표현식은 주로 delegate를 사용하여 익명함수를 정의할 때 사용.

    delegate int Func(int a, int b);    // 대리자, 함수 포인터

    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static int calculator(Func func, int a, int b)
        {
            return func(a, b);
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;

            int ret = calculator((int aa, int bb) => a - b, a, b);
            
            Console.WriteLine($"{a} - {b} = {ret}");
            Console.WriteLine($"{a} - {b} = {calculator((int aa, int bb) => a - b, a, b)}");
            Console.WriteLine($"{a} x {b} = {calculator((int aa, int bb) => a * b, a, b)}");

            // 익명메소드
            Func fa = (int aa, int bb) => a + b;

            ret = calculator((int aa, int bb) =>
            {
                int temp = 0;
                temp = a + b;
                return temp;
            }, a, b);

            for(int i = 0; i < 100; i++)
            {
                // 반복문 안에서는 람다식을 사용하지 않는 것이 좋습니다.
                // 람다식은 클래스를 생성하고 그 클래스의 인스턴스를 생성하고 처리하기 때문에
                // 메모리 사용량이 증가할 수 있습니다.
                /*
                ret = calculator((int a, int b) =>
                {
                    int temp = 0;
                    temp = a + b;
                    return temp;
                }, i, i + 2);
                */
                ret = calculator(add, i, i + 2);
            }

        }
    }
}
