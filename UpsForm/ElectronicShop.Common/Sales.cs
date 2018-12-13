using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.DataModel
{
    public class Sales : ICommonProperties
    {
        public string CustomerName
        {
            get; set;
        }
        public long CustomerPhoneNo
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
        public string ModelNo
        {
            get; set;
        }
        public int Code
        {
            get; set;
        }
        public int Price
        {
            get; set;
        }
        public int Warranty
        {
            get; set;
        }
        public int Quantity
        {
            get; set;
        }
        //public Product ProductDetails { get; set; }
    }
}
