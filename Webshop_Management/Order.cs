using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_Management {
    class Order {

        private int pID;

        public int ID {
            get { return pID; }
        }

        private int pProductID;

        public int ProductID {
            get { return pProductID; }
        }

        private int pCustomerID;

        public int CustomerID {
            get { return pCustomerID; }
        }

        private int pBillingNumber;

        public int BillingNumber {
            get { return pBillingNumber; }
        }

        private String pOrderDate;

        public String OrderDate {
            get { return pOrderDate; }
        }


        public Order(int fID, int fProductID, int fCustomerID, int fBillingNumber, String fOrderDate) {
            pID = fID;
            pProductID = fProductID;
            pCustomerID = fCustomerID;
            pBillingNumber = fBillingNumber;
            pOrderDate = fOrderDate;
        }
    }
}
