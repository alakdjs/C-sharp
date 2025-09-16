using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509161512_ShallowCopy
{
    /// <summary>
    /// 얕은 Copy
    /// </summary>
    
    class Top
    {
        public int a = 100;
        public int b = 200;

        public Top(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }

    class Child
    {
        public int age = 10;
        public int height = 20;
        public Top grand;

        public Child(int age, int height)
        {
            this.age = age;
            this.height = height;

            grand = new Top(age, height);
        }

        public Child(Child child)   // 복사 생성자
        {
            this.age = child.age;
            this.height = child.height;
            this.grand = child.grand;
        }

        public Child DeepCopy()
        {
            Child child = new Child(this.age, this.height);
            child.grand = new Top(this.grand.a, this.grand.b);

            return child;
        }

        public Child Copy()
        {
            return (Child)this.MemberwiseClone();

            /*
            Child ret = new Child(this.age, this.height);
            ret.grand = this.grand;

             return ret;
             */
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child(17, 182); // 인자를 받는 생성자
            Child child2 = new Child(child);  // 복사생성자

            bool ret = object.ReferenceEquals(child, child2);
            Console.WriteLine($"child == child2 ? ret = {ret}");

            ret = object.ReferenceEquals(child.grand, child2.grand);
            Console.WriteLine($"child.grand == child2.grand ? ret = {ret}");

            Child child3 = child.Copy();    //Shallow Copy
            ret = object.ReferenceEquals(child, child3);
            Console.WriteLine($"child == child3 ? ret = {ret}");

            ret = object.ReferenceEquals(child.grand, child3.grand);
            Console.WriteLine($"child.grand == child2.grand ? ret = {ret}");

            Child child4 = child.DeepCopy();  // DeepCopy
            ret = object.ReferenceEquals(child, child4);
            Console.WriteLine($"child == child4 ? ret = {ret}");

            ret = object.ReferenceEquals(child.grand, child4.grand);
            Console.WriteLine($"child.grand == child4.grand ? ret = {ret}");

        }
    }
}
