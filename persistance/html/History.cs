using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebBrowser.persistance
{
    class History
    {
        public const string fileName = "visitedUrls.txt";
        public List<string> VisitedUrls { get; set; }
        public History()
        {
            VisitedUrls = new List<string>();
            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s;
                    while ( (s = sr.ReadLine()) != null )
                    {
                        VisitedUrls.Add(s);
                    }
                }
            } else
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    Console.WriteLine("File created");
                }
            }
        }
        

        public bool AddUrl(string url)
        {
            this.VisitedUrls.Add(url);
            //
            SaveUrls();
            return true;
        }

        public bool SaveUrls()
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = new StreamWriter(fileName) )
            {
                VisitedUrls.ForEach(sw.WriteLine);
            }
            WriteHtml.CreateHtmlFile(this.VisitedUrls);
            return true;
        }
    }
}
