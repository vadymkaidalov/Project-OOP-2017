using System;
using System.IO;
using CourseProject2017.BLL;

namespace CourseProject2017.DAL
{
    static class DataAccess
    {
        public static ProductList ReadProductsFile()
        {
            ProductList list = new ProductList();
            TextReader sr = new StreamReader(@"..\..\Data\products.txt");
            int numberOfProducts = Convert.ToInt32(sr.ReadLine());
            for (int i = 0; i < numberOfProducts; i++)
            {
                string name = sr.ReadLine();
                double unitPrice = Convert.ToDouble(sr.ReadLine());
                //DateTime deliveryDate = Convert.ToDateTime(sr.ReadLine());
                bool discrete = Convert.ToBoolean(sr.ReadLine());
                double count = Convert.ToDouble(sr.ReadLine());
                list.Add(new Product(name, unitPrice, DateTime.Now, discrete, count));
            }
            return list;
        }
    }
}
