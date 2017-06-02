using CourseProject.BLL;
using System;
using System.IO;

namespace CourseProject.DAL
{
    static class DataAccess
    {
        public static ProductList ReadFile(string fileName)
        {
            ProductList productList = new ProductList();
            int numberOfProducts;
            string name;
            double price;
            string deliveryDate;
            double amount;
            string measure;
            DateTime parsedDateTime;
            
            try
            {
                using (TextReader reader = new StreamReader(fileName))
                {

                    numberOfProducts = int.Parse(reader.ReadLine());
                    
                    for (int i = 0; i < numberOfProducts; i++)
                    {
                        name = reader.ReadLine();
                        price = double.Parse(reader.ReadLine());
                        parsedDateTime = DateTime.ParseExact(
                            reader.ReadLine(),
                            StringConstant.DateParseFormat,
                            System.Globalization.CultureInfo.InvariantCulture);
                        deliveryDate = (parsedDateTime).ToString(
                            StringConstant.DateParseFormat);
                        amount = double.Parse(reader.ReadLine());
                        measure = reader.ReadLine();

                        if (measure == "шт")
                        {
                            productList.Add(
                                new DiscreteProduct(
                                    name, price, amount, deliveryDate));
                        }
                        else if (measure == "кг")
                        {
                            productList.Add(
                                new WeightProduct(
                                    name, price, amount, deliveryDate));
                        }
                        else if (measure == "л")
                        {
                            productList.Add(
                                new VolumeProduct(
                                    name, price, amount, deliveryDate));
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = String.Format(
          "Файл {0} находится в неправильном формате и не может быть прочтен.",
                    fileName);
                throw new ApplicationException(message, ex);
            }

            return productList;
        }

        public static void WriteFile(string fileName, ProductList prodList)
        {
            using (TextWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(prodList.Count);
                foreach (Product product in prodList)
                {
                    writer.WriteLine(product.ToString());
                }
            }
        }

        public static void WriteFile(string fileName, PurchaseList purcList)
        {
            string firstLine = "Время покупки: "
                + DateTime.Now.ToString(StringConstant.DateParseFormat);
            string secondLine = String.Format(
                "{0,-30}{1,-10}{2,-10}{3,-10}",
                "Наименование", "Цена", "Кол-во", "Сумма");
            string lastLine = String.Format(
                "{0,-50}{1,-10}",
                "Итого:", 
                purcList.FormattedCheckSum);

            using (TextWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(firstLine);
                writer.WriteLine(secondLine);
                foreach (Purchase purchase in purcList)
                {
                    writer.WriteLine(purchase.ToString());
                }
                writer.WriteLine(lastLine);
            }
        }
    }
}
