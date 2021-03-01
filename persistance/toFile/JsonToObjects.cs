using MyWebBrowser.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebBrowser.persistance.toFile
{
    class JsonToObjects
    {
        public static List<Visit> GetVisitsFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                string jsonList = "";
                using (StreamReader sr = new StreamReader (fileName))
                {
                    jsonList = sr.ReadToEnd();
                }
                if (jsonList.Length < 0)
                {
                    return null;
                }
                return JsonConvert.DeserializeObject<List<Visit>>(jsonList);
            } else
            {
                return null;
            }
        }
    }
}
