using System;
using System.Collections.Generic;
using System.Linq;

namespace Webshop_Management {
    class Order {

        private List<Product> productList = new List<Product>();

        private int pID;

        public int ID {
            get { return pID; }
        }

        private int pCustomerID;

        public int CustomerID {
            get { return pCustomerID; }
            set { pCustomerID = value; }
        }

        private int pBillingNumber;

        public int BillingNumber {
            get { return pBillingNumber; }
            set { pBillingNumber = value; }
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

        public Order (int fID, int fBillingNumber, int fCustomerID) {
            pID = fID;
            pBillingNumber = fBillingNumber;
            pCustomerID = fCustomerID;
            pOrderDate = "" + DateTime.Now;
        }

        public Product GetProduct (int fPosition) {
            return productList.ElementAt(fPosition);
        }

        public void NewProduct (Product fProduct) {
            productList.Add(fProduct);
        }

        public int ProductListLength () {
            return productList.Count;
        }
    }
}
