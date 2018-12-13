using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPS
{
    [Serializable]
    public class Product
    {    
        public string Brand
        {
            get;set;
        }
        public string ModelNo
        {
            get;set;
        }

        public int Code
        {
            get;set;
        }
        public int Price
        {
            get;set;
        }
        public int Warranty
        {
            get;set;
        }
        public string Voltage
        {
            get;set;
        }
        public long OutputPower
        {
            get;set;
        }
        public int Quantity
        {
            get;set;
        }
    }
}
