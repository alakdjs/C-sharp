using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509151701_UpCasting
{
    class Parent
    {
        private int _value;

        public Parent(int value)
        {
            _value = value;
        }

        public void Print()
        {
            Console.WriteLine($"Parent::Print() value = {_value}");
        }
    }

    class Child : Parent
    {
        private int _value2;

        public Child(int value1, int value2)
            : base(value1)
        {
            _value2 = value2;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Child::Print() _value2 = {_value2}");
        }
    }

    class Child2 : Parent
    {
        private int _value2;

        public Child2(int value1, int value2)
            : base(value1)
        {
            _value2 = value2;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Child::Print() _value2 = {_value2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent parent1 = new Child(10, 200); // Upcasting : 자식 객체를 부모의 타입으로 받는 것.

            parent1.Print();    // Parent 타입의 Print() 메소드가 호출
                                // parent1._value

            Parent parent2 = new Child2(20, 300);

            parent2.Print(); // Parent 타입의 Print() 메소드 호출

            // Child child = new Parent(20); // 다운캐스팅 : 부모 타입을 자식 타입에 대입하는 것
            // 다운 캐스팅은 원칙적으로 허용이 되지 않습니다.

            Child cchild = (Child)parent1;  // 이런 형태의 다운캐스팅은 허용됨.
                                            // parent1이 가르키고 있던게 Child 타입이었기 때문에

            cchild.Print(); // Child Print 함수가 호출

            Child2 child2 = (Child2)parent2;
            child2.Print();

        }
    }
}
