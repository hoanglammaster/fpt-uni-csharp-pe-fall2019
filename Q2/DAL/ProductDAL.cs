using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Q2.DAL
{
    class ProductDAL
    {
        public static DataTable GetDataTableAllProduct()
        {
            string query = "SELECT p.ProductID, p.ProductName, s.CompanyName, c.CategoryName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder,p.ReorderLevel, p.Discontinued " +
                "FROM Products p " +
                "JOIN Categories c ON p.CategoryID = c.CategoryID " +
                "JOIN Suppliers s ON p.SupplierID = s.SupplierID";
            SqlCommand command = new SqlCommand(query,DAO.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            new SqlCommandBuilder(adapter);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }   
    }
}
