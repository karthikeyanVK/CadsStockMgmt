using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.DataModel
{
    public interface ICommonProperties
    {
        string ModelNo
        {
            get; set;
        }
        int Code
        {
            get; set;
        }
        int Price
        {
            get; set;
        }
         int Warranty
        {
            get; set;
        }
        int Quantity
        {
            get; set;
        }
    }
}
