namespace Webshop_Management {
    partial class WebShopForm_Customer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblSelectDatabase = new System.Windows.Forms.Label();
            this.cbbxDatabase = new System.Windows.Forms.ComboBox();
            this.grpbxSelectedItem = new System.Windows.Forms.GroupBox();
            this.btnReduceSelectedAmount = new System.Windows.Forms.Button();
            this.btnIncreaseSelectedAmount = new System.Windows.Forms.Button();
            this.tbxSelectedAmount = new System.Windows.Forms.TextBox();
            this.lblSelectedAmount = new System.Windows.Forms.Label();
            this.tbnSave = new System.Windows.Forms.Button();
            this.rbtnRemoveItem = new System.Windows.Forms.RadioButton();
            this.rbtnSaveChanges = new System.Windows.Forms.RadioButton();
            this.rtbxSelectedItemDescription = new System.Windows.Forms.RichTextBox();
            this.lblSelectedItemName = new System.Windows.Forms.Label();
            this.tbxSelectedItemName = new System.Windows.Forms.TextBox();
            this.lblSelectedItemDescription = new System.Windows.Forms.Label();
            this.grpbxNewCustomer = new System.Windows.Forms.GroupBox();
            this.lblNewCustomerSex = new System.Windows.Forms.Label();
            this.cbbxNewCustomerSex = new System.Windows.Forms.ComboBox();
            this.tbxNewCustomerStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewCustomerLastname = new System.Windows.Forms.TextBox();
            this.tbxNewAmount = new System.Windows.Forms.TextBox();
            this.lblNewCustomerPLZ = new System.Windows.Forms.Label();
            this.btnSaveNewItem = new System.Windows.Forms.Button();
            this.tbxNewCustomerFirstname = new System.Windows.Forms.TextBox();
            this.lblNewItemDescription = new System.Windows.Forms.Label();
            this.lblNewCustomerFirstname = new System.Windows.Forms.Label();
            this.lstbxItems = new System.Windows.Forms.ListBox();
            this.grpbxSelectedItem.SuspendLayout();
            this.grpbxNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectDatabase
            // 
            this.lblSelectDatabase.AutoSize = true;
            this.lblSelectDatabase.Location = new System.Drawing.Point(12, 9);
            this.lblSelectDatabase.Name = "lblSelectDatabase";
            this.lblSelectDatabase.Size = new System.Drawing.Size(124, 13);
            this.lblSelectDatabase.TabIndex = 10;
            this.lblSelectDatabase.Text = "Zu ändernde Datenbank";
            // 
            // cbbxDatabase
            // 
            this.cbbxDatabase.FormattingEnabled = true;
            this.cbbxDatabase.Items.AddRange(new object[] {
            "Produkte",
            "Kunden",
            "Aktuelle Bestellungen",
            "Erledigte Bestellungen",
            "Lieferanten"});
            this.cbbxDatabase.Location = new System.Drawing.Point(12, 31);
            this.cbbxDatabase.Name = "cbbxDatabase";
            this.cbbxDatabase.Size = new System.Drawing.Size(525, 21);
            this.cbbxDatabase.TabIndex = 9;
            this.cbbxDatabase.Text = "Kunden";
            // 
            // grpbxSelectedItem
            // 
            this.grpbxSelectedItem.Controls.Add(this.btnReduceSelectedAmount);
            this.grpbxSelectedItem.Controls.Add(this.btnIncreaseSelectedAmount);
            this.grpbxSelectedItem.Controls.Add(this.tbxSelectedAmount);
            this.grpbxSelectedItem.Controls.Add(this.lblSelectedAmount);
            this.grpbxSelectedItem.Controls.Add(this.tbnSave);
            this.grpbxSelectedItem.Controls.Add(this.rbtnRemoveItem);
            this.grpbxSelectedItem.Controls.Add(this.rbtnSaveChanges);
            this.grpbxSelectedItem.Controls.Add(this.rtbxSelectedItemDescription);
            this.grpbxSelectedItem.Controls.Add(this.lblSelectedItemName);
            this.grpbxSelectedItem.Controls.Add(this.tbxSelectedItemName);
            this.grpbxSelectedItem.Controls.Add(this.lblSelectedItemDescription);
            this.grpbxSelectedItem.Location = new System.Drawing.Point(278, 315);
            this.grpbxSelectedItem.Name = "grpbxSelectedItem";
            this.grpbxSelectedItem.Size = new System.Drawing.Size(258, 228);
            this.grpbxSelectedItem.TabIndex = 8;
            this.grpbxSelectedItem.TabStop = false;
            this.grpbxSelectedItem.Text = "Ausgewähltes Produkt";
            // 
            // btnReduceSelectedAmount
            // 
            this.btnReduceSelectedAmount.Location = new System.Drawing.Point(209, 156);
            this.btnReduceSelectedAmount.Name = "btnReduceSelectedAmount";
            this.btnReduceSelectedAmount.Size = new System.Drawing.Size(43, 20);
            this.btnReduceSelectedAmount.TabIndex = 13;
            this.btnReduceSelectedAmount.Text = "-";
            this.btnReduceSelectedAmount.UseVisualStyleBackColor = true;
            // 
            // btnIncreaseSelectedAmount
            // 
            this.btnIncreaseSelectedAmount.Location = new System.Drawing.Point(149, 156);
            this.btnIncreaseSelectedAmount.Name = "btnIncreaseSelectedAmount";
            this.btnIncreaseSelectedAmount.Size = new System.Drawing.Size(45, 20);
            this.btnIncreaseSelectedAmount.TabIndex = 12;
            this.btnIncreaseSelectedAmount.Text = "+";
            this.btnIncreaseSelectedAmount.UseVisualStyleBackColor = true;
            // 
            // tbxSelectedAmount
            // 
            this.tbxSelectedAmount.Location = new System.Drawing.Point(55, 156);
            this.tbxSelectedAmount.Name = "tbxSelectedAmount";
            this.tbxSelectedAmount.Size = new System.Drawing.Size(88, 20);
            this.tbxSelectedAmount.TabIndex = 8;
            // 
            // lblSelectedAmount
            // 
            this.lblSelectedAmount.AutoSize = true;
            this.lblSelectedAmount.Location = new System.Drawing.Point(6, 159);
            this.lblSelectedAmount.Name = "lblSelectedAmount";
            this.lblSelectedAmount.Size = new System.Drawing.Size(42, 13);
            this.lblSelectedAmount.TabIndex = 7;
            this.lblSelectedAmount.Text = "Anzahl:";
            // 
            // tbnSave
            // 
            this.tbnSave.Location = new System.Drawing.Point(150, 187);
            this.tbnSave.Name = "tbnSave";
            this.tbnSave.Size = new System.Drawing.Size(102, 35);
            this.tbnSave.TabIndex = 11;
            this.tbnSave.Text = "Anwenden";
            this.tbnSave.UseVisualStyleBackColor = true;
            // 
            // rbtnRemoveItem
            // 
            this.rbtnRemoveItem.AutoSize = true;
            this.rbtnRemoveItem.Location = new System.Drawing.Point(9, 205);
            this.rbtnRemoveItem.Name = "rbtnRemoveItem";
            this.rbtnRemoveItem.Size = new System.Drawing.Size(102, 17);
            this.rbtnRemoveItem.TabIndex = 10;
            this.rbtnRemoveItem.TabStop = true;
            this.rbtnRemoveItem.Text = "Produkt löschen";
            this.rbtnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // rbtnSaveChanges
            // 
            this.rbtnSaveChanges.AutoSize = true;
            this.rbtnSaveChanges.Checked = true;
            this.rbtnSaveChanges.Location = new System.Drawing.Point(9, 186);
            this.rbtnSaveChanges.Name = "rbtnSaveChanges";
            this.rbtnSaveChanges.Size = new System.Drawing.Size(134, 17);
            this.rbtnSaveChanges.TabIndex = 9;
            this.rbtnSaveChanges.TabStop = true;
            this.rbtnSaveChanges.Text = "Änderungen Speichern";
            this.rbtnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // rtbxSelectedItemDescription
            // 
            this.rtbxSelectedItemDescription.Location = new System.Drawing.Point(9, 104);
            this.rtbxSelectedItemDescription.Name = "rtbxSelectedItemDescription";
            this.rtbxSelectedItemDescription.Size = new System.Drawing.Size(243, 43);
            this.rtbxSelectedItemDescription.TabIndex = 7;
            this.rtbxSelectedItemDescription.Text = "";
            // 
            // lblSelectedItemName
            // 
            this.lblSelectedItemName.AutoSize = true;
            this.lblSelectedItemName.Location = new System.Drawing.Point(6, 28);
            this.lblSelectedItemName.Name = "lblSelectedItemName";
            this.lblSelectedItemName.Size = new System.Drawing.Size(73, 13);
            this.lblSelectedItemName.TabIndex = 4;
            this.lblSelectedItemName.Text = "Produktname:";
            // 
            // tbxSelectedItemName
            // 
            this.tbxSelectedItemName.Location = new System.Drawing.Point(9, 45);
            this.tbxSelectedItemName.Name = "tbxSelectedItemName";
            this.tbxSelectedItemName.Size = new System.Drawing.Size(243, 20);
            this.tbxSelectedItemName.TabIndex = 6;
            // 
            // lblSelectedItemDescription
            // 
            this.lblSelectedItemDescription.AutoSize = true;
            this.lblSelectedItemDescription.Location = new System.Drawing.Point(6, 87);
            this.lblSelectedItemDescription.Name = "lblSelectedItemDescription";
            this.lblSelectedItemDescription.Size = new System.Drawing.Size(111, 13);
            this.lblSelectedItemDescription.TabIndex = 5;
            this.lblSelectedItemDescription.Text = "Produktbeschreibung:";
            // 
            // grpbxNewCustomer
            // 
            this.grpbxNewCustomer.Controls.Add(this.lblNewCustomerSex);
            this.grpbxNewCustomer.Controls.Add(this.cbbxNewCustomerSex);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerStreet);
            this.grpbxNewCustomer.Controls.Add(this.label1);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerLastname);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewAmount);
            this.grpbxNewCustomer.Controls.Add(this.lblNewCustomerPLZ);
            this.grpbxNewCustomer.Controls.Add(this.btnSaveNewItem);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerFirstname);
            this.grpbxNewCustomer.Controls.Add(this.lblNewItemDescription);
            this.grpbxNewCustomer.Controls.Add(this.lblNewCustomerFirstname);
            this.grpbxNewCustomer.Location = new System.Drawing.Point(278, 58);
            this.grpbxNewCustomer.Name = "grpbxNewCustomer";
            this.grpbxNewCustomer.Size = new System.Drawing.Size(258, 236);
            this.grpbxNewCustomer.TabIndex = 7;
            this.grpbxNewCustomer.TabStop = false;
            this.grpbxNewCustomer.Text = "Neuer Kunde";
            // 
            // lblNewCustomerSex
            // 
            this.lblNewCustomerSex.AutoSize = true;
            this.lblNewCustomerSex.Location = new System.Drawing.Point(6, 166);
            this.lblNewCustomerSex.Name = "lblNewCustomerSex";
            this.lblNewCustomerSex.Size = new System.Drawing.Size(63, 13);
            this.lblNewCustomerSex.TabIndex = 10;
            this.lblNewCustomerSex.Text = "Postleitzahl:";
            // 
            // cbbxNewCustomerSex
            // 
            this.cbbxNewCustomerSex.FormattingEnabled = true;
            this.cbbxNewCustomerSex.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbbxNewCustomerSex.Location = new System.Drawing.Point(83, 163);
            this.cbbxNewCustomerSex.Name = "cbbxNewCustomerSex";
            this.cbbxNewCustomerSex.Size = new System.Drawing.Size(63, 21);
            this.cbbxNewCustomerSex.TabIndex = 9;
            // 
            // tbxNewCustomerStreet
            // 
            this.tbxNewCustomerStreet.Location = new System.Drawing.Point(81, 137);
            this.tbxNewCustomerStreet.Name = "tbxNewCustomerStreet";
            this.tbxNewCustomerStreet.Size = new System.Drawing.Size(168, 20);
            this.tbxNewCustomerStreet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Straße und Hausnummer:";
            // 
            // tbxNewCustomerLastname
            // 
            this.tbxNewCustomerLastname.Location = new System.Drawing.Point(6, 89);
            this.tbxNewCustomerLastname.Name = "tbxNewCustomerLastname";
            this.tbxNewCustomerLastname.Size = new System.Drawing.Size(243, 20);
            this.tbxNewCustomerLastname.TabIndex = 6;
            // 
            // tbxNewAmount
            // 
            this.tbxNewAmount.Location = new System.Drawing.Point(6, 137);
            this.tbxNewAmount.Name = "tbxNewAmount";
            this.tbxNewAmount.Size = new System.Drawing.Size(57, 20);
            this.tbxNewAmount.TabIndex = 4;
            // 
            // lblNewCustomerPLZ
            // 
            this.lblNewCustomerPLZ.AutoSize = true;
            this.lblNewCustomerPLZ.Location = new System.Drawing.Point(6, 121);
            this.lblNewCustomerPLZ.Name = "lblNewCustomerPLZ";
            this.lblNewCustomerPLZ.Size = new System.Drawing.Size(63, 13);
            this.lblNewCustomerPLZ.TabIndex = 5;
            this.lblNewCustomerPLZ.Text = "Postleitzahl:";
            // 
            // btnSaveNewItem
            // 
            this.btnSaveNewItem.Location = new System.Drawing.Point(9, 193);
            this.btnSaveNewItem.Name = "btnSaveNewItem";
            this.btnSaveNewItem.Size = new System.Drawing.Size(243, 37);
            this.btnSaveNewItem.TabIndex = 5;
            this.btnSaveNewItem.Text = "Neues Produkt anlegen";
            this.btnSaveNewItem.UseVisualStyleBackColor = true;
            // 
            // tbxNewCustomerFirstname
            // 
            this.tbxNewCustomerFirstname.Location = new System.Drawing.Point(9, 41);
            this.tbxNewCustomerFirstname.Name = "tbxNewCustomerFirstname";
            this.tbxNewCustomerFirstname.Size = new System.Drawing.Size(243, 20);
            this.tbxNewCustomerFirstname.TabIndex = 2;
            // 
            // lblNewItemDescription
            // 
            this.lblNewItemDescription.AutoSize = true;
            this.lblNewItemDescription.Location = new System.Drawing.Point(6, 73);
            this.lblNewItemDescription.Name = "lblNewItemDescription";
            this.lblNewItemDescription.Size = new System.Drawing.Size(111, 13);
            this.lblNewItemDescription.TabIndex = 1;
            this.lblNewItemDescription.Text = "Produktbeschreibung:";
            // 
            // lblNewCustomerFirstname
            // 
            this.lblNewCustomerFirstname.AutoSize = true;
            this.lblNewCustomerFirstname.Location = new System.Drawing.Point(6, 24);
            this.lblNewCustomerFirstname.Name = "lblNewCustomerFirstname";
            this.lblNewCustomerFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblNewCustomerFirstname.TabIndex = 0;
            this.lblNewCustomerFirstname.Text = "Vorname:";
            // 
            // lstbxItems
            // 
            this.lstbxItems.FormattingEnabled = true;
            this.lstbxItems.Location = new System.Drawing.Point(12, 58);
            this.lstbxItems.Name = "lstbxItems";
            this.lstbxItems.Size = new System.Drawing.Size(228, 485);
            this.lstbxItems.TabIndex = 6;
            // 
            // WebShopForm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 562);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedItem);
            this.Controls.Add(this.grpbxNewCustomer);
            this.Controls.Add(this.lstbxItems);
            this.Name = "WebShopForm_Customer";
            this.Text = "WebShopForm_Customer";
            this.grpbxSelectedItem.ResumeLayout(false);
            this.grpbxSelectedItem.PerformLayout();
            this.grpbxNewCustomer.ResumeLayout(false);
            this.grpbxNewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDatabase;
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.GroupBox grpbxSelectedItem;
        private System.Windows.Forms.Button btnReduceSelectedAmount;
        private System.Windows.Forms.Button btnIncreaseSelectedAmount;
        private System.Windows.Forms.TextBox tbxSelectedAmount;
        private System.Windows.Forms.Label lblSelectedAmount;
        private System.Windows.Forms.Button tbnSave;
        private System.Windows.Forms.RadioButton rbtnRemoveItem;
        private System.Windows.Forms.RadioButton rbtnSaveChanges;
        private System.Windows.Forms.RichTextBox rtbxSelectedItemDescription;
        private System.Windows.Forms.Label lblSelectedItemName;
        private System.Windows.Forms.TextBox tbxSelectedItemName;
        private System.Windows.Forms.Label lblSelectedItemDescription;
        private System.Windows.Forms.GroupBox grpbxNewCustomer;
        private System.Windows.Forms.Label lblNewCustomerSex;
        private System.Windows.Forms.ComboBox cbbxNewCustomerSex;
        private System.Windows.Forms.TextBox tbxNewCustomerStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewCustomerLastname;
        private System.Windows.Forms.TextBox tbxNewAmount;
        private System.Windows.Forms.Label lblNewCustomerPLZ;
        private System.Windows.Forms.Button btnSaveNewItem;
        private System.Windows.Forms.TextBox tbxNewCustomerFirstname;
        private System.Windows.Forms.Label lblNewItemDescription;
        private System.Windows.Forms.Label lblNewCustomerFirstname;
        private System.Windows.Forms.ListBox lstbxItems;
    }
}