using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] A = new double[4, 4]
            {
                { 3.3, 1.2, -0.07, 1 },
                { 0.1, 2.7, 0.3, -1.2 },
                { 0.5, -0.5, 2.2, 0.5 },
                { 0.2, -0.3, -0.4, 1.8 }
            };
            double[] B = new double[4] { 0.23, 7.2, -0.22, -0.6 };
            double e = 0.001;

            bool flag = true;

            for (int i = 0; i < 4; i++)
            {
                double x = Math.Abs(A[i, i]);
                double y = 0;
                for (int j = 0; j < 4; j++)
                {
                    if (i != j)
                        y += Math.Abs(A[i, j]);
                }
                if (x <= y)
                    flag = false;
            }

            double[] Xbefore = new double[4] { 0, 0, 0, 0 };
            double[] Xafter = new double[4] { 0, 0, 0, 0 };
            double[] accuracy = new double[4] { 10, 10, 10, 10 };
            int k = 0;
            if (flag)
            {
                while (accuracy.Max() > e)
                {
                    k += 1;
                    double x1, x2, x3, x4;
                    
                    x1 = (B[0] - A[0, 1] * Xbefore[1] - A[0, 2] * Xbefore[2] - A[0, 3] * Xbefore[3]) / A[0, 0];
                    x2 = (B[1] - A[1, 0] * Xbefore[0] - A[1, 2] * Xbefore[2] - A[1, 3] * Xbefore[3]) / A[1, 1];
                    x3 = (B[2] - A[2, 1] * Xbefore[1] - A[2, 0] * Xbefore[0] - A[2, 3] * Xbefore[3]) / A[2, 2];
                    x4 = (B[3] - A[3, 1] * Xbefore[1] - A[3, 2] * Xbefore[2] - A[3, 0] * Xbefore[0]) / A[3, 3];
                    Xafter[0] = x1;
                    Xafter[1] = x2;
                    Xafter[2] = x3;
                    Xafter[3] = x4;

                    for (int i = 0; i < 4; i++)
                        accuracy[i] =Xafter[i] - Xbefore[i];

                    Xbefore[0] = x1;
                    Xbefore[1] = x2;
                    Xbefore[2] = x3;
                    Xbefore[3] = x4;

                }
            }
            Console.WriteLine(k + " Иттераций ");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("x" + i + " = " + Xafter[i]);
            }
        }
    }
}
