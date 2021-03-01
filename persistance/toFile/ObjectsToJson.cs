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
    class ObjectsToJson
    {
        public static void SaveVisitsToFile(List<Visit> listOfVisits, string fileName)
        {
            string jsonString = JsonConvert.SerializeObject(listOfVisits, Formatting.Indented);
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Save(listOfVisits, fileName); 
            } else
            {
                Save(listOfVisits, fileName);
            }
        }

        private static void Save(List<Visit> listOfVisits, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(JsonConvert.SerializeObject(listOfVisits));
            }
        }
    }
}
