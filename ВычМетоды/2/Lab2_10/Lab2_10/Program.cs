using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_10
{
    internal class Program
    {
        static double func1(double x,double q, int n)
        {
            return Math.Abs((1 / Math.Pow(x, 2)) - 3 - x) * Math.Pow(q, n) / (1 - q);
        }
        static double func2(double x, double q, int n)
        {
            return Math.Abs(-1 / (Math.Sqrt(x + 3)) - x) * Math.Pow(q, n) / (1 - q);
        }
        static double func3(double x, double q, int n)
        {
            return Math.Abs(1 / (Math.Sqrt(x + 3)) - x) * Math.Pow(q, n) / (1 - q);
        }
        static void Main(string[] args)
        {
            // 1) s(x) = 1/x^2 - 3
            double e = 0.0005;
            double r = 0.5;
            double x = -2.5;
            double q = 0.25;
            double log = Math.Abs(1 / Math.Pow(x, 2) - 3 - x);
            double loga = (1 - q) * r;

            if (log >= loga)
                Console.WriteLine("Ошибка (1 решение)");

            int n1 = 0;
            while (func1(x,q,n1)>e)
                n1 += 1;

            int n = 0;
            double xmain = x;
            while (n <= n1) 
            {
                x = xmain;
                xmain = (1 / Math.Pow(x, 2)) - 3;
                n += 1;
            }
            Console.WriteLine("x1 = " + xmain);
            Console.WriteLine();



            // 2) s(x) = -1/sqrt(x+3)
            x = -0.5;
            q = Math.Abs(-1 / (2 * Math.Sqrt(Math.Pow(2, 3))));
            log = Math.Abs(-1 / (Math.Sqrt(x + 3)) - x);
            loga = (1 - q) * r;
            if (log >= loga)
                Console.WriteLine("Ошибка (2 решение)");

            n1 = 0;
            while (func2(x, q, n1) > e)
                n1 += 1;

            n = 0;
            xmain = x;
            while (n <= n1)
            {
                x = xmain;
                xmain = -1 / Math.Sqrt(x + 3);
                n += 1;
            }
            Console.WriteLine("x2 = " + xmain);
            Console.WriteLine();



            // 3) s(x) = 1/sqrt(x+3)
            x = 0.5;
            q = Math.Abs(1 / (2 * Math.Sqrt(Math.Pow(3, 3))));
            log = Math.Abs(1 / (Math.Sqrt(x + 3)) - x);
            loga = (1 - q) * r;
            if (log >= loga)
                Console.WriteLine("Ошибка (3 решение)");

            n1 = 0;
            while (func3(x, q, n1) > e)
                n1 += 1;

            n = 0;
            xmain = x;
            while (n <= n1)
            {
                x = xmain;
                xmain = 1 / Math.Sqrt(x + 3);
                n += 1;
            }
            Console.WriteLine("x3 = " + xmain);
            Console.WriteLine();
        }
    }
}
