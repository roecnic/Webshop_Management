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
    public partial class WebShopForm_ClosedOrders : Form {

        List<Order> completetOrderList = new List<Order>();

        public WebShopForm_ClosedOrders () {
            InitializeComponent();
            cbbxDatabase.SelectedIndex = 3;

            if (lstbxCompletedOrders.Items.Count > 0)
                lstbxCompletedOrders.SelectedIndex = 0;

            LoadItemsFromSQL();
            FillItemList();
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
                    var newForm_OpenOrders = new WebShopForm_OpenOrders();
                    this.Hide();
                    newForm_OpenOrders.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    //THIS FORM
                    break;
                case 4:
                    var newForm_Suppliers = new WebShopForm_Suppliers();
                    this.Hide();
                    newForm_Suppliers.ShowDialog();
                    this.Close();
                    break;
            }
        }


        private void lstbxCompletedOrders_SelectedIndexChanged (object sender, EventArgs e) {
            var currentOrder = completetOrderList.ElementAt(lstbxCompletedOrders.SelectedIndex);
            var customerID = Convert.ToInt32(tbxCurrentCompletedOrderCustomer.Text);

            //SEARCH CUSTOMER FROM SQL VIA ID

            tbxCurrentCompletedOrderCustomer.Text = "" + customerID;
            tbxCurrentCompletedOrderDate.Text = currentOrder.CompletedDate;
            tbxCompletedOrdersBillingNumber.Text = "" + currentOrder.BillingNumber;
        }


        private void FillItemList () {
            lstbxCompletedOrders.Items.Clear();
            completetOrderList.Sort((x, y) => x.BillingNumber.CompareTo(y.BillingNumber));

            foreach (var currentOrder in completetOrderList)
                lstbxCompletedOrders.Items.Add(currentOrder.BillingNumber);
        }

        private void LoadItemsFromSQL () {
            //LOAD COMPLETED ORDERS FROM SQL
        }


    }
}
