using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509191515_Polymorphism_CoffeeShop
{
    // 다형성: 동일한 메세지에 다향한 반응을 보이는 것
    // 1. 오버로딩 (overloading) : 동일한 이름의 메소드를 만드는 것
    // 2. 오버라이드 (override) : 상속관계에서 부모의 가상메소드를 자식이 재정의하는 것

    // 개발자가 되었습니다.
    // 커피숖 관리 프로그램을 제작해달라는 의뢰를 받았습니다.
    // 먼저 뭐 부터 해야 하나요?
    // 커피숖에가서 커피한잔 시키고.
    // 자리에 앉아서 커피숖의 업무흐름을 파악해야합니다.
    // 커피숖에 어떤 역할(role)과 어떤 책임(responsibility)이 있는 파악해야 합니다.

    // 커피숖에는 어떤 역할(role)이 있나요?
    // guest, 알바생, 직원, 매니저, 주문받는사람 (Cashier), 바리스타(Barista)

    // Barista(음료를 만듦), Cashier(주문을 받음, 주문을 전달, 음료전달), guest(주문을 함)

    public enum DrinkType
    {
        Coffee,
        Latte,
        Tea,
        Ade
    }

    // 추상메소드를 하나라도 가지고 있는 크래스를 추상클래스라고 합니다.
    // 추상클래스는 자신의 객체를 만들수 없습니다.
    // 대신에 자신에게서 상속받는 자식클래스는 자신의 추상메소드를 반드시
    // 구현하도록 강제하는 능력이 생깁니다.

    abstract public class Drink
    {
        private DrinkType _type;
        private string _name;

        public virtual string Name { get => _name; }

        public DrinkType Type { get => _type; }

        public Drink(DrinkType type)
        {
            _type = type;
            _name = "음료";
        }

        public abstract void MakeADrink(); // 추상 메소드
        /*
        public virtual void MakeADrink() // 일반메소드 -> 가상메소드
        {
            Console.WriteLine($"음료를 만듭니다.");
        }
        */
    }

    public class Coffee : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Coffee()
            : base(DrinkType.Coffee)
        {
            _name = "커피";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"커피를 만듭니다.");
        }
    }

    public class Latte : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Latte()
            : base(DrinkType.Latte)
        {
            _name = "라떼";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"라떼를 만듭니다.");
        }
    }

    public class Tea : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Tea()
            : base(DrinkType.Tea)
        {
            _name = "차";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"차를 만듭니다.");
        }
    }

    public class Ade : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Ade()
            : base(DrinkType.Ade)
        {
            _name = "에이드";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"에이드를 만듭니다.");
        }
    }

    public class Cola : Drink
    {
        private string _name;

        public override string Name { get => _name; }

        public Cola()
            : base(DrinkType.Ade)
        {
            _name = "콜라";
        }

        public override void MakeADrink()
        {
            Console.WriteLine($"콜라를 만듭니다.");
        }
    }

    class Barista
    {
        public void MakeADrink(Drink drink)
        {
            Console.WriteLine($"음료에게 음료 제작 요청을 합니다.");
            drink.MakeADrink();
        }
    }

    class Cashier
    {
        private Barista _bari;  // 포함, agreggation(참조)

        public Cashier(Barista bari)
        {
            _bari = bari;
        }

        public void OrderedDrink(Drink drink)
        {
            Console.WriteLine($"{drink.Name}를 주문받습니다.");
            _bari.MakeADrink(drink);
        }
    }

    class Guest
    {
        public void OrderedDrink(Cashier cashier, Drink drink) // 의존적관계(dependency), 일시적관계
        {
            Console.WriteLine($"{drink.Name}를 주문합니다.");
            cashier.OrderedDrink(drink);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // 추상클래스는 자신의 객체를 만들 수 없습니다.
            /*
            Drink drink = new Drink();
            drink.MakeADrink();
            */

            Barista bari = new Barista();
            Cashier cashier = new Cashier(bari);
            Guest guest = new Guest();

            guest.OrderedDrink(cashier, new Coffee());
            Console.WriteLine();

            guest.OrderedDrink(cashier, new Latte());
            Console.WriteLine();

            guest.OrderedDrink(cashier, new Tea());
            Console.WriteLine();

            guest.OrderedDrink(cashier, new Ade());
            Console.WriteLine();

            guest.OrderedDrink(cashier, new Cola());
            Console.WriteLine();
        }
    }
}
