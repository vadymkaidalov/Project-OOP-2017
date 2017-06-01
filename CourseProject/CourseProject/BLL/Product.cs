using System;

namespace CourseProject.BLL
{
    abstract class Product
    {
        private string name;
        private double price;
        private string deliveryDate;
        private double amount;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public abstract string FormattedAmount { get; }

        public abstract string Measure { get; }

        public Product(string name, double price, double amount)
        {
            this.name = name;
            this.price = price;

            DateTime localDate = DateTime.Now;
            deliveryDate = localDate.ToString("ru-RU");

            this.amount = amount;
        }

        public Product (string name, double price, double amount, string deliveryDate)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.deliveryDate = deliveryDate;
        }

        public override string ToString()
        {
            string textInfo = String.Format(
                "{0}\n{1}\n{2}\n{3}\n{4}",
                name, price, deliveryDate, amount, Measure);
            return textInfo;
        }
    }
}
