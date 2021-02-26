using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace MyWebBrowser.models
{
    [Serializable()]
    class Visit : ISerializable
    {
        public string Url { get; set; }
        public int TimesVisited { get; set; }
        public List<DateTime> DatesVisited { get; set; }
        public Visit(string url)
        {
            this.Url = url;
            this.TimesVisited = 1;
            this.DatesVisited = new List<DateTime>();
            this.DatesVisited.Add(DateTime.Now);
        }
        public bool addVisit()
        {
            this.TimesVisited++;
            this.DatesVisited.Add(DateTime.Now);
            return true;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Url", Url);
            info.AddValue("TimesVisited", TimesVisited);
            info.AddValue("DatesVisited", DatesVisited);
        }

        public Visit (SerializationInfo info, StreamingContext context)
        {
            Url = info.GetValue("Url", typeof(string)) as string;
            TimesVisited = (int) info.GetValue("Visit", typeof(int));
            DatesVisited = (List<DateTime>)info.GetValue("DatesVisited", typeof(List<Visit>));
        }
    }
}
