using System;

namespace Webshop_Management {
    class Customer {

        private int pID;

        public int ID {
            get { return pID; }
        }

        private String pFirstname;

        public String Firstname {
            get { return pFirstname; }
            set { pFirstname = value; }
        }

        private String pLastname;

        public String Lastname {
            get { return pLastname; }
            set { pLastname = value; }
        }

        private int pPLZ;

        public int PLZ {
            get { return pPLZ; }
            set { pPLZ = value; }
        }

        private String pAddress;

        public String Address {
            get { return pAddress; }
            set { pAddress = value; }
        }

        private char pSex;

        public char Sex {
            get { return pSex; }
            set { pSex = value; }
        }

        private double pRenevues;

        public double Renevues {
            get { return pRenevues; }
            set { pRenevues = value; }
        }


        public Customer(int fID, String fFirstname, String fLastname, int fPLZ, String fAddress, char fSex) {
            pID = fID;
            pFirstname = fFirstname;
            pLastname = fLastname;
            pPLZ = fPLZ;
            pAddress = fAddress;
            pSex = fSex;
        }
    }
}
