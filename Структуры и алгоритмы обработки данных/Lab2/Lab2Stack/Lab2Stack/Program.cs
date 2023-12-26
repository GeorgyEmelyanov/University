using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab2Stack.St;
namespace Lab2Stack
{
    internal class Program
    {

        public static int Take_34(Stackmy<int> stack)
        {
            int curr = 0;
            while (stack.Count > 0)
            {
                int a = stack.Pop();
                if ((a % 3 == 0) && (a % 4 == 0))
                {
                    if (curr == 0)
                        curr = a;
                    else
                        curr *= a;
                }
            }
            return curr;
        }
        
        static void Main(string[] args)
        {
            Stackmy<int> stack = new Stackmy<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(12);
            stack.Push(24);


            //Console.WriteLine(Take_34(stack));
           
            
            while (stack.Count > 0)
            {
              
                Console.WriteLine(stack.Peek());
                Console.WriteLine("\n");
            }
            
        }
    }
}
