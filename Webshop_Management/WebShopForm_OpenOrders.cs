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
    public partial class WebShopForm_OpenOrders : Form {

        List<Order> openOrderList = new List<Order>();

        public WebShopForm_OpenOrders () {
            InitializeComponent();
            cbbxDatabase.SelectedIndex = 2;

            if (lstbxOrders.Items.Count > 0)
                lstbxOrders.SelectedIndex = 0;

            LoadItemsFromSQL();
            FillItemList();
        }

        private void FillItemList () {
            lstbxOrders.Items.Clear();
            openOrderList.Sort((x, y) => x.BillingNumber.CompareTo(y.BillingNumber));

            foreach (var currentOrder in openOrderList)
                lstbxOrders.Items.Add(currentOrder.BillingNumber);
        }

        private void LoadItemsFromSQL () {
            //LOAD COMPLETED ORDERS FROM SQL
        }

        private void lstbxOrders_SelectedIndexChanged (object sender, EventArgs e) {
            var currentOrder = openOrderList.ElementAt(lstbxOrders.SelectedIndex);
            tbxCurrentOrderCustomer.Text = "" + currentOrder.CustomerID; //Replace with Customer Name from SQL
            tbxCurrentOrderCreateTime.Text = currentOrder.OrderDate;

            for (int i = 0; i < currentOrder.ProductIDListLength(); i++) {
                clstbxCurrentOrderCart.Items.Add(currentOrder.GetProductID(i)); //Replace with Product Name from SQL
            }
        }
    }
}
