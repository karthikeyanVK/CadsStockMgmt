using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ElectronicShop.Business.Commands
{
    public class Deserialization
    {
        public object ProductDeserialize(ref Inventory pro)
        {
            if (File.Exists(Filepath.ProductPath))
            {
                using (var reader = new StreamReader(Filepath.ProductPath))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Inventory));
                    pro = (Inventory)xmls.Deserialize(reader);
                    return pro;
                }
            }
            return "No data found";
        }
        public Inventory ProductDeserialize()
        {
            if (File.Exists(Filepath.ProductPath))
            {
                using (var reader = new StreamReader(Filepath.ProductPath))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Inventory));
                    Inventory proList = (Inventory)xmls.Deserialize(reader);
                    return proList;
                }
            }
            return new Inventory();
        }
        public object SalesDeserialize(ref Inventory sale)
        {

            if (File.Exists(Filepath.SalesPath))
            {
                using (var reader = new StreamReader(Filepath.SalesPath,true))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Inventory));
                    sale = (Inventory)xmls.Deserialize(reader);
                    return sale;
                }
            }
            return "No data found";
        }
    }
}
