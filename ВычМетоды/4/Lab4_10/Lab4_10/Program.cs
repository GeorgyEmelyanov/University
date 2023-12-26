using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_10
{
    internal class Program
    {
        public static double fA(double[] x, int k)
        {
            double A = 1;
            for (int i = 0; i < 4; i++) 
            {
                if (i != k)
                    A /= (x[k] - x[i]);
            }
            return A;
        }
        static void Main(string[] args)
        {
            double[] X = new double[4] { 14, 17, 31, 35 };
            double[] Y = new double[4] { 68.7, 64, 44, 39.1 };
            double[] A = new double[4];
       
            for (int i = 0; i < 4; i++)
            {
                A[i] = fA(X, i);
            }
            double Lup = 0;
            double Ldown = 0;
            for (int i=0;i<4;i++)
            {
                Lup += A[i] * Y[i] / (20 - X[i]);
                Ldown += A[i] / (20 - X[i]);
            }
            double value = Lup/ Ldown;
            Console.WriteLine(value);


        }
    }
}
