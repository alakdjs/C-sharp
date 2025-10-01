using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510011644_Delegate_Chain
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string _name;

        public EventListener(string name)
        {
            _name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{_name}.SomethingHappend: {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();

            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;    // 이벤트 구독
            notifier.EventOccured += listener2.SomethingHappend;    // 이벤트 구독
            notifier.EventOccured += listener3.SomethingHappend;    // 이벤트 구독

            notifier.EventOccured("You'v got a mail");
            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;    // listener2 구독 해지
            notifier.EventOccured("Download complete!!");
            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend)
                + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected!!");
            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
            notifier.EventOccured("Fire!!");
            Console.WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
            notifier.EventOccured("RPG!!");

        }
    }
}
