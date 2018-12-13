using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Business.Commands
{
    [Serializable]
    public class Inventory
    {
        public List<Product> plist1 = new List<Product>();
        public List<Sales> slist1 = new List<Sales>();

        public Serialization Serialize
        {
            get => default(Serialization);
            set
            {
            }
        }
        public Deserialization Deserialize
        {
            get => default(Deserialization);
            set
            {
            }
        }
        public Product ProductList
        {
            get => default(Product);
            set
            {
            }
        }
        public Sales SalesList
        {
            get => default(Sales);
            set
            {
            }
        }
        public List<Product> SearchProduct(string model)
        {
            var ModelNo = model;
            var availableProducts = plist1.Where(p => p.ModelNo.ToLower().Contains(ModelNo)).ToList();
            return availableProducts;
        }
        public string[] GetModel()
        {
            var modelNames = plist1.Select(p => p.ModelNo).Distinct().ToArray();
            return modelNames;
        }
        public Product GetData(string model)
        {
            var selectedProduct = plist1.FirstOrDefault(p => p.ModelNo == model);
            return selectedProduct;
        }
        
        public bool CheckQuantityAvailability(string model, int code, int quantity)
        {
            foreach (Product quantitylist in plist1)
            {
                if (quantitylist.ModelNo == model && quantitylist.Code == code && quantitylist.Quantity < quantity)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SaleProduct(string model, int code, int quantity)
        {
            foreach (Product quantitylist in plist1)
            {
               if(quantitylist.ModelNo == model && quantitylist.Code == code && quantitylist.Quantity >= quantity)
                {
                    quantitylist.Quantity = quantitylist.Quantity - quantity;
                    return true;
                }
            }
            return false;
        }
        public bool AddExistingProduct(string model, int code, int quantity)
        {
            foreach (Product quantitylist in plist1)
            {
                if (quantitylist.Code == code && quantitylist.ModelNo == model)
                {
                    quantitylist.Quantity = quantitylist.Quantity + quantity;
                    return true;
                }
            }
            return false;
        }
        public List<Sales> SearchReport(DateTime fromDate, DateTime toDate)
        {
            var result = slist1.Where(p => p.Date >= fromDate && p.Date <= toDate).ToList();
            return result;
        }
        public List<Sales> SearchBill(string model)
        {
            var productsSold = slist1.Where(p => p.ModelName.ToLower().Contains(model)).ToList();
            return productsSold;
        }


    }
}
