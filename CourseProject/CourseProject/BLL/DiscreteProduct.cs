using System;

namespace CourseProject.BLL
{
    class DiscreteProduct : Product
    {
        public DiscreteProduct(string name, double price, double amount) 
            : base(name, price, amount)
        {

        }

        public DiscreteProduct(string nm, double pr, double amt, string date) 
            : base(nm, pr, amt, date)
        {

        }

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
    }
}
