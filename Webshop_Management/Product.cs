using System;

namespace Webshop_Management {
    class Product {

        String description = "";
        String name = "";
        int anzahl = 0;

        public String Description {
            get { return this.description; }
            set { this.description = value; }
        }

        public String Name {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Anzahl {
            get { return this.anzahl; }
            set { this.anzahl = value; }
        }


        //CONSTRUCTOR
        public Product(String pName) {
            this.name = pName;
        }

        public Product(String pName, int pAnzahl) {
            this.name = pName;
            this.anzahl = pAnzahl;
        }

        public Product(String pName, String pDescription) {
            this.name = pName;
            this.description = pDescription;
        }

        public Product(String pName, String pDescription, int pAnzahl) {
            this.name = pName;
            this.description = pDescription;
            this.anzahl = pAnzahl;
        }
    }
}
