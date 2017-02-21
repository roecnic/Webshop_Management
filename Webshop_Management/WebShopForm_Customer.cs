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
    public partial class WebShopForm_Customer : Form {

        private List<Customer> customerList = new List<Customer>();
        private String sortAlgorithm = "Lastname";

        public WebShopForm_Customer () {
            InitializeComponent();
            cbbxDatabase.SelectedIndex = 1;

            LoadItemsFromSQL();
            FillItemList();

            if (lstbxCustomers.Items.Count > 0)
                lstbxCustomers.SelectedIndex = 0;
        }

        /**
         * ---------------------------------------------------------------
         * STARTUP (FILL LISTS ETC.)
         * ---------------------------------------------------------------
         */

        private void LoadItemsFromSQL () {
            //LOAD CUSTOMERS FROM SQL
            customerList.Add(new Customer(0, "Peter", "Sommer", 12345, "Vreden", 'M'));
            customerList.Add(new Customer(1, "Nicolas", "Röchter", 48653, "Coesfeld", 'M'));
            customerList.Add(new Customer(2, "Tobias", "Groten", 48683, "Ahaus", 'M'));
        }

        private void FillItemList () {
            lstbxCustomers.Items.Clear();
            if (sortAlgorithm.Equals("Lastname"))
                customerList.Sort((x, y) => x.Lastname.CompareTo(y.Lastname));
            else if (sortAlgorithm.Equals("ID"))
                customerList.Sort((x, y) => x.ID.CompareTo(y.ID));

            foreach (var currentCustomer in customerList)
                lstbxCustomers.Items.Add(currentCustomer.ID + " - " + currentCustomer.Lastname + ", " + currentCustomer.Firstname);
        }

    }
}
