﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        private int GetProductIDByName (String pProductName) {
            foreach (var currentProduct in productList) {
                if (pProductName.Equals(currentProduct.Name))
                    return currentProduct.ID;
            }

            return -1;
        }

        private String GetProductNameByID (int pID) {
            foreach (var currentProduct in productList) {
                if (currentProduct.ID == pID)
                    return currentProduct.Name;
            }

            return "";
        }

        private int GetCustomerIDByName (String pCustomerName) {
            var commataPosition = pCustomerName.IndexOf(',');
            var lastname = pCustomerName.Substring(0, commataPosition);
            var firstname = pCustomerName.Substring((commataPosition + 2));

            foreach (var currentCustomer in customerList) {
                if (currentCustomer.Firstname.Equals(firstname) && currentCustomer.Lastname.Equals(lastname))
                    return currentCustomer.ID;
            }

            return -1;
        }

        private String GetCustomerNameByID (int pID) {
            foreach (var currentCustomer in customerList) {
                if (currentCustomer.ID == pID) {
                    return currentCustomer.Lastname + ", " + currentCustomer.Firstname;
                }
            }

            return "";
        }

        private void RefreshShoppingCart () {
            clstbxShoppingCart.Items.Clear();
            foreach (var currentItem in shoppingCartProductList)
                clstbxShoppingCart.Items.Add(currentItem.Name + " - " + currentItem.Amount);
        }

        private void RefreshOrderList () {
            lstbxOrders.Items.Clear();
            foreach (var currentOrder in openOrderList)
                if (currentOrder.Closed != 'Y')
                    lstbxOrders.Items.Add(currentOrder.BillingNumber + '\t' + GetCustomerNameByID(currentOrder.CustomerID));
        }

        private int GetShoppingCartIndexForProductID (int fID) {
            for (int i = 0; i < shoppingCartProductList.Count; i++) {
                if (shoppingCartProductList.ElementAt(i).ID == fID)
                    return i;
            }

            return -1;
        }

        private bool BillingNumberIsAlreadyInUse (int fBillingNumber) {
            foreach (var currentOrder in openOrderList) {
                if (currentOrder.BillingNumber == fBillingNumber)
                    return true;
            }

            return false;
        }


        /**
         * -----------------------------------------------------------------------------------------------------------
         * EVENTS
         * -----------------------------------------------------------------------------------------------------------
         */

        private void lstbxOrders_SelectedIndexChanged (object sender, EventArgs e) {
            clstbxCurrentOrderCart.Items.Clear();

            var currentOrder = openOrderList.ElementAt(lstbxOrders.SelectedIndex);
            tbxCurrentOrderCustomer.Text = GetCustomerNameByID(currentOrder.CustomerID); //Replace with Customer Name from SQL
            tbxCurrentOrderCreateTime.Text = currentOrder.OrderDate;

            for (int i = 0; i < currentOrder.ProductListLength(); i++) {
                if (currentOrder.GetProduct(i).ID > 0)
                    clstbxCurrentOrderCart.Items.Add(currentOrder.GetProduct(i).ID + " - " + currentOrder.GetProduct(i).Name +
                        '\t' + currentOrder.GetProduct(i).Amount + " Einheiten"); //Replace with Product Name from SQL
            }
        }

        private void btnNewOrderAddProduct_Click (object sender, EventArgs e) {
            try {
                var newOrderProductID = cbxNewOrderProduct.SelectedIndex + 1;
                var newOrderProduct = GetProductNameByID(newOrderProductID);

                var newOrderProductAmount = Convert.ToInt32(tbxNewOrderProductAmount.Text);
                var inserted = false;

                if (!cbxNewOrderCustomer.Text.Equals("<Bitte auswählen>") && !newOrderProduct.Equals("<Bitte auswählen>")) {
                    var newProduct = new Product(newOrderProductID, newOrderProduct, newOrderProductAmount);

                    foreach (var currentProduct in shoppingCartProductList) {
                        if (currentProduct.ID == newProduct.ID) {
                            var result = MessageBox.Show("Das Produkt ist bereits " + currentProduct.Amount + " Mal im Warenkorb. Möchten Sie die Anzahl addieren?",
                                "Hinweis", MessageBoxButtons.YesNo);

                            if (result == DialogResult.Yes) {
                                currentProduct.Amount += newProduct.Amount;
                                RefreshShoppingCart();
                            }

                            inserted = true;
                        }
                    }

                    if (clstbxShoppingCart.Items.Count == 0 || !inserted) {
                        shoppingCartProductList.Add(newProduct);
                        RefreshShoppingCart();
                    }

                    tbxNewOrderProductAmount.Text = "";

                } else
                    MessageBox.Show("Bitte einen Kunden und ein Produkt auswählen.", "Hinweis", MessageBoxButtons.OK);

            }
            catch (FormatException) {
                MessageBox.Show("Bitte eine gültige Anzahl eingeben.", "Hinweis", MessageBoxButtons.OK);
            }
        }

        private void btnRemoveSelectedProducts_Click (object sender, EventArgs e) {
            foreach (var currentItem in clstbxShoppingCart.CheckedItems) {
                var currentItemID = GetProductIDByName(currentItem.ToString().Substring(0, (currentItem.ToString().IndexOf('-') - 1)));
                shoppingCartProductList.RemoveAt(GetShoppingCartIndexForProductID(currentItemID));
            }

            RefreshShoppingCart();
        }

        private void btnCreateNewOrder_Click (object sender, EventArgs e) {
            if (cbxNewOrderCustomer.Text.Equals("<Bitte auswählen>") || clstbxShoppingCart.Items.Count == 0)
                MessageBox.Show("Bitte einen Kunden auswählen und Produkte in den Einkaufswagen legen!", "Hinweis", MessageBoxButtons.OK);
            else {
                var newOrderCustomerID = GetCustomerIDByName(cbxNewOrderCustomer.Text);

                var newBillingNumber = (100000 + openOrderList.Count);
                while (BillingNumberIsAlreadyInUse(newBillingNumber))
                    newBillingNumber++;

                var newOrder = new Order(openOrderList.Count, newBillingNumber, newOrderCustomerID);

                foreach (var currentProduct in shoppingCartProductList) {
                    newOrder.NewProduct(currentProduct);
                }

                openOrderList.Add(newOrder);
                RefreshOrderList();

                cbxNewOrderCustomer.ResetText();
                cbxNewOrderProduct.ResetText();

                shoppingCartProductList.Clear();
                RefreshShoppingCart();

                lstbxOrders.SelectedIndex = lstbxOrders.Items.Count - 1;
            }
        }

        private void btnCurrentOrderRemoveProduct_Click (object sender, EventArgs e) {
            var result = MessageBox.Show("Möchten Sie die ausgewählten Produkte wirklich aus der Bestellung entfernen?", "Hinweis", MessageBoxButtons.YesNo);
            var currentOrder = openOrderList.ElementAt(lstbxOrders.SelectedIndex);

            if (result == DialogResult.Yes) {
                foreach (var currentItem in clstbxCurrentOrderCart.SelectedItems) {
                    var currentItemID = GetProductIDByName(currentItem.ToString().Substring(0, (currentItem.ToString().IndexOf('-') - 1)));
                    currentOrder.RemoveProduct(currentItemID);
                }

                clstbxCurrentOrderCart.Items.Clear();

                if (currentOrder.ProductListLength() > 0) {
                    for (int i = 0; i < currentOrder.ProductListLength(); i++) {
                        clstbxCurrentOrderCart.Items.Add(currentOrder.GetProduct(i));
                    }
                } else {
                    var deleteOrderResult = MessageBox.Show("Das war das letzte Produkt in der Bestellung. Soll die Bestellung gelöscht werden?", "Hinweis", MessageBoxButtons.YesNo);
                    if (deleteOrderResult == DialogResult.Yes) {
                        openOrderList.Remove(currentOrder);
                    }
                }

                RefreshOrderList();
                lstbxOrders.SelectedIndex = lstbxOrders.Items.Count - 1;
            }
        }

        private void btnCurrentOrderDelete_Click (object sender, EventArgs e) {
            var result = MessageBox.Show("Soll die Bestellung wirklich storniert werden?", "Hinweis", MessageBoxButtons.YesNo);
            var currentOrder = openOrderList.ElementAt(lstbxOrders.SelectedIndex);

            if (result == DialogResult.Yes) {
                openOrderList.Remove(currentOrder);
                RefreshOrderList();
                lstbxOrders.SelectedIndex = lstbxOrders.Items.Count - 1;

                tbxCurrentOrderCustomer.ResetText();
                tbxCurrentOrderCreateTime.ResetText();
                clstbxCurrentOrderCart.Items.Clear();
            }
        }

        private void btnCurrentOrderClose_Click (object sender, EventArgs e) {
            var currentOrder = openOrderList.ElementAt(lstbxOrders.SelectedIndex);
            var result = MessageBox.Show("Soll die Bestellung wirklich abgeschlossen werden?", "Hinweis", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) {
                currentOrder.Closed = 'Y';
                RefreshOrderList();
                lstbxOrders.SelectedIndex = lstbxOrders.Items.Count - 1;

                tbxCurrentOrderCustomer.ResetText();
                tbxCurrentOrderCreateTime.ResetText();
                clstbxCurrentOrderCart.Items.Clear();
            }
        }

        private void cbbxDatabase_SelectedIndexChanged (object sender, EventArgs e) {
            switch (cbbxDatabase.SelectedIndex) {
                case 0:
                    var newForm_Products = new WebShopForm_Products();
                    this.Hide();
                    newForm_Products.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    var newForm_Customers = new WebShopForm_Customer();
                    this.Hide();
                    newForm_Customers.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    //THIS FORM
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
    }
}
