using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509151605_object_class
{
    // Object class에 기본적으로 제공되어지는 Method가 있습니다.

    // public static bool Equals(Object? objA, Object? objB);   // 참조형객체의 경우 참조값을 비교
    // 값타입 객체의 경우 값비교합니다.
    // public virtual bool Equals(Object? obj);

    // public virtual int GetHashCode();    // 특정 인스턴스를 고유하게 식별할 수 있는
    // 4byte int형 코드값을 반환한다.
    // public Type GetType();   // 인스턴스에서 타입을 얻어낸다.
    // public virtual string? ToString();   // 기본적으로 해당 인스턴스가 속한 클래스의 
    // 전체이름을 반환한다.
    // 각 클래스들이 override해서 각 클래스마다 다르게 작동
    // 할 수 있습니다.

    // protected Object MemberwiseClone(); 객체를 복사할때 사용.


    // Object class
    // C#에서는 모든 클래스는 최상위 클래스(superset)인 Object에서 상속을 받습니다.
    // 기본 제공 데이타 타입이나 사용자 정의 클래스도 자동으로 Object 클래스에서 상속됩니다.

    class A
    {
        public int _value;

        public A(int value)
        {
            _value = value;
        }
    }

    class B : A
    {
        public B(int value)
            : base(value) { }
    }

    class C : B
    {
        public C(int value)
            : base(value) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object
            A aObj = new A(10);
            B bObj = new B(20);
            C cObj = new C(30);

            Console.WriteLine($"aObj.toString() = {aObj.ToString()}");
            Console.WriteLine($"aObj.toString() = {bObj.ToString()}");
            Console.WriteLine($"aObj.toString() = {cObj.ToString()}");

            Console.WriteLine($"aObj.toString() = {aObj.GetType().FullName}");
            Console.WriteLine($"aObj.toString() = {bObj.GetType().IsClass}");
            Console.WriteLine($"aObj.toString() = {cObj.GetType().IsArray}");

            A aaObj = new A(10);

            A refaaObj = aaObj;

            bool isEqual = aaObj.Equals(aObj);

            Console.WriteLine($"isEqual = {isEqual}");

            isEqual = aaObj.Equals(refaaObj);

            Console.WriteLine($"isEqual = {isEqual}");

            isEqual = object.Equals(aaObj, aObj);
            Console.WriteLine($"isEqual = {isEqual}");

            // 값타입 비교
            int a = 3;
            int b = 3;

            bool ret = a.Equals(b);

            Console.WriteLine($"ret = {ret}");
        }
    }
}
