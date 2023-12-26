using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace WebScraper
{
    internal class Program
    {
        static void WriteToCSVFile(Uri localUri, string target, string filePath) 
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@filePath, true, System.Text.Encoding.UTF8))
                {
///
                    WebRequest req = HttpWebRequest.Create(target);
                    req.Method = "GET";
                    string s;
                    string title = " ";
                    using (StreamReader reader = new StreamReader(req.GetResponse().GetResponseStream()))
                    {
                        s = reader.ReadToEnd();
                    }
                    if (s.Contains("<title>"))
                    {
                        int val1 = s.IndexOf("<title>", 0) + 7;
                        int val2 = s.IndexOf("</title>", 0);
                        title = s.Substring(val1, val2 - val1);
                    }

 ///
                    file.WriteLine(localUri + ";" + target + ";" + title);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ConsoleHandler(Uri page, List<Uri> links)
        {
            Console.WriteLine($"\nСтраница:\t{page}\nСсылки");
            if (links.Any())
            {
                var counter = 0;
                foreach (var link in links)
                {
                    counter++; 
                    if (counter < 6)
                        Console.WriteLine($"\t{link}");

                    WriteToCSVFile(page, link.ToString(), "links.csv");
                }
            }
            else
            {
                Console.WriteLine("\tНет ссылок");
            }
        }

        public static void Main(string[] args)
        {
            File.Delete("links.csv");
            using (Scanner
                   scanner =
                   new Scanner()) 
            {
                scanner.TargetFound += ConsoleHandler; 
                scanner.Scan(new Uri("https://ya.ru"), 2);
                Console.WriteLine("Сканирование завершено");
            }
        }
    }
}