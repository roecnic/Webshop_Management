using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_Management {
    class Order {

        private List<int> pProductID = new List<int>();

        private int pID;

        public int ID {
            get { return pID; }
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

        private String pCompletedDate;

        public String CompletedDate {
            get { return pCompletedDate; }
            set { pCompletedDate = value; }
        }

        private char pClosed;

        public char Closed {
            get { return pClosed; }
            set { pClosed = value; }
        }

        public Order(int fID, int fProductID, int fCustomerID, int fBillingNumber) {
            pID = fID;
            pProductID.Add(fProductID);
            pCustomerID = fCustomerID;
            pBillingNumber = fBillingNumber;
            pOrderDate = "" + DateTime.Now;
        }
    }
}
