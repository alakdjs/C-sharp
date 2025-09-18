using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509171508_MultiInterface
{
    // 멀티 인터페이스

    public abstract class Run // 추상 클래스
    {
        public abstract void Walk();  // 추상 메소드
    }

    public class Human : Run
    {
        public override void Walk()
        {
            Console.WriteLine($"사람이 걷는다.");
        }
    }

    class A
    {
        private int _value;

        public int Value { get { return _value; } set { _value = value; } }
    }

    interface IRunnable
    {
        int Speed { set; get; } // 자동구현 프로퍼티
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public int Speed { set; get; }

        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();

            car.Run();
            car.Fly();

            IRunnable runnable = car;
            runnable.Run();

            IFlyable flyable = car;
            flyable.Fly();

            Human human = new Human();
            human.Walk();
        }
    }
}
