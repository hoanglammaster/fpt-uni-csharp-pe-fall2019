using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Q3.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public Category()
        {

        }

        public Category(int categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }
    }
}