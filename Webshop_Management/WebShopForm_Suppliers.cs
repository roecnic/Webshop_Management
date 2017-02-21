using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webshop_Management {
    public partial class WebShopForm_Suppliers : Form {

        private List<Supplier> supplierList = new List<Supplier>();
        private String sortAlgorithm = "Description";

        public WebShopForm_Suppliers () {
            InitializeComponent();
            cbbxDatabase.SelectedIndex = 4;

            LoadItemsFromSQL();
            FillItemList();

            if (lstbxSuppliers.Items.Count > 0)
                lstbxSuppliers.SelectedIndex = 0;
        }

        /**
         * ----------------------------------------------------------
         * HELPING METHODS
         * ----------------------------------------------------------
         */

        private void LoadItemsFromSQL () {
            //LOAD SUPPLIERS FROM SQL
            supplierList.Add(new Supplier(0, "Mindfactory AG", "Irgendwasstraße 5", 456123));
            supplierList.Add(new Supplier(1, "Amazon DACH", "Uhm... Bonn?", 4556987));
        }

        private void FillItemList () {
            lstbxSuppliers.Items.Clear();
            if (sortAlgorithm.Equals("Description"))
                supplierList.Sort((x, y) => x.Description.CompareTo(y.Description));
            else if (sortAlgorithm.Equals("ID"))
                supplierList.Sort((x, y) => x.ID.CompareTo(y.ID));

            foreach (var currentSupplier in supplierList)
                lstbxSuppliers.Items.Add(currentSupplier.ID + " - " + currentSupplier.Description);
        }


        /**
         * ---------------------------------------------------------
         * EVENT TRIGGERS
         * ---------------------------------------------------------
         */

        private void btnSortLastname_Click (object sender, EventArgs e) {
            sortAlgorithm = "Description";
            FillItemList();
        }

        private void btnSortID_Click (object sender, EventArgs e) {
            sortAlgorithm = "ID";
            FillItemList();
        }
    }
}
