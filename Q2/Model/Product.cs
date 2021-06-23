using System;
using System.Collections.Generic;
using System.Text;

namespace Q2.Model
{
    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReOrderLevel { get; set; }
        public bool Discontinued { get; set; }

        public Product()
        {
        }

        public Product(int productID, string productName, string companyName, string categoryName, string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder, int reOrderLevel, bool discontinued)
        {
            ProductID = productID;
            ProductName = productName;
            CompanyName = companyName;
            CategoryName = categoryName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReOrderLevel = reOrderLevel;
            Discontinued = discontinued;
        }
    }
}
