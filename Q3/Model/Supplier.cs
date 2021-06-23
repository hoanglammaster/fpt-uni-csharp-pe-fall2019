using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q3.Model
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }

        public Supplier()
        {
        }

        public Supplier(int supplierID, string supplierName)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
        }
    }
}