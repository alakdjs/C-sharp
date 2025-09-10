using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509091701_LocalFunction
{
   class Student
    {
        private string _name; // 일반 멤버필드
        private int _grade;
        private int _classNum;

        public static int Count = 0;    // 정적 멤버 필드

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
                //Student st0 = CreateStudent("monster1", 3, 11);
                CreateStudent2("monster1", 3, 11);

                Console.WriteLine($"학생수는: {Student.Count}");


                {
                    //Student st1 = CreateStudent("monster2", 2, 10);
                    CreateStudent2("monster2", 2, 10);
                    Console.WriteLine($"학생수는: {Student.Count}");
                    {

                        CreateStudent2("monster3", 1, 7);
                        Console.WriteLine($"학생수는: {Student.Count}");

                    }
                    GC.Collect();
                    Console.Read(); // 멈춤                       
                    Console.WriteLine($"학생수는: {Student.Count}");

                }
                GC.Collect();
                Console.Read(); // 멈춤                       
                Console.WriteLine($"학생수는: {Student.Count}");

            }
            Student st3 = CreateStudent("monster4", 3, 5);
            GC.Collect();
            Console.Read(); // 멈춤                       
            Console.WriteLine($"학생수는: {Student.Count}");

        }

    }
}
