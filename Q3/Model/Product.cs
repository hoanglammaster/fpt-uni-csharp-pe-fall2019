using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q3.Model
{
    public class Product
    {
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

        public Product()
        {
        }

        public Product(string productName, int supplierID, int categoryID, string quantityPerUnit, decimal unitPrice, int unitsInStock, bool discontinued)
        {
            ProductName = productName;
            SupplierID = supplierID;
            CategoryID = categoryID;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            Discontinued = discontinued;
        }
    }
}