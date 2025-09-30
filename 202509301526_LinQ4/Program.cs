using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509301526_LinQ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "agg", "aff", "aee", "add", "acc", "abb", "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            var sortedWords = words
                .OrderBy(a => a.Length)
                .ThenBy(a => a);

            foreach(var data in sortedWords)
            {
                Console.WriteLine($"{data}, ");
            }
        }
    }
}
