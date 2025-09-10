using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509101647_CopyConstructor
{
    class A
    {
        public int _value;

        // 기본 생성자
        public A()
        {
            Console.WriteLine("A Type 기본 생성자");
        }

        // 인자를 받는 생성자
        public A(int value)
        {
            Console.WriteLine("A Type 인자를 받는 생성자");
            _value = value;
        }

        // 복사 생성자
        public A(A value)
        {
            _value = value._value;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"A::_value = {_value}");
        }
    }

    class B
    {
        public A _avalue;

        public B(A value)
        {
            _avalue = new A(value); // 깊은 복사
        }

        ~B() // 소멸자
        {
            Console.WriteLine("B::소멸자");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"B::_value = {_avalue._value}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();  // 기본 생성자
            a.ShowInfo();

            A a1 = new A(10);   // 인자를 1개 받는 생성자
            a1.ShowInfo();

            // C#에서는 복사생성자를 자동으로 만들어주지 않습니다.
            // 필요시에 직접 만들어야 합니다.

            A a2 = new A(a);    // 자신과 같은 타입의 객체를 인자로 받는 생성자를 복사 생성자.
            a2.ShowInfo();
            Console.WriteLine();

            B b = new B(a);

            b.ShowInfo();
            a._value = 100;
            Console.WriteLine();

            a.ShowInfo();

            b.ShowInfo();
        }
    }
}
