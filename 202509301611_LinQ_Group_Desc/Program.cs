using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301611_LinQ_Group_Desc
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171},
                new Profile(){Name = "강호동", Height = 182},
                new Profile(){Name = "유재석", Height = 175},
                new Profile(){Name = "엄정화", Height = 165},
            };

            // profile을 grouping하는데 by profile.Height기준으로 나누고 g에 담아라.
            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };

            foreach(var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

                foreach(var profile in Group.Profiles)
                {
                    Console.WriteLine($" {profile.Name}, {profile.Height}");
                }
            }
            Console.WriteLine();

            // 문제 1.
            // 키가 160보다 크고 175보다는 작은 데이터만 표시해 보세요....

            var listProfile2 = from profile2 in arrProfile
                               where profile2.Height > 160 && profile2.Height < 175
                               orderby profile2.Height
                               group profile2 by profile2.Height < 175 && profile2.Height > 160 into g2
                               select new { GroupKey = g2.Key, Profiles = g2 };

            foreach (var Group2 in listProfile2)
            {
                Console.WriteLine($"- 160 초과, 175cm 미만? : {Group2.GroupKey}");

                foreach (var profile2 in Group2.Profiles)
                {
                    Console.WriteLine($" {profile2.Name}, {profile2.Height}");
                }
            }
            Console.WriteLine();
        }
    }
}
