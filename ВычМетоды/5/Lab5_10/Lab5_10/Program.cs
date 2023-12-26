using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (1/x^2)dx
            // [1,3]
            // -1/x
            // == -1/3 + 1 == 2/3
            // f''=6/x^4
            double a = 1;
            double b = 3;
            int n = 10;
            double h = (b - a) / n;
            double dx = h;
            double x = a + h / 2;
            double result = 0;
            double trueresult = 1 / a - 1 / b;
            double M = 6 / Math.Pow(1, 4);
            double R = M*(b- a)*Math.Pow(h, 2)/24;
            Console.WriteLine("Истинное значение = " + trueresult);

            while (x < b)
            {
                result += h / Math.Pow(x, 2);
                x += dx;
            }
            Console.WriteLine("Найденое значение при " + n + " разбиениях = " + result);
            double delta=Math.Abs(result - trueresult);
            Console.WriteLine("Дельта = " + delta);
            Console.WriteLine("Погрешность = " + R);
        }
    }
}
