using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        public static int BinarySearch(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == x)
                {
                    return mid;
                }
                else if (arr[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            Random rnd = new Random();
            for (int i = 1; i < N; i++)
            {
                arr[i] = rnd.Next(0, 101);
            }
            Array.Sort(arr);
            Console.Write("Введите ключ поиска: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Array.Sort(arr);
            
            int right = BinarySearch(arr, key);
            int left = right - 1;
            if (right != -1)
            {
                Console.Write("Индексы соответствующих элементов: ");
                while ((right < N) && (arr[right] == key))
                {
                    Console.Write(right + " ");
                    right += 1;
                }
                while ((left >= 0) && (arr[left] == key))
                {
                    Console.Write(left + " ");
                    left -= 1;
                }
                Console.WriteLine();
                Console.WriteLine("Всего элементов: " + (right - left - 1));
            }
            else
                Console.WriteLine("Элемент не найден!");

        }
    }
}
