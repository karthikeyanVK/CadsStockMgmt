using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ElectronicShop.Business.Commands
{
    
    public class Serialization
    {
        public void ProductSerialize(ref Inventory pro)
        {
            XmlSerializer xms = new XmlSerializer(typeof(Inventory));
            using (TextWriter filestream = new StreamWriter(Filepath.ProductPath))
            {
                xms.Serialize(filestream, pro);
            }
        }
        public void SaleSerialize(ref Inventory s)
        {
            XmlSerializer xms = new XmlSerializer(typeof(Inventory));
            using (TextWriter filestream = new StreamWriter(Filepath.SalesPath))
            {
                xms.Serialize(filestream, s);
            }
        }
    }
}

