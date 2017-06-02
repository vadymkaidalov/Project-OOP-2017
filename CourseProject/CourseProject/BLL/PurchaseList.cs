using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.BLL
{
    class PurchaseList : List<Purchase>
    {
        public string FormattedCheckSum
        {
            get
            {
                double sum = 0;
                foreach(Purchase purchase in this)
                {
                    sum += purchase.Price * purchase.Quantity;
                }
                return String.Format("{0:0.00}", sum);
            }
        }
    }
}
