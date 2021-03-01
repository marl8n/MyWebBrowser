using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebBrowser.models
{
    class Visit
    {
        public string Url { get; set; }
        public int TimesVisited { get; set; }
        public DateTime LastVisit { get; set; }
        public Visit(string url)
        {
            this.Url = url;
            TimesVisited = 1;
            LastVisit = DateTime.Now;
        }

        public Visit()
        {

        }

        public Visit(string url, int timesVisited, DateTime lastVisit)
        {
            this.Url = url;
            this.TimesVisited = timesVisited;
            this.LastVisit = lastVisit;
        }

        public void AddVisit ()
        {
            this.TimesVisited++;
            this.LastVisit = DateTime.Now;
        }

    }
}
