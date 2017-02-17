using System;

namespace Webshop_Management {
    class Order {

        private int[] pProductArray = new int[20];
        private int[] pProductAmountArray = new int[20];

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

        //public Order(int fID, int fProductID, int fCustomerID, int fBillingNumber) {
        //    pID = fID;
        //    pProductIDList.Add(fProductID);
        //    pCustomerID = fCustomerID;
        //    pBillingNumber = fBillingNumber;
        //    pOrderDate = "" + DateTime.Now;
        //}

        public Order (int fID) {
            pID = fID;
            pOrderDate = "" + DateTime.Now;
        }

        public int GetProductID (int fPosition) {
            return pProductArray[fPosition];
        }

        public void NewProductID (int fID) {
            var inserted = false;
            for (int i = 0; i < pProductArray.Length && !inserted; i++) {
                if(pProductArray[i] == 0)
                    pProductArray[i] = fID;
            }
        }

        public int GetProductAmount(int fPosition) {
            return pProductAmountArray[fPosition];
        }

        public void NewProductAmount (int fAmount) {
            var inserted = false;
            for (int i = 0; i < pProductArray.Length && !inserted; i++) {
                if (pProductAmountArray[i] == 0)
                    pProductAmountArray[i] = fAmount;
            }
        }

        public int ProductIDListLength () {
            return pProductArray.Length;
        }
    }
}
