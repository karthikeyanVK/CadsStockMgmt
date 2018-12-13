using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ElectronicShop.DataAccess;
using ElectronicShop.DataModel;
using UPS;

namespace ElectronicShop.Business.Commands
{
    [Serializable]
    public class Shop
    {
        public List<Product> ProductList { get; set; }
        public List<Sales> SaleList { get; set; }
        public ElectronicShopData Data { get; set; }

        public Shop()
        {
            ProductList = new List<Product>();
            SaleList = new List<Sales>();
            Data = new ElectronicShopData();
        }
        public bool AddProduct(Product product)
        {
            if (SearchProduct(product.ModelNo) == null)
            {
                ProductList.Add(product);
                return true;
            }
            return false;
        }
        public Product SearchProduct(string model)
        {
            var checkModel = Data.CheckProductModel(ProductList, model);
            return checkModel;
        }
        public List<Product> Search(string model)
        {
            var availableProducts = Data.SearchProduct(ProductList,model);
            return availableProducts;
        }

        public string[] AccessModel()
        {
            Product[] sendData = ProductList.ToArray();
            string[] modelNames = Data.GetModel(sendData);
            return modelNames;
        }

        public Product AccessData(string model)
        {
            Product selectedProduct = Data.GetProduct(ProductList, model);
            return selectedProduct;
        }
        
        public bool CheckQuantityAvailability(string model, int code, int quantity)
        {
            foreach (Product quantitylist in ProductList)
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
            foreach (Product quantitylist in ProductList)
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
            foreach (Product quantitylist in ProductList)
            {
                if (quantitylist.Code == code && quantitylist.ModelNo == model)
                {
                    quantitylist.Quantity = quantitylist.Quantity + quantity;
                    return true;
                }
            }
            return false;
        }


        public List<Sales> AccessReport(DateTime fromDate, DateTime toDate)
        {
            List<Sales> result = Data.GetReport(SaleList, fromDate, toDate);
            return result;
        }
        public List<Sales> ViewSale(string model)
        {
            List<Sales> result = Data.SearchSale(SaleList, model); 
            return result;
        }
        public void ProductSerialize(ref Shop pro)
        {
            XmlSerializer xms = new XmlSerializer(typeof(Shop));
            using (TextWriter filestream = new StreamWriter(CommandsFilepath.ProductPath))
            {
                xms.Serialize(filestream, pro);
            }
        }
        public void SaleSerialize(ref Shop s)
        {
            XmlSerializer xms = new XmlSerializer(typeof(Shop));
            using (TextWriter filestream = new StreamWriter(CommandsFilepath.SalesPath))
            {
                xms.Serialize(filestream, s);
            }
        }
        public object ProductDeserialize(ref Shop pro)
        {
            if (File.Exists(CommandsFilepath.ProductPath))
            {
                using (var reader = new StreamReader(CommandsFilepath.ProductPath))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Shop));
                    pro = (Shop)xmls.Deserialize(reader);
                    return pro;
                }
            }
            return "No data found";
        }
        public Shop ProductDeserialize()
        {
            if (File.Exists(CommandsFilepath.ProductPath))
            {
                using (var reader = new StreamReader(CommandsFilepath.ProductPath))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Shop));
                    Shop proList = (Shop)xmls.Deserialize(reader);
                    return proList;
                }
            }
            return new Shop();
        }
        public object SalesDeserialize(ref Shop sale)
        {

            if (File.Exists(CommandsFilepath.SalesPath))
            {
                using (var reader = new StreamReader(CommandsFilepath.SalesPath, true))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Shop));
                    sale = (Shop)xmls.Deserialize(reader);
                    return sale;
                }
            }
            return "No data found";
        }
    }
}