using MyWebBrowser.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MyWebBrowser.persistance.toFile
{
    class binaries
    {
        public static bool Save(string fileName, List<Visit> list)
        {

            using (Stream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None)
            {
                XmlSerializer s = new XmlSerializer();
                s.Serialize(fs, list);
            }
            return false;
        }
    }
}
