using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Webshop_Management {
    public partial class WebShopForm_Products : Form {

        List<Product> productList = new List<Product>();

        public WebShopForm_Products () {
            InitializeComponent();
            cbbxDatabase.SelectedIndex = 0;

            if (lstbxProducts.Items.Count > 0) 
                lstbxProducts.SelectedIndex = 0;

            LoadItemsFromSQL();
            FillItemList();
        }

        private void btnSaveNewItem_Click (object sender, EventArgs e) {
            try {

                var vItemName = "";
                var vItemDescription = "";
                int vItemAmount = 0;
                var result = DialogResult.Yes;

                if (tbxNewProductName.Text != "") {
                    vItemName = "" + tbxNewProductName.Text;

                    if (tbxNewProductDescription.Text == "") {
                        result = MessageBox.Show("Soll das Produkt ohne Beschreibung gespeichert werden?", "Warnung", MessageBoxButtons.YesNo);
                    }

                    if (result == DialogResult.Yes) {
                        vItemDescription = "" + tbxNewProductDescription.Text;

                        if (tbxNewProductAmount.Text != "") {
                            vItemAmount = Convert.ToInt32(tbxNewProductAmount.Text);
                        } else {
                            result = MessageBox.Show("Soll das Produkt ohne Anzahl gespeichert werden? Der Wert wird dann auf 0 gesetzt.", "Hinweis", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes) {
                                vItemAmount = 0;
                            }
                        }
                    }

                    if (result == DialogResult.Yes) {
                        var newProduct = new Product(productList.Count, vItemName, vItemDescription, vItemAmount);
                        productList.Add(newProduct);
                        //ADD ITEM TO SQL

                        tbxNewProductAmount.Text = "";
                        tbxNewProductDescription.Text = "";
                        tbxNewProductName.Text = "";
                        FillItemList();

                        lstbxProducts.SelectedIndex = productList.IndexOf(newProduct);
                    }
                } else {
                    MessageBox.Show("Bitte einen Namen für das Produkt eingeben.", "Fehler", MessageBoxButtons.OK);
                }
            }
            catch (FormatException) {
                MessageBox.Show("Bitte einen gültigen Wert als Anzahl eingeben.", "Fehler", MessageBoxButtons.OK);
                tbxNewProductAmount.Text = "";
            }
        }


        private void tbnSaveChanges_Click (object sender, EventArgs e) {
            try {
                var currentProduct = productList.ElementAt(lstbxProducts.SelectedIndex);
                currentProduct.Name = tbxCurrentProductName.Text;
                currentProduct.Description = tbxCurrentProductDescription.Text;
                currentProduct.Amount = Convert.ToInt32(tbxCurrentProductAmount.Text);
                //EDIT ITEM IN SQL

                FillItemList();
            }
            catch (FormatException) {
                MessageBox.Show("Bitte einen gültigen Wert als Anzahl eingeben.", "Fehler", MessageBoxButtons.OK);
            }
            catch (ArgumentOutOfRangeException) {
                //
            }
        }


        private void lstbxItems_SelectedIndexChanged (object sender, EventArgs e) {
            try {
                var currentProduct = productList.ElementAt(lstbxProducts.SelectedIndex);
                tbxCurrentProductAmount.Text = "" + currentProduct.Amount;
                tbxCurrentProductDescription.Text = currentProduct.Description;
                tbxCurrentProductName.Text = currentProduct.Name;
            }
            catch (IndexOutOfRangeException) {
                lstbxProducts.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException) {
                lstbxProducts.SelectedIndex = 0;
            }
        }


        private void btnCurrentProductDelete_Click (object sender, EventArgs e) {
            try {
                var result = MessageBox.Show("Möchten Sie den Eintrag wirklich löschen?", "Hinweis", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    var currentProduct = productList.ElementAt(lstbxProducts.SelectedIndex);
                    //SET REMOVE FLAG FOR ITEM IN SQL
                    currentProduct.Removed = true;

                    FillItemList();
                    lstbxProducts.SelectedIndex = 0;
                }
            }
            catch (ArgumentOutOfRangeException) {
                tbxCurrentProductAmount.Text = "";
                tbxCurrentProductDescription.Text = "";
                tbxCurrentProductName.Text = "";
            }
        }
    

       private void cbbxDatabase_SelectedIndexChanged (object sender, EventArgs e) {
            switch (cbbxDatabase.SelectedIndex) {
                case 0:
                    //THIS FORM
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


        private void FillItemList () {
            lstbxProducts.Items.Clear();
            productList.Sort((x, y) => x.Name.CompareTo(y.Name));

            //Einbinden der sortierten Liste in die ListBox.
            foreach (var currentProduct in productList) {
                if (!currentProduct.Removed)
                    lstbxProducts.Items.Add(currentProduct.Name);
            }
        }


        private void LoadItemsFromSQL () {
            //LOAD ENTRIES FROM SQL
        }
    }
}
