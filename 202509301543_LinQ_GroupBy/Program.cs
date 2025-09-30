using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301543_LinQ_GroupBy
{
    public class Student
    {
        public string ID { get; set; } // 학생을 식별하는 키
        public string Name { get; set; } // 학생의 이름
        public int Grade { get; set; } // 학년
        public int Class { get; set; } // 반

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                // 1학년 1반
                new Student { ID = "0001", Name = "Preety", Grade = 1, Class = 1 },
                new Student { ID = "0002", Name = "Snurag", Grade = 1, Class = 1 },

                // 2학년 1반
                new Student { ID = "0004", Name = "Anurag", Grade = 2, Class = 1 },
                new Student { ID = "0005", Name = "Hina", Grade = 2, Class = 1 },
                // 2학년 2반
                new Student { ID = "0006", Name = "Priyanka", Grade = 2, Class = 2 },

                // 3학년 1반
                new Student { ID = "0007", Name = "santosh", Grade = 3, Class = 1 },
                new Student { ID = "0008", Name = "Tina", Grade = 3, Class = 1 },
                // 3학년 2반
                new Student { ID = "0009", Name = "Celina", Grade = 3, Class = 2 },
                // 3학년 3반
                new Student { ID = "0010", Name = "Sambit", Grade = 3, Class = 3 },
                
                // 1학년 2반
                new Student { ID = "0003", Name = "Pranaya", Grade = 1, Class = 2 }

            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var GroupByQueryResult = (from student in Student.GetStudents()
                                      group student by student.Grade into groupData
                                      select new
                                      {
                                          Grade = groupData.Key,
                                          Count = groupData.Count(),
                                          Data = groupData
                                      });

            Console.WriteLine("질의 구문");
            foreach(var group in GroupByQueryResult)
            {
                Console.WriteLine(group.Grade + "학년의 인원 수: " + group.Count);

                foreach(var st in group.Data)
                {
                    Console.WriteLine($"{st.Grade}, {st.ID}, {st.Name}");
                }

                Console.WriteLine();
            }
        }
    }
}
