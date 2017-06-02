using System;

namespace CourseProject.BLL
{
    class VolumeProduct : Product
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
                return "л";
            }
        }

        public override bool IsDiscrete
        {
            get
            {
                return false;
            }
        }

        public VolumeProduct(string name, double price, double amount) : base(name, price, amount)
        {

        }

        public VolumeProduct(string name, double price, double amount, string deliveryDate) : base(name, price, amount, deliveryDate)
        {

        }
    }
}
