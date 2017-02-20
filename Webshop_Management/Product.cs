using System;

namespace Webshop_Management {
    class Product {

        private int pID;

        public int ID {
            get { return pID; }
        }

        private String pDescription;

        public String Description {
            get { return pDescription; }
            set { pDescription = value; }
        }

        private String pName;

        public String Name {
            get { return pName; }
            set { pName = value; }
        }

        private int pAmount;

        public int Amount {
            get { return pAmount; }
            set { pAmount = value; }
        }

        private Boolean pRemoved;
        
        public Boolean Removed {
            get { return pRemoved; }
            set { pRemoved = value; }
        }


        //CONSTRUCTOR
        public Product(int fID, String fName, String fDescription, int fAmount) {
            pID = fID;
            pName = fName;
            pDescription = fDescription;
            pAmount = fAmount;

            pRemoved = false;
        }

        public Product(int fID, String fName, int fAmount) {
            pID = fID;
            pName = fName;
            pAmount = fAmount;
        }
    }
}
