using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab3Queue.Que;


namespace Lab3Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var que = new Quemy<int>();
            que.Add(1);
            que.Add(-2);
            que.Add(-3);
            que.Add(4);
            que.Add(5); 
            que.Add(-6);
            que.Add(7);
            que.Add(8);
            que.Add(-9);
            que.Add(10);

            var queplus = new Quemy<int>();
            var queminus = new Quemy<int>();

            while (que.Count > 0)
            {
                int a = que.Take();
                if (a>0)
                    queplus.Add(a);
                else
                    queminus.Add(a);
            }

            Console.WriteLine("Очередь положительных чисел");
            while (queplus.Count >0)
            {
                Console.Write(queplus.Take() + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Очередь отрицательных чисел");
            while (queminus.Count > 0)
            {
                Console.Write(queminus.Take() + "  ");
            }
            Console.WriteLine();
        }
    }
}
