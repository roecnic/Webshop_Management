using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Webshop_Management {
    public partial class WebShopForm_OpenOrders : Form {

        private List<Order> openOrderList = new List<Order>();
        private List<Product> productList = new List<Product>();
        private List<Product> shoppingCartProductList = new List<Product>();
        private List<Customer> customerList = new List<Customer>();


        public WebShopForm_OpenOrders () {
            InitializeComponent();
            cbbxDatabase.SelectedIndex = 2;

            if (lstbxOrders.Items.Count > 0)
                lstbxOrders.SelectedIndex = 0;

            LoadItemsFromSQL();

            FillItemList();
        }

        /**
         * ---------------------------------------------------------------------------------------------------
         * STARTUP (FILL LISTS ETC.)
         * ---------------------------------------------------------------------------------------------------
         */
        private void FillItemList () {
            lstbxOrders.Items.Clear();
            openOrderList.Sort((x, y) => x.BillingNumber.CompareTo(y.BillingNumber));

            foreach (var currentOrder in openOrderList)
                lstbxOrders.Items.Add(currentOrder.BillingNumber);

            cbxNewOrderProduct.Items.Clear();
            cbxNewOrderProduct.Items.Add(productList.ElementAt(0).Name);
            cbxNewOrderProduct.Items.Add(productList.ElementAt(1).Name);

            cbxNewOrderCustomer.Items.Clear();
            cbxNewOrderCustomer.Items.Add(customerList.ElementAt(0).Lastname + ", " + customerList.ElementAt(0).Firstname);
            cbxNewOrderCustomer.Items.Add(customerList.ElementAt(1).Lastname + ", " + customerList.ElementAt(1).Firstname);
        }

        private void LoadItemsFromSQL () {
            //LOAD ORDERS FROM SQL
            productList.Add(new Product(1, "Obst", "Es ist Obst im Haus!", 5));
            productList.Add(new Product(2, "Gemüse", "GRÜÜÜÜN", 4));

            customerList.Add(new Customer(0, "Bernhard", "Hoecker", 48653, "Am Stockkamp 24a", 'M'));
            customerList.Add(new Customer(1, "Peter", "Sommer", 45612, "Vreden", 'M'));
        }


        /**
         * ------------------------------------------------------------------------------------------------- 
         * HELPING METHODS
         * --------------------------------------------------------------------------------------------------
         */

        private int GetProductIDByName(String pProductName) {
            foreach(var currentProduct in productList) {
                if (pProductName.Equals(currentProduct.Name))
                    return currentProduct.ID;
            }

            return -1;
        }

        private String GetProductNameByID(int pID) {
            foreach(var currentProduct in productList) {
                if (currentProduct.ID == pID)
                    return currentProduct.Name;
            }

            return "";
        }

        private int GetCustomerIDByName(String pCustomerName) {
            var commataPosition = pCustomerName.IndexOf(',');
            var lastname = pCustomerName.Substring(0, commataPosition);
            var firstname = pCustomerName.Substring((commataPosition + 2));

            foreach(var currentCustomer in customerList) {
                if (currentCustomer.Firstname.Equals(firstname) && currentCustomer.Lastname.Equals(lastname))
                    return currentCustomer.ID;
            }

            return -1;
        }

        private String GetCustomerNameByID(int pID) {
            foreach(var currentCustomer in customerList) {
                if (currentCustomer.ID == pID)
                    return currentCustomer.Lastname + ", " + currentCustomer.Firstname;
            }

            return "";
        }


        /**
         * -----------------------------------------------------------------------------------------------------------
         * EVENTS
         * -----------------------------------------------------------------------------------------------------------
         */

        private void lstbxOrders_SelectedIndexChanged (object sender, EventArgs e) {
            var currentOrder = openOrderList.ElementAt(lstbxOrders.SelectedIndex);
            tbxCurrentOrderCustomer.Text = "" + currentOrder.CustomerID; //Replace with Customer Name from SQL
            tbxCurrentOrderCreateTime.Text = currentOrder.OrderDate;

            for (int i = 0; i < currentOrder.ProductIDListLength(); i++) {
                clstbxCurrentOrderCart.Items.Add(currentOrder.GetProductID(i)); //Replace with Product Name from SQL
            }
        }

        private void btnNewOrderAddProduct_Click (object sender, EventArgs e) {
            try {
                var newOrderCustomerID = cbxNewOrderCustomer.SelectedIndex;
                var newOrderCustomer = cbxNewOrderCustomer.Text;
                var newOrderProductID = (cbxNewOrderProduct.SelectedIndex + 1);
                var newOrderProduct = cbxNewOrderProduct.Text;
                var newOrderProductAmount = Convert.ToInt32(tbxNewOrderProductAmount.Text);
                var currentProductAlreadyInCart = false;

                if (!newOrderCustomer.Equals("<Bitte auswählen>") && !newOrderProduct.Equals("<Bitte auswählen>")) {
                    for (int i = 0; i < clstbxShoppingCart.Items.Count; i++) {
                        clstbxShoppingCart.SelectedIndex = i;
                        var currentEntry = clstbxShoppingCart.SelectedItem;
                        var currentEntryString = currentEntry.ToString();

                        if (currentEntryString.StartsWith(newOrderProduct)) {
                            var subStringStart = currentEntryString.LastIndexOf(' ');
                            var currentEntryAmount = Convert.ToInt32(currentEntryString.Substring(subStringStart));

                            var result = MessageBox.Show("Das Produkt ist bereits " + currentEntryAmount + " Mal im Warenkorb. Möchten Sie die Anzahl addieren?",
                                "Hinweis", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes) {
                                newOrderProductAmount += currentEntryAmount;
                                clstbxShoppingCart.Items.RemoveAt(i);

                                clstbxShoppingCart.Refresh();

                                clstbxShoppingCart.Items.Insert(i, newOrderProduct + " - " + newOrderProductAmount);
                                currentProductAlreadyInCart = true;
                            }
                        }
                    }

                    if (clstbxShoppingCart.Items.Count == 0 || currentProductAlreadyInCart == false) {
                        clstbxShoppingCart.Items.Add(newOrderProduct + " - " + newOrderProductAmount);
                    }

                    //var newOrder = new Order(openOrderList.Count, newOrderProduct, newOrderCustomer, 100002);

                    tbxNewOrderProductAmount.Text = "";

                } else
                    MessageBox.Show("Bitte einen Kunden und ein Produkt auswählen.", "Hinweis", MessageBoxButtons.OK);

            }
            catch (FormatException) {
                MessageBox.Show("Bitte eine gültige Anzahl eingeben.", "Hinweis", MessageBoxButtons.OK);
            }
        }

        private void btnRemoveSelectedProducts_Click (object sender, EventArgs e) {
            List<object> deleteList = new List<object>();

            foreach (var checkedItem in clstbxShoppingCart.CheckedItems) {
                deleteList.Add(checkedItem);
            }

            foreach (var checkedItem in deleteList) {
                clstbxShoppingCart.Items.Remove(checkedItem);
            }

            deleteList = null;
            clstbxShoppingCart.Refresh();
        }
    }
}
