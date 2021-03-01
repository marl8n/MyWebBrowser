using MyWebBrowser.models;
using MyWebBrowser.persistance.toFile;
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
        public const string fileName = "visitedUrls.json";
        public List<Visit> VisitedUrls { get; set; }
        public History()
        {
            VisitedUrls = new List<Visit>();
            if (File.Exists(fileName))
            {
                this.VisitedUrls = JsonToObjects.GetVisitsFromFile(fileName);
                if (this.VisitedUrls == null)
                {
                    VisitedUrls = new List<Visit>();
                }
            } else
            {
                File.Create(fileName);
                this.VisitedUrls = new List<Visit>();
            }
        }
        

        public bool AddUrl(string url)
        {
            if (this.VisitedUrls == null )
            {
                return false;
            }
            for (var i = 0; i < VisitedUrls.Count; i++ )
            {
                if ( VisitedUrls.ElementAt(i).Url == url )
                {
                    VisitedUrls.ElementAt(i).AddVisit();
                    ObjectsToJson.SaveVisitsToFile(this.VisitedUrls, fileName);
                    return true;
                }
            }

            this.VisitedUrls.Add(new Visit(url));
            ObjectsToJson.SaveVisitsToFile(this.VisitedUrls, fileName);
            return true;
        }
    }
}
