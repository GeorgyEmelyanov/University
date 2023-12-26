using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // x = +-sqrt(y^2+1) берем -, так как иначе решения не находятся
            // y = 3/(x^3-1)

            double x0 = -1.5;
            double y0 = -1;
            double x = x0;
            double y = y0; 
            double e = 0.0003;
            double accuracy = e + 1;

            while (accuracy > e) 
            {
                x0 = x;
                y0 = y;
                x = -Math.Sqrt(Math.Pow(y0, 2) + 1);
                y = 3 / (Math.Pow(x, 3) - 1);
                accuracy = Math.Max(Math.Abs(x - x0), Math.Abs(y - y0));
            }
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine();
        }
    }
}
