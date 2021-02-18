using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebBrowser.persistance
{
    class WriteHtml 
    {

        public const string fileName = "links.html";
        public const string head = @"
<head>
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0""
    <title>History</title>
</head>
";
            

        public static bool CreateHtmlFile(List<string> urls)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                saveToFile(urls);
                return true;
            } else
            {
                saveToFile(urls);
                return true;
            }
        }
        private static bool saveToFile(List<string> urls)
        {
            using (StreamWriter ws = new StreamWriter(fileName))
            {
                ws.WriteLine("<!DOCTYPE html>");
                ws.WriteLine("<html>");
                ws.WriteLine(head);
                ws.WriteLine("<body>");
                ws.WriteLine("<main class=\"links\">");
                ws.WriteLine("<h1>Links</h1>");
                urls.ForEach(url => {
                    ws.WriteLine($"<a href=\"{url}\">{url}</a>");
                });
                ws.WriteLine("</main>");
                ws.WriteLine("</body>");
                ws.WriteLine("</html>");
            }
            return true;
        }
    }
}
