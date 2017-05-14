using System;

namespace CourseProject2017.BLL
{
    class Product
    {
        string name;
        double unitPrice;
        DateTime deliveryDate;
        bool discrete;
        double count;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public bool Discrete
        {
            get { return discrete; }
            set { discrete = value; }
        }

        public double Count
        {
            get { return count; }
            set { count = value; }
        }

        public Product(string name, double unitPrice, DateTime deliveryDate, bool discrete, double count)
        {
            this.name = name;
            this.unitPrice = unitPrice;
            this.deliveryDate = deliveryDate;
            this.discrete = discrete;
            this.count = count;
        }
    }
}
