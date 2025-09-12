using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509101713_StaticMember
{
    class Student
    {
        private string _name; // 일반 멤버필드
        private int _grade;
        private int _classNum;

        private static int Count = 0;    // 정적 멤버 필드


        // 정적메소드는 객체에 속해있지 않습니다.
        // 클래스에 속해있습니다.
        // 클래스 통해서만 접근이 가능합니다.
        static public int GetCount() // 정적메소드
        {
            return Count;
        }

        static public void SetCount(int value)
        {
            // 정적메소드 안에서 멤버필드에 접근하면 안됨
            // 정적메소드는 객체의 생성과는 무관합니다
            // 멤버필드는 객체가 생성되어야지만 메모리에 위치하기 때문에
            // 정적메소드에서 멤버필드를 접근하면 안됨.
            // _grade = 10; X
            Count = value;
        }

        public Student(string name, int grade, int classNum) // 인자를 받는 생성자
        {
            _name = name;
            _grade = grade;
            _classNum = classNum;

            Count++; // 정적멤버필드 Count의 값을 1증가
        }

        ~Student()
        {
            Console.WriteLine("Student 소멸자");
            Count--;
        }

        void ShowInfo()
        {
            Console.WriteLine($"이름: {_name}\n학년: {_grade}\n반: {_classNum}\n\n");
        }
    }


    class Program
    {
        static Student CreateStudent(string name, int grade, int classNum)
        {
            Student st = new Student(name, grade, classNum);

            return st;
        }

        static void CreateStudent2(string name, int grade, int classNum)
        {
            Student st = new Student(name, grade, classNum);

        }


        static void ProcessStudent()
        {
            //CreateStudent();

            GC.Collect();   // garbage collector에게 메모리 정리요청
        }

        static void Main(string[] args)
        {

            {
                // 정적멤버필드는 클래스를 통해서만 접근할 수 있습니다.
                // 접근제어자의 영향을 받습니다.
                Student st0 = CreateStudent("monster1", 3, 11);

                // st0.Count;
                //st0.GetCount();

                CreateStudent2("monster1", 3, 11);

                Console.WriteLine($"학생수는: {Student.GetCount()}");

                {
                    // Student st1 = CreateStudent("monster2", 2, 10);
                    CreateStudent2("monster2", 2, 10);
                    Console.WriteLine($"학생수는: {Student.GetCount()}");
                    {

                        CreateStudent2("monster3", 1, 7);
                        Console.WriteLine($"학생수는: {Student.GetCount()}");

                    }
                    GC.Collect();
                    Console.Read(); // 멈춤                       
                    Console.WriteLine($"학생수는: {Student.GetCount()}");

                }
                GC.Collect();
                Console.Read(); // 멈춤                       
                Console.WriteLine($"학생수는: {Student.GetCount()}");


            }
            Student st3 = CreateStudent("monster4", 3, 5);
            GC.Collect();
            Console.Read(); // 멈춤                       
            Console.WriteLine($"학생수는: {Student.GetCount()}");

        }

    }
}

