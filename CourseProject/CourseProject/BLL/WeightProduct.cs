using System;

namespace CourseProject.BLL
{
    class WeightProduct : Product
    {
        public WeightProduct(string name, double price, double amount) 
            : base(name, price, amount)
        {

        }

        public WeightProduct(string name, double pr, double amt, string date) 
            : base(name, pr, amt, date)
        {

        }

        public override string FormattedAmount
        {
            get
            {
                return String.Format("{0:0.000}", Amount);
            }
        }

        public override bool IsDiscrete
        {
            get
            {
                return false;
            }
        }

        public override string Measure
        {
            get
            {
                return "кг";
            }
        }
    }
}
