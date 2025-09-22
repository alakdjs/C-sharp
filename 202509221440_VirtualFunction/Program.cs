using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;

namespace _202509221440_VirtualFunction
{
    class Parent
    {
        public void Print() // 일반메소드
        {
            Console.WriteLine("Parent::Print");
        }

        public virtual void VirtualPrint() // 가상메소드
        {
            Console.WriteLine("Parent::VirtualPrint");
        }

        public virtual void VirtualPrint2() // 가상메소드
        {
            Console.WriteLine("Parent::VirtualPrint2");
        }

        public virtual void VirtualPrint3() // 가상메소드
        {
            Console.WriteLine("Parent::VirtualPrint2");
        }
    }

    class Child : Parent
    {
        public new void Print() // 메소드 Hiding
        {
            Console.WriteLine("Child::Print");
        }

        public override void VirtualPrint()
        {
            Console.WriteLine("Child::VirtualPrint");
        }
    }

    class Child2 : Parent
    {
        public new void Print() // 메소드 Hiding
        {
            Console.WriteLine("Child2::Print");
        }

        public override void VirtualPrint2()
        {
            Console.WriteLine("Child2::VirtualPrint2");
        }
    }

    class Child3 : Parent
    {
        public override void VirtualPrint3()
        {
            Console.WriteLine("Child3::VirtualPrint3");
        }
    }

    class Program
    {
        // 일반 메소드 호출
        static void CallPrint(Parent value)
        {
            // 인자를 받는 참조형 변수의 타입이
            // Parent타입이어서 무조건 Parent 타입의 Print() 메소드가 호출됩니다.
            // 컴파일타임(실행파일을 만들때)Parent의 Print 메소드가 호출되도록
            // 코드가 만들어집니다.
            // 컴파일타임에 바인딩이 되는 것을 정적바인딩히라고 합니다.

            value.Print();
            // value.Parent.Print(); // 정적바인딩
        }

        static void CallPrint(Child value)
        {
            value.Print();
            // value.Child.Print(); // 정적바인딩
        }

        static void CallPrint(Child3 value)
        {
            // 인자를 받는 타입이 Child3타입이나
            // Child3에 Print 일반메소드 Method Hiding하지않아서
            // 이 경우에는 Parent의 Print 메소드가 호출 됩니다.
            value.Print();
            // value.Parent.Print(); // 정적바인딩
        }

        // 가상 메소드 호출
        static void CallVirtualPrint(Parent value)
        {
            // 가상함수는 컴파일 타임에 어느 타입의
            // 가상함수가 호출될지 결정할 수가 없습니다.
            // 결정을 유보
            // 프로그램이 실행중에 어디의 가상함수가 실행될 지 결정이 됩니다.
            // 동적 바인딩.

            value.VirtualPrint();
            // value.vt[0]();
        }

        // 가상 메소드 호출
        static void CallVirtualPrint2(Parent value)
        {
            value.VirtualPrint2();
        }

        // 클래스가 가상메소드를 하나라도 가지고 있으면
        // 가상메소드 테이블이 만들어집니다.
        // 가상메소드 테이블은 가상메소드의 주소값을 저장하는 배열입니다.
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            Child2 child2 = new Child2();
            Child3 child3 = new Child3();

            // 일반 메소드 호출
            CallPrint(parent);
            CallPrint(child);
            CallPrint(child2);
            CallPrint(child3);

            // 가상 메소드 호출
            CallVirtualPrint(parent);
            CallVirtualPrint(child);
            CallVirtualPrint(child2);
            CallVirtualPrint(child3);
        }
    }
}
