using Q2.DAL;
using Q2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Q2.BLL
{
    class ProductBLL
    {
        public static List<Product> GetListAllProduct()
        {
            DataTable dataTable = ProductDAL.GetDataTableAllProduct();
            List<Product> listProducts = new List<Product>();
            foreach(DataRow row in dataTable.Rows)
            {
                listProducts.Add(new Product(
                    Int32.Parse(row["ProductID"].ToString()),
                    row["ProductName"].ToString(),
                    row["CompanyName"].ToString(),
                    row["CategoryName"].ToString(),
                    row["QuantityPerUnit"].ToString(),
                    Decimal.Parse(row["UnitPrice"].ToString()),
                    Int32.Parse(row["UnitsInStock"].ToString()),
                    Int32.Parse(row["UnitsOnOrder"].ToString()),
                    Int32.Parse(row["ReorderLevel"].ToString()),
                    bool.Parse(row["Discontinued"].ToString())
                    ));
            }
            return listProducts;
        }
    }
}
