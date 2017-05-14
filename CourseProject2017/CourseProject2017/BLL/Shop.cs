using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseProject2017.DAL;

namespace CourseProject2017.BLL
{
    class Shop
    {
        public ProductList productList = new ProductList();

        public Shop()
        {
            productList = DataAccess.ReadProductsFile();
        }
    }
}
