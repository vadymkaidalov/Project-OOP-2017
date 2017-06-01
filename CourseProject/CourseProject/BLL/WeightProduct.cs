using System;

namespace CourseProject.BLL
{
    class WeightProduct : Product
    {
        public override string FormattedAmount
        {
            get
            {
                return String.Format("{0:0.000}", Amount);
            }
        }

        public override string Measure
        {
            get
            {
                return "кг";
            }
        }

        public WeightProduct(string name, double price, double amount) : base(name, price, amount)
        {

        }

        public WeightProduct(string name, double price, double amount, string deliveryDate) : base(name, price, amount, deliveryDate)
        {

        }
    }
}
