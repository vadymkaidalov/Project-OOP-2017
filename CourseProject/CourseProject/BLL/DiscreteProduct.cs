using System;

namespace CourseProject.BLL
{
    class DiscreteProduct : Product
    {
        public override string FormattedAmount
        {
            get
            {
                return String.Format("{0}", (int)Math.Round(Amount));
            }
        }

        public override string Measure
        {
            get
            {
                return "шт";
            }
        }
        
        public override bool IsDiscrete
        {
            get
            {
                return true;
            }
        }

        public DiscreteProduct(string name, double price, double amount) : base(name, price, amount)
        {

        }

        public DiscreteProduct(string name, double price, double amount, string deliveryDate) : base(name, price, amount, deliveryDate)
        {

        }
    }
}
