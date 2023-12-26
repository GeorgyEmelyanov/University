using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_10
{
    internal class Program
    {
        public static double fS(double a, double b, double c, double d, double x, double arg)
        {
            double result = a + b * (arg - x) + c * Math.Pow(arg - x, 2) + d * Math.Pow(arg - x, 3);
            return Math.Round(result, 4);
        }
        static void Main(string[] args)
        {
            double[] f = new double[6] { 1.1123, 1.1453, 1.2344, 1.4321, 1.8321, 1.8888 };
            double[] x = new double[6] { 0.1, 0.13, 0.18, 0.24, 0.28, 0.32 };

            double[] a = new double[6] { 1.1123, 1.1453, 1.2344, 1.4321, 1.8321, 1.8888 };
            double[] b = new double[6];
            double[] c = new double[6];
            double[] d = new double[6];


            double[] h = new double[6] { 0, x[1] - x[0], x[2] - x[1], x[3] - x[2], x[4] - x[3], x[5] - x[4] };
            double[] l = new double[6];   //вспомогательный
            double[] sig = new double[6]; //вспомогательный
            double[] lam = new double[6]; //вспомогательный

            //double g1 = -0.2313;
            //double g2 = -0.8765;

            for (int i = 1; i < 6; i++) 
            {
                h[i] = x[i] - x[i - 1];
                l[i] = (f[i] - f[i-1] )/ h[i];
            }
            c[0] = 0;
            sig[0] = 0;
            sig[1] = -h[2] / (2 * (h[1] + h[2]));
            lam[0] = 0;
            lam[1] = 3 * (l[2] - l[1]) / (2 * (h[1] + h[2]));
            for (int i=3; i < 6; i++)
            {
                sig[i - 1] = -h[i] / (2 * h[i - 1] + 2 * h[i] + h[i - 1] * sig[i - 2]);
                lam[i - 1] = (3 * l[i] - 3 * l[i - 1] - h[i - 1] * lam[i - 2]) / (2 * h[i - 1] + 2 * h[i] + h[i - 1] * sig[i - 2]);
            }

            for (int i = 2; i < 6; i++) 
            {
                c[i] = (c[i - 1] - lam[i-1])/sig[i-1];
            }

            for (int i = 1; i < 6; i++)
            {
                b[i] = l[i] + (2 * c[i] * h[i] + h[i] * c[i - 1]) / 3;
                d[i] = (c[i] - c[i - 1]) / (3 * h[i]);
            }

            for (int i = 1; i < 6; i++)
            {
                c[i] = Math.Round(c[i], 4);
                b[i] = Math.Round(b[i], 4);
                d[i] = Math.Round(d[i], 4);
                Console.WriteLine( a[i] + " " + b[i] + " " + c[i] + " " + d[i]);
                Console.WriteLine();
            }

            double arg = 0.2;
            int k = 0;
            for(int i = 1;i < 6;i++)
            {
                if ((arg <= x[i]) &&(arg > x[i-1]))
                {
                    k=i; 
                    break; 
                }
            }
            if (k == 0)
                Console.WriteLine("Ошибка (неверное значение аргумента)");
            else
            {
                double result = fS(a[k], b[k], c[k], d[k], x[k], arg);
                Console.WriteLine("S3" + "(" + arg + ") = " + result);
            }
        }
    }
}
