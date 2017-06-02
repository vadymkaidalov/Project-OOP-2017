using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.BLL
{
    class Purchase
    {
        public string Name
        {
            get
            {
                return ProductReference.Name;
            }
        }
        public string FormattedPrice
        {
            get
            {
                return String.Format("{0:0.00}", Price);
            }
        }
        public string Measure
        {
            get
            {
                return ProductReference.Measure;
            }
        }
        public string FormattedQuantity
        {
            get
            {
                return String.Format("{0:0.00}", Quantity);
            }
        }
        public string FormattedTotalSum
        {
            get
            {
                return String.Format("{0:0.00}", Quantity * Price);
            }
        }
        
        public double Price
        {
            get
            {
                return ProductReference.Price;
            }
        }

        public double Quantity { get; set; }

        public Product ProductReference;

        public Purchase (Product product, double quantity)
        {
            ProductReference = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return String.Format("{0,-30}{1,-10}{2,-10}{3,-10}", Name, FormattedPrice, FormattedQuantity, FormattedTotalSum);
        }
    }
}
