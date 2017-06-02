using CourseProject.BLL;
using System;
using System.IO;

namespace CourseProject.DAL
{
    static class DataAccess
    {
        public static ProductList ReadFile(string fileName)
        {
            try
            {
                ProductList productList = new ProductList();
                using (TextReader reader = new StreamReader(fileName))
                {
                    int numberOfProducts = int.Parse(reader.ReadLine());
                    
                    for (int i = 0; i < numberOfProducts; i++)
                    {
                        string name = reader.ReadLine();
                        double price = double.Parse(reader.ReadLine());
                        string deliveryDate = (DateTime.ParseExact(reader.ReadLine(), "dd/MM/yyyy HH:mm:ss", 
                            System.Globalization.CultureInfo.InvariantCulture)).ToString("dd/MM/yyyy HH:mm:ss");
                        double amount = double.Parse(reader.ReadLine());
                        string measure = reader.ReadLine();

                        if (measure == "шт")
                        {
                            productList.Add(new DiscreteProduct(name, price, amount, deliveryDate));

                        }
                        else if (measure == "кг")
                        {
                            productList.Add(new WeightProduct(name, price, amount, deliveryDate));
                        }
                        else if (measure == "л")
                        {
                            productList.Add(new VolumeProduct(name, price, amount, deliveryDate));
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                return productList;
            }
            catch (Exception ex)
            {
                string message = String.Format("Файл {0} находится в неправильном формате и не может быть прочтен.",
                    fileName);
                throw new ApplicationException(message, ex);
            }
        }

        public static void WriteFile(string fileName, ProductList productList)
        {
            using (TextWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(productList.Count);
                foreach (Product product in productList)
                {
                    writer.WriteLine(product.ToString());
                }
            }
        }

        public static void WriteFile(string fileName, PurchaseList purchaseList)
        {
            using (TextWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine("Время покупки: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.WriteLine(String.Format("{0,-30}{1,-10}{2,-10}{3,-10}", "Наименование", "Цена", "Кол-во", "Сумма"));
                foreach (Purchase purchase in purchaseList)
                {
                    writer.WriteLine(purchase.ToString());
                }
                writer.WriteLine(String.Format("{0,-50}{1,-10}", "Итого:", purchaseList.FormattedCheckSum));
            }
        }
    }
}
