﻿using System;
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
            supplierList.Add(new Supplier(0, "Mindfactory AG", "Herr Konrad Zuse", "Irgendwasstraße 5", 456123, "0256+4013132"));
            supplierList.Add(new Supplier(1, "Amazon DACH", "Frau Braun", "Uhm... Bonn?", 4556987, "54654651432123"));
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

        private void lstbxSuppliers_SelectedIndexChanged (object sender, EventArgs e) {
            var currentSupplier = supplierList.ElementAt(lstbxSuppliers.SelectedIndex);

            tbxCurrentSupplierName.Text = currentSupplier.Description;
            tbxCurrentSupplierContact.Text = currentSupplier.Contact;
            tbxCurrentSupplierPLZ.Text = "" + currentSupplier.PLZ;
            tbxCurrentSupplierAddress.Text = "" + currentSupplier.Address;
            tbxCurrentSupplierPhoneNumber.Text = currentSupplier.PhoneNumber;
            tbxCurrentSupplierCreditHistory.Text = "" + currentSupplier.CreditHistory;
        }

        private void rbtnCurrentSupplierSaveChanges_CheckedChanged (object sender, EventArgs e) {
            if (rbtnCurrentSupplierRemove.Checked) {
                rbtnCurrentSupplierRemove.Checked = false;
                rbtnCurrentSupplierSaveChanges.Checked = true;
            }
        }

        private void rbtnCurrentSupplierRemove_CheckedChanged (object sender, EventArgs e) {
            if (rbtnCurrentSupplierSaveChanges.Checked) {
                rbtnCurrentSupplierSaveChanges.Checked = false;
                rbtnCurrentSupplierRemove.Checked = true;
            }
        }

        private void tbnCurrentCustomerSave_Click (object sender, EventArgs e) {
            try {
                var currentSupplier = supplierList.ElementAt(lstbxSuppliers.SelectedIndex);
                var removed = false;

                if (rbtnCurrentSupplierSaveChanges.Checked) {
                    currentSupplier.Description = tbxCurrentSupplierName.Text;
                    currentSupplier.Contact = tbxCurrentSupplierContact.Text;
                    currentSupplier.PLZ = Convert.ToInt32(tbxCurrentSupplierPLZ.Text);
                    currentSupplier.Address = tbxCurrentSupplierAddress.Text;
                    currentSupplier.PhoneNumber = tbxCurrentSupplierPhoneNumber.Text;
                } else if (rbtnCurrentSupplierRemove.Checked) {
                    supplierList.Remove(currentSupplier);
                    removed = true;
                }

                FillItemList();
                if (!removed)
                    lstbxSuppliers.SelectedIndex = supplierList.IndexOf(currentSupplier);
                else {
                    if (supplierList.Count > 0) {
                        lstbxSuppliers.SelectedIndex = 0;
                        tbxCurrentSupplierAddress.Text = "";
                        tbxCurrentSupplierContact.Text = "";
                        tbxCurrentSupplierCreditHistory.Text = "";
                        tbxCurrentSupplierName.Text = "";
                        tbxCurrentSupplierPhoneNumber.Text = "";
                        tbxCurrentSupplierPLZ.Text = "";
                    }
                }
            }
            catch (FormatException) {
                MessageBox.Show("Bitte eine gültige PLZ eingeben!", "Hinweis", MessageBoxButtons.OK);
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Bitte einen Lieferanten aus der Liste auswählen!", "Hinweis", MessageBoxButtons.OK);
            }
        }

        private void btnIncreaseCreditHistory_Click (object sender, EventArgs e) {
            try {
                var currentSupplier = supplierList.ElementAt(lstbxSuppliers.SelectedIndex);
                currentSupplier.CreditHistory += 100;
                tbxCurrentSupplierCreditHistory.Text = "" + currentSupplier.CreditHistory;
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Bitte vorher einen Lieferanten auswählen!", "Hinweis", MessageBoxButtons.OK);
            }
        }

        private void btnDecreaseCreditHistory_Click (object sender, EventArgs e) {
            try {
                var currentSupplier = supplierList.ElementAt(lstbxSuppliers.SelectedIndex);
                currentSupplier.CreditHistory -= 100;
                tbxCurrentSupplierCreditHistory.Text = "" + currentSupplier.CreditHistory;
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("Bitte vorher einen Lieferanten auswählen!", "Hinweis", MessageBoxButtons.OK);
            }
        }

        private void btnSaveNewCustomer_Click (object sender, EventArgs e) {
            var newSupplier = new Supplier(supplierList.Count, tbxNewSupplierName.Text, tbxNewSupplierContact.Text,
                tbxNewSupplierStreet.Text, Convert.ToInt32(tbxNewSupplierPLZ.Text), tbxNewSupplierPhoneNumber.Text);

            supplierList.Add(newSupplier);

            tbxNewSupplierName.Text = "";
            tbxNewSupplierContact.Text = "";
            tbxNewSupplierPLZ.Text = "";
            tbxNewSupplierStreet.Text = "";
            tbxNewSupplierPhoneNumber.Text = "";

            FillItemList();
            lstbxSuppliers.SelectedIndex = supplierList.IndexOf(newSupplier);
        }
    }
}
