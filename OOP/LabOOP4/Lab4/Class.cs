using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace WebScraper
{
    public class Scanner : IDisposable 
    {
        private readonly HashSet<Uri> _processedLinks = new HashSet<Uri>(); 
        private readonly WebClient _webClient = new WebClient(); 

        private readonly HashSet<string> _ignoreFiles = new HashSet<string> { ".ico", ".xml", ".png", ".jpg", ".gif" };

        public event Action<Uri, List<Uri>> TargetFound;
        private void OnTargetFound(Uri page, List<Uri> links)
        {
            TargetFound?.Invoke(page, links);
        }


        public void Scan(Uri startPage, int pageCount)
        {
            _processedLinks.Clear(); 
            var domain = $"{startPage.Scheme}://{startPage.Host}";

            Process(domain, startPage, pageCount);
        }

        private void Process(string domain, Uri page, int count)
        {
            if (count < 0) return; 
            if (_processedLinks.Contains(page)) return; 
            _processedLinks.Add(page); 

            string html;
            try
            {
                html = _webClient.DownloadString(page);
            }
            catch (WebException)
            {
                return; 
            }

            var hrefs = (from href in Regex.Matches(html, @"href=""[\/\w-\.:]+""").Cast<Match>()
                         where href.Value.Replace("href=", "").Trim('"').StartsWith("/")
                         let url = href.Value.Replace("href=", "").Trim('"')
                         select new Uri($"{domain}{url}")
                ).ToList(); 

            var externals = (from href in Regex.Matches(html, @"href=""[\/\w-\.:]+""").Cast<Match>()
                             where !href.Value.Replace("href=", "").Trim('"').StartsWith("/")
                             let url = href.Value.Replace("href=", "").Trim('"')
                             select new Uri(url)
                ).ToList();
            if (externals.Count > 0)
                OnTargetFound(page, externals);



            foreach (var href in hrefs) 
            {
                string fileEx = Path.GetExtension(href.LocalPath).ToLower(); 
                if (_ignoreFiles.Contains(fileEx)) continue; 

                Process(domain, href, --count);
            }
        }

        public void Dispose()
        {
            _webClient.Dispose();
        }
    }
}
