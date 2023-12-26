using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var set = new Setmy<Char>();
            Console.WriteLine("Введите строку: ");
            string s = Console.ReadLine();

            for (int i = 0; i < s.Length; i++) 
            {
                set.Add(s[i]);
            }
            int chose=0;
            do
            {
                Console.WriteLine("Выберите, что хотите вывести: \n 1.Входит не менее 2 раз \n 2.Входит не более двух раз \n 3.Входит более двух раз \n 0.Выход");
                int.TryParse(Console.ReadLine(), out chose);
                switch (chose)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            Console.Write("Входит не менее 2 раз: ");
                            for (int i = 0; i < set.Count; i++) 
                            {
                                int count = s.ToCharArray().Where(c => c == set.Take(i)).Count();
                                if (count >= 2) 
                                {
                                    Console.Write(set.Take(i) + " ");
                                }
                            }
                            Console.WriteLine();

                        }
                        break;
                    case 2:
                        {
                            Console.Write("Входит не более 2 раз: ");
                            for (int i = 0; i < set.Count; i++)
                            {
                                int count = s.ToCharArray().Where(c => c == set.Take(i)).Count();
                                if (count <= 2) 
                                {
                                    Console.Write(set.Take(i) + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Входит более 2 раз: ");
                            for (int i = 0; i < set.Count; i++)
                            {
                                int count = s.ToCharArray().Where(c => c == set.Take(i)).Count();
                                if (count > 2)
                                {
                                    Console.Write(set.Take(i) + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                        break;
                        default:
                        Console.WriteLine("Неверно выбран номер");
                        break;
                        
                }
            } while (chose != 0);


        }
    }
}
