using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicShop.DataModel;

namespace ElectronicShop.DataAccess
{

    public class ElectronicShopData
    {
        public string[] GetModel(Product[] model)
        {
            var modelNames = model.Select(p => p.ModelNo).Distinct().ToArray();
            return modelNames;
        }
        public List<Product> SearchProduct(List<Product> searchProduct,string model)
        {
            var availableProducts = searchProduct.Where(p => p.ModelNo.ToLower().Contains(model)).ToList();
            return availableProducts;
        }
        public Product GetProduct(List<Product> getProduct,string model)
        {
            Product selectedProduct = getProduct.FirstOrDefault(p => p.ModelNo == model);
            return selectedProduct;
        }
        public List<Sales> GetReport(List<Sales> getSales,DateTime fromDate, DateTime toDate)
        {
            var result = getSales.Where(p => p.Date >= fromDate && p.Date <= toDate).ToList();
            return result;
        }
        public List<Sales> SearchSale(List<Sales> searchSale,string model)
        {
            var productsSold = searchSale.Where(p => p.ModelNo.ToLower().Contains(model)).ToList();
            return productsSold;
        }
        public Product CheckProductModel(List<Product> product,string model)
        {
            var checkProductModel = product.FirstOrDefault(p => p.ModelNo.Equals(model));
            return checkProductModel;
        }

    }
}
