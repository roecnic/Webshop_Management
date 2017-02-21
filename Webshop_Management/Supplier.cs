using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_Management {
    class Supplier {

        private int pID;

        public int ID {
            get { return pID; }
        }

        private String pDescription;

        public String Description {
            get { return pDescription; }
            set { pDescription = value; }
        }

        private String pContact;

        public String Contact {
            get { return pContact; }
            set { pContact = value; }
        }

        private String pAddress;

        public String Address {
            get { return pAddress; }
            set { pAddress = value; }
        }

        private int pPLZ;

        public int PLZ {
            get { return pPLZ; }
            set { pPLZ = value; }
        }

        private int pCreditHistory;

        public int CreditHistory {
            get { return pCreditHistory; }
            set { pCreditHistory = value; }
        }


        public Supplier(int fID, String fDescription, String fContact, String fAddress, int fPLZ) {
            pID = fID;
            pDescription = fDescription;
            pContact = fContact;
            pAddress = fAddress;
            pPLZ = fPLZ;
        }
    }
}
