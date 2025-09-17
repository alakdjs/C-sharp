using System;

namespace partialTest
{
    public partial struct A
    {
        public int _value;
    }
}

namespace partialTest
{

    public partial struct A
    {
        public int _value2;

        public void ShowInfo()
        {
            Console.WriteLine($"A = _value: {_value}, _value2: {_value2}");
        }
    }
}

namespace _202509161259_Partial_class
{
    /*
     * partial 클래스는 클래스, 구조체 등 두개 이상의 파일로 분할해서 개발하는 방법 제공합니다.
     * 하나의 클래스를 여러 파일에 걸려서 작성할 수 있습니다.
     * 1. 동일한클래스의 모든 부분이 동일한 접근 수준을 가져야합니다.
     * 2. 한 부분에 선언된 필드는 다른 부분에서 접근할 수 있습니다.
     * 3. 모든 부분은 같은 네임스페이스 안에 있어야 합니다.
     * 
     */
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();


            partialTest.A a;

            a._value = 20;
            a._value2 = 30;

            a.ShowInfo();
        }
    }
}
