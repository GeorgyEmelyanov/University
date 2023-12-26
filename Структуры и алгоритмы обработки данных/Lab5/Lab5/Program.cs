using System;
using System.Diagnostics;

class Program
{
    public static void QuickSort(int[] data, int left, int right)
    {
        int i = left, j = right;
        int pivot = data[(left + right) / 2];

        while (i <= j)
        {
            while (data[i] < pivot)
            {
                i++;
            }

            while (data[j] > pivot)
            {
                j--;
            }

            if (i <= j)
            {
                int tmp = data[i];
                data[i] = data[j];
                data[j] = tmp;

                i++;
                j--;
            }
        }

        if (left < j)
        {
            QuickSort(data, left, j);
        }

        if (i < right)
        {
            QuickSort(data, i, right);
        }
    }

    static void HeapSort(int[] data)
    {
        // Строим пирамиду из массива данных
        for (int i = data.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(data, data.Length, i);
        }

        // Последовательно извлекаем элементы из пирамиды и перестраиваем ее
        for (int i = data.Length - 1; i >= 0; i--)
        {
            int temp = data[0];
            data[0] = data[i];
            data[i] = temp;

            Heapify(data, i, 0);
        }
    }

    static void Heapify(int[] data, int heapSize, int rootIndex)
    {
        int largestIndex = rootIndex;
        int leftChildIndex = 2 * rootIndex + 1;
        int rightChildIndex = 2 * rootIndex + 2;

        if (leftChildIndex < heapSize && data[leftChildIndex] > data[largestIndex])
        {
            largestIndex = leftChildIndex;
        }

        if (rightChildIndex < heapSize && data[rightChildIndex] > data[largestIndex])
        {
            largestIndex = rightChildIndex;
        }

        if (largestIndex != rootIndex)
        {
            int temp = data[rootIndex];
            data[rootIndex] = data[largestIndex];
            data[largestIndex] = temp;

            Heapify(data, heapSize, largestIndex);
        }
    }

    static void PrintArray(int[] data)
    {
        foreach (int element in data)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    static void Main()
    {
        int[] usData = { 7, 2, 1, 6, 8, 5, 3, 4, 10, 9 };
        int[] psData = { 11, 12, 13, 14, 15, 17, 16, 20, 19, 18 };
        int[] bsData = { 30, 29, 28, 27, 26, 25, 24, 23, 22, 21 };
        int[] data = new int[10];
        Console.Write("Неотсортированный массив: ");
        PrintArray(usData);
        Console.Write("Частично отсортированный массив: ");
        PrintArray(psData);
        Console.Write("Обратно отсортированный массив: ");
        PrintArray(bsData);
        Console.WriteLine();

        var sw = new Stopwatch();
        Console.ReadLine();
        //Пробный прогон программы перед конечным рассчетом времени
        //нужен для того, чтобы программа впервые прогнала методы сортировки

        usData.CopyTo(data, 0);
        sw.Restart();
        QuickSort(data, 0, data.Length - 1);
        sw.Stop();
       
        usData.CopyTo(data, 0);
        sw.Restart();
        HeapSort(data);
        sw.Stop();
        
        //------------------------------------------------------------------

        Console.WriteLine("Проверка на неотсортированном массиве: ");
        usData.CopyTo(data, 0);
        PrintArray(data);

        Console.Write("Быстрая сортировка: ");
        sw.Restart();
        QuickSort(data, 0, data.Length - 1);
        sw.Stop();
        PrintArray(data);
        Console.WriteLine("Время (Ticks): " + sw.ElapsedTicks);

        Console.Write("Пирамидальная сортировка: ");
        usData.CopyTo(data, 0);
        sw.Restart();
        HeapSort(data);
        sw.Stop();
        PrintArray(data);
        Console.WriteLine("Время (Ticks): " + sw.ElapsedTicks);
        Console.WriteLine();

        //------------------------------------------------------------------

        Console.WriteLine("Проверка на частично отсортированном массиве: ");
        psData.CopyTo(data, 0);
        PrintArray(data);

        Console.Write("Быстрая сортировка: ");
        sw.Restart();
        QuickSort(data, 0, data.Length - 1);
        sw.Stop();
        PrintArray(data);
        Console.WriteLine("Время (Ticks): " + sw.ElapsedTicks);

        Console.Write("Пирамидальная сортировка: ");
        psData.CopyTo(data, 0);
        sw.Restart();
        HeapSort(data);
        sw.Stop();
        PrintArray(data);
        Console.WriteLine("Время (Ticks): " + sw.ElapsedTicks);
        Console.WriteLine();

        //------------------------------------------------------------------

        Console.WriteLine("Проверка на обратно отсортированном массиве: ");
        bsData.CopyTo(data, 0);
        PrintArray(data);

        Console.Write("Быстрая сортировка: ");
        sw.Restart();
        QuickSort(data, 0, data.Length - 1);
        sw.Stop();
        PrintArray(data);
        Console.WriteLine("Время (Ticks): " + sw.ElapsedTicks);

        Console.Write("Пирамидальная сортировка: ");
        bsData.CopyTo(data, 0);
        sw.Restart();
        HeapSort(data);
        sw.Stop();
        PrintArray(data);
        Console.WriteLine("Время (Ticks): " + sw.ElapsedTicks);
        Console.WriteLine();

        Console.ReadLine();
    }

}