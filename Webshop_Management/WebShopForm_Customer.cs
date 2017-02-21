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

        /**
         * ---------------------------------------------------------------
         * HELPING METHODS
         * ---------------------------------------------------------------
         */

        private Customer GetCustomerFromName (String fName) {
            var commataIndex = fName.IndexOf(',');
            var IDEndIndex = fName.IndexOf('-');
            var customerLastname = fName.Substring(IDEndIndex + 2, (commataIndex - IDEndIndex) - 2);
            var customerFirstname = fName.Substring(commataIndex + 2);

            foreach (var currentCustomer in customerList) {
                if (currentCustomer.Lastname.Equals(customerLastname) && currentCustomer.Firstname.Equals(customerFirstname))
                    return currentCustomer;
            }

            return null;
        }


        /**
         * ---------------------------------------------------------------
         * EVENT TRIGGERS
         * ---------------------------------------------------------------
         */

        private void cbbxDatabase_SelectedIndexChanged (object sender, EventArgs e) {
            switch (cbbxDatabase.SelectedIndex) {
                case 0:
                    var newForm_Products = new WebShopForm_Products();
                    this.Hide();
                    newForm_Products.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    //THIS FORM
                    break;
                case 2:
                    var newForm_OpenOrders = new WebShopForm_OpenOrders();
                    this.Hide();
                    newForm_OpenOrders.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    var newForm_ClosedOrders = new WebShopForm_ClosedOrders();
                    this.Hide();
                    newForm_ClosedOrders.ShowDialog();
                    this.Close();
                    break;
                case 4:
                    var newForm_Suppliers = new WebShopForm_Suppliers();
                    this.Hide();
                    newForm_Suppliers.ShowDialog();
                    this.Close();
                    break;
            }
        }

        private void lstbxCustomers_SelectedIndexChanged (object sender, EventArgs e) {
            var currentCustomer = GetCustomerFromName(lstbxCustomers.SelectedItem.ToString());

            tbxCurrentCustomerID.Text = "" + currentCustomer.ID;
            tbxCurrentCustomerFirstname.Text = currentCustomer.Firstname;
            tbxCurrentCustomerLastname.Text = currentCustomer.Lastname;
            tbxCurrentCustomerPLZ.Text = "" + currentCustomer.PLZ;
            tbxCurrentCustomerAddress.Text = currentCustomer.Address;
            if (currentCustomer.Sex == 'M')
                tbxCurrentCustomerSex.Text = "Männlich";
            else
                tbxCurrentCustomerSex.Text = "Weiblich";
        }

    }
}
