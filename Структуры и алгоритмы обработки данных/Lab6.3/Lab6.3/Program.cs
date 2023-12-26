using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters;
using System.Security.Authentication;

class Program
{
    static void Main(string[] args)
    {
        string textFilePath = "text.txt";
        string pattern;

        Console.Write("Введите слово для поиска: ");
        pattern = Console.ReadLine();

        if (File.Exists(textFilePath))
        {
            string text = File.ReadAllText(textFilePath);
            int index = BoyerMooreSearch(text, pattern);
            if (index == -1)
            {
                Console.WriteLine("Слово не найдено.");
            }
            else
            {
                Console.WriteLine("Слово найдено в позиции " + index);
            }
        }
        else
        {
            Console.WriteLine("Файл не найден.");
        }

        Console.ReadKey();
    }

    static int BoyerMooreSearch(string text, string pattern)
    {
        Dictionary<char, int> tab = new Dictionary<char, int>();
        int n = text.Length;
        int m = pattern.Length;

        for (int i = m - 2; i >= 0; i--) 
        {
            if (!tab.ContainsKey(pattern[i]))
                tab.Add(pattern[i], m-i-1);
        }
        if (!tab.ContainsKey(pattern[m-1]))
            tab.Add(pattern[m-1], m);

        int s = 0;
        
        while (s <= n - m)
        {
            int j = m - 1;

            while (j >= 0 && pattern[j] == text[s + j])
                j--;
            if (j < 0)
                return s;
            else
            {
                if (tab.ContainsKey(text[s + j]))
                    s += tab[text[s + j]];
                else
                    s += m;
            }
     
        }
        return -1;
    }
}