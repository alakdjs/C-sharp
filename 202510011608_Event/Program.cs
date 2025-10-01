using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510011608_Event
{
    // event
    // 클래스 내에 특정한 event(사건)발생했을때 외부의 이벤트 구독자(subscriber)에게 
    // 알려주는 기능을 합니다.
    // 이벤트는 event라는 키워드를 사용하여 표시하고 클래스내에서 일종의 필드처럼 정의됩니다.
    // event는 특수한 형태의 delegate
    // event에 method을 추가할때는 +=, 제거시에는 -=, =(할당은 사용이 안됨)

    class MyTimer
    {
        public delegate void Tick(DateTime now);
        public event Tick Ticked; // MyTimer 클래스 내부에서 호출이 가능, event
        private int interval;
        public Tick Ticked2; // 일반 delegate

        public MyTimer(int interval)
        {
            this.interval = interval;
        }

        public void start()
        {
            DateTime before = DateTime.Now; // 현재 시간

            while (true)
            {
                DateTime current = DateTime.Now;

                if(before.AddSeconds(interval) < current)
                {
                    Ticked(current); // 이벤트는 클래스 내부에서만 호출이 가능
                    before = current;
                }
            }
        }
    }

    class Monster
    {
        public void TimeEllapsed(DateTime current)
        {
            Console.WriteLine("Monster Time Ellapsed : {0}", current.ToLongTimeString());
        }
    }

    class Program
    {
        static void TimeEllapsed(DateTime current)
        {
            Console.WriteLine("Time Ellapsed : {0}", current.ToLongTimeString());
        }

        static void TimeEllapsed2(DateTime current)
        {
            Console.WriteLine("Time Ellapsed2 : {0}", current.ToLongTimeString());
        }

        static void TimeEllapsed3(DateTime current)
        {
            Console.WriteLine("Time Ellapsed3 : {0}", current.ToLongTimeString());
        }

        static void Main(string[] args)
        {
            MyTimer timer = new MyTimer(5);

            /*
            // timer에 이벤트 메소드를 추가.
            timer.Ticked += new MyTimer.Tick(TimeEllapsed);
            timer.Ticked += new MyTimer.Tick(TimeEllapsed2);

            Monster mons = new Monster();
            timer.Ticked += new MyTimer.Tick(mons.TimeEllapsed);

            timer.start();
            */

            timer.Ticked += new MyTimer.Tick(TimeEllapsed3);
            timer.Ticked(DateTime.Now); // event는 객체 외부에서 호출할 수 없습니다.
                                        // 객체 내부에서만 호출이 가능합니다.


            timer.Ticked2 += new MyTimer.Tick(TimeEllapsed3);
            timer.Ticked2(DateTime.Now);
        }

    }
}
