using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202510021637_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // string Builder
            string name = "monster" + "ogre" + "zombie";

            string a = "monster";

            a = "zombie";

            a += "text";

            Console.WriteLine(a);

            StringBuilder nameBuilder = new StringBuilder();

            nameBuilder.Append("monster");
            nameBuilder.Append("Ogre");
            nameBuilder.Append("zombie");

            Console.WriteLine(nameBuilder.ToString());
        }
    }
}
