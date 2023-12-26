using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1Str
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s= Console.ReadLine();
            Regex upregex = new Regex("([A-Z])");
            Regex lowregex = new Regex("([a-z])");
            Console.WriteLine("Прописных английских букв: " + upregex.Matches(s).Count);
            Console.WriteLine("Строчных английских букв: " + lowregex.Matches(s).Count);
        }
    }
}
