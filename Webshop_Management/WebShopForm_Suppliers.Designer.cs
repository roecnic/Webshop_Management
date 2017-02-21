namespace Webshop_Management {
    partial class WebShopForm_Suppliers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
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
        private void InitializeComponent () {
            this.lblSelectDatabase = new System.Windows.Forms.Label();
            this.cbbxDatabase = new System.Windows.Forms.ComboBox();
            this.grpbxSelectedSupplier = new System.Windows.Forms.GroupBox();
            this.tbxCurrentSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblCurrentSupplierPhoneNumber = new System.Windows.Forms.Label();
            this.tbxCurrentSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblCurrentSupplierAddress = new System.Windows.Forms.Label();
            this.tbxCurrentSupplierContact = new System.Windows.Forms.TextBox();
            this.tbxCurrentSupplierPLZ = new System.Windows.Forms.TextBox();
            this.lblCurrentSupplierPLZ = new System.Windows.Forms.Label();
            this.tbxCurrentSupplierName = new System.Windows.Forms.TextBox();
            this.lblCurrentSupplierContact = new System.Windows.Forms.Label();
            this.lblCurrentSupplierName = new System.Windows.Forms.Label();
            this.tbnCurrentCustomerSave = new System.Windows.Forms.Button();
            this.rbtnCurrentSupplierRemove = new System.Windows.Forms.RadioButton();
            this.rbtnCurrentSupplierSaveChanges = new System.Windows.Forms.RadioButton();
            this.grpbxNewSupplier = new System.Windows.Forms.GroupBox();
            this.tbxNewSupplierPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblNewSupplierPhoneNumber = new System.Windows.Forms.Label();
            this.tbxNewSupplierStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewSupplierContact = new System.Windows.Forms.TextBox();
            this.tbxNewSupplierPLZ = new System.Windows.Forms.TextBox();
            this.lblNewSupplierPLZ = new System.Windows.Forms.Label();
            this.btnSaveNewCustomer = new System.Windows.Forms.Button();
            this.tbxNewSupplierName = new System.Windows.Forms.TextBox();
            this.lblNewSupplierContact = new System.Windows.Forms.Label();
            this.lblNewSupplierName = new System.Windows.Forms.Label();
            this.lstbxSuppliers = new System.Windows.Forms.ListBox();
            this.btnSortLastname = new System.Windows.Forms.Button();
            this.btnSortID = new System.Windows.Forms.Button();
            this.lblCurrentSupplierCredithistory = new System.Windows.Forms.Label();
            this.tbxCurrentSupplierCreditHistory = new System.Windows.Forms.TextBox();
            this.btnDecreaseCreditHistory = new System.Windows.Forms.Button();
            this.btnIncreaseCreditHistory = new System.Windows.Forms.Button();
            this.grpbxSelectedSupplier.SuspendLayout();
            this.grpbxNewSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectDatabase
            // 
            this.lblSelectDatabase.AutoSize = true;
            this.lblSelectDatabase.Location = new System.Drawing.Point(12, 9);
            this.lblSelectDatabase.Name = "lblSelectDatabase";
            this.lblSelectDatabase.Size = new System.Drawing.Size(124, 13);
            this.lblSelectDatabase.TabIndex = 15;
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
            this.cbbxDatabase.TabIndex = 14;
            this.cbbxDatabase.Text = "Lieferanten";
            // 
            // grpbxSelectedSupplier
            // 
            this.grpbxSelectedSupplier.Controls.Add(this.btnIncreaseCreditHistory);
            this.grpbxSelectedSupplier.Controls.Add(this.btnDecreaseCreditHistory);
            this.grpbxSelectedSupplier.Controls.Add(this.tbxCurrentSupplierCreditHistory);
            this.grpbxSelectedSupplier.Controls.Add(this.lblCurrentSupplierCredithistory);
            this.grpbxSelectedSupplier.Controls.Add(this.tbxCurrentSupplierPhoneNumber);
            this.grpbxSelectedSupplier.Controls.Add(this.lblCurrentSupplierPhoneNumber);
            this.grpbxSelectedSupplier.Controls.Add(this.tbxCurrentSupplierAddress);
            this.grpbxSelectedSupplier.Controls.Add(this.lblCurrentSupplierAddress);
            this.grpbxSelectedSupplier.Controls.Add(this.tbxCurrentSupplierContact);
            this.grpbxSelectedSupplier.Controls.Add(this.tbxCurrentSupplierPLZ);
            this.grpbxSelectedSupplier.Controls.Add(this.lblCurrentSupplierPLZ);
            this.grpbxSelectedSupplier.Controls.Add(this.tbxCurrentSupplierName);
            this.grpbxSelectedSupplier.Controls.Add(this.lblCurrentSupplierContact);
            this.grpbxSelectedSupplier.Controls.Add(this.lblCurrentSupplierName);
            this.grpbxSelectedSupplier.Controls.Add(this.tbnCurrentCustomerSave);
            this.grpbxSelectedSupplier.Controls.Add(this.rbtnCurrentSupplierRemove);
            this.grpbxSelectedSupplier.Controls.Add(this.rbtnCurrentSupplierSaveChanges);
            this.grpbxSelectedSupplier.Location = new System.Drawing.Point(278, 315);
            this.grpbxSelectedSupplier.Name = "grpbxSelectedSupplier";
            this.grpbxSelectedSupplier.Size = new System.Drawing.Size(258, 294);
            this.grpbxSelectedSupplier.TabIndex = 13;
            this.grpbxSelectedSupplier.TabStop = false;
            this.grpbxSelectedSupplier.Text = "Aktueller Lieferant";
            // 
            // tbxCurrentSupplierPhoneNumber
            // 
            this.tbxCurrentSupplierPhoneNumber.Location = new System.Drawing.Point(95, 164);
            this.tbxCurrentSupplierPhoneNumber.Name = "tbxCurrentSupplierPhoneNumber";
            this.tbxCurrentSupplierPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.tbxCurrentSupplierPhoneNumber.TabIndex = 22;
            // 
            // lblCurrentSupplierPhoneNumber
            // 
            this.lblCurrentSupplierPhoneNumber.AutoSize = true;
            this.lblCurrentSupplierPhoneNumber.Location = new System.Drawing.Point(6, 167);
            this.lblCurrentSupplierPhoneNumber.Name = "lblCurrentSupplierPhoneNumber";
            this.lblCurrentSupplierPhoneNumber.Size = new System.Drawing.Size(83, 13);
            this.lblCurrentSupplierPhoneNumber.TabIndex = 21;
            this.lblCurrentSupplierPhoneNumber.Text = "Telefonnummer:";
            // 
            // tbxCurrentSupplierAddress
            // 
            this.tbxCurrentSupplierAddress.Location = new System.Drawing.Point(81, 138);
            this.tbxCurrentSupplierAddress.Name = "tbxCurrentSupplierAddress";
            this.tbxCurrentSupplierAddress.Size = new System.Drawing.Size(168, 20);
            this.tbxCurrentSupplierAddress.TabIndex = 19;
            // 
            // lblCurrentSupplierAddress
            // 
            this.lblCurrentSupplierAddress.AutoSize = true;
            this.lblCurrentSupplierAddress.Location = new System.Drawing.Point(80, 122);
            this.lblCurrentSupplierAddress.Name = "lblCurrentSupplierAddress";
            this.lblCurrentSupplierAddress.Size = new System.Drawing.Size(127, 13);
            this.lblCurrentSupplierAddress.TabIndex = 18;
            this.lblCurrentSupplierAddress.Text = "Straße und Hausnummer:";
            // 
            // tbxCurrentSupplierContact
            // 
            this.tbxCurrentSupplierContact.Location = new System.Drawing.Point(9, 90);
            this.tbxCurrentSupplierContact.Name = "tbxCurrentSupplierContact";
            this.tbxCurrentSupplierContact.Size = new System.Drawing.Size(240, 20);
            this.tbxCurrentSupplierContact.TabIndex = 17;
            // 
            // tbxCurrentSupplierPLZ
            // 
            this.tbxCurrentSupplierPLZ.Location = new System.Drawing.Point(9, 138);
            this.tbxCurrentSupplierPLZ.Name = "tbxCurrentSupplierPLZ";
            this.tbxCurrentSupplierPLZ.Size = new System.Drawing.Size(57, 20);
            this.tbxCurrentSupplierPLZ.TabIndex = 15;
            // 
            // lblCurrentSupplierPLZ
            // 
            this.lblCurrentSupplierPLZ.AutoSize = true;
            this.lblCurrentSupplierPLZ.Location = new System.Drawing.Point(6, 122);
            this.lblCurrentSupplierPLZ.Name = "lblCurrentSupplierPLZ";
            this.lblCurrentSupplierPLZ.Size = new System.Drawing.Size(63, 13);
            this.lblCurrentSupplierPLZ.TabIndex = 16;
            this.lblCurrentSupplierPLZ.Text = "Postleitzahl:";
            // 
            // tbxCurrentSupplierName
            // 
            this.tbxCurrentSupplierName.Location = new System.Drawing.Point(9, 42);
            this.tbxCurrentSupplierName.Name = "tbxCurrentSupplierName";
            this.tbxCurrentSupplierName.Size = new System.Drawing.Size(240, 20);
            this.tbxCurrentSupplierName.TabIndex = 14;
            // 
            // lblCurrentSupplierContact
            // 
            this.lblCurrentSupplierContact.AutoSize = true;
            this.lblCurrentSupplierContact.Location = new System.Drawing.Point(6, 74);
            this.lblCurrentSupplierContact.Name = "lblCurrentSupplierContact";
            this.lblCurrentSupplierContact.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentSupplierContact.TabIndex = 13;
            this.lblCurrentSupplierContact.Text = "Ansprechpartner:";
            // 
            // lblCurrentSupplierName
            // 
            this.lblCurrentSupplierName.AutoSize = true;
            this.lblCurrentSupplierName.Location = new System.Drawing.Point(6, 25);
            this.lblCurrentSupplierName.Name = "lblCurrentSupplierName";
            this.lblCurrentSupplierName.Size = new System.Drawing.Size(38, 13);
            this.lblCurrentSupplierName.TabIndex = 12;
            this.lblCurrentSupplierName.Text = "Name:";
            // 
            // tbnCurrentCustomerSave
            // 
            this.tbnCurrentCustomerSave.Location = new System.Drawing.Point(150, 244);
            this.tbnCurrentCustomerSave.Name = "tbnCurrentCustomerSave";
            this.tbnCurrentCustomerSave.Size = new System.Drawing.Size(99, 35);
            this.tbnCurrentCustomerSave.TabIndex = 11;
            this.tbnCurrentCustomerSave.Text = "Anwenden";
            this.tbnCurrentCustomerSave.UseVisualStyleBackColor = true;
            // 
            // rbtnCurrentSupplierRemove
            // 
            this.rbtnCurrentSupplierRemove.AutoSize = true;
            this.rbtnCurrentSupplierRemove.Location = new System.Drawing.Point(9, 262);
            this.rbtnCurrentSupplierRemove.Name = "rbtnCurrentSupplierRemove";
            this.rbtnCurrentSupplierRemove.Size = new System.Drawing.Size(126, 17);
            this.rbtnCurrentSupplierRemove.TabIndex = 10;
            this.rbtnCurrentSupplierRemove.TabStop = true;
            this.rbtnCurrentSupplierRemove.Text = "Lieferanten entfernen";
            this.rbtnCurrentSupplierRemove.UseVisualStyleBackColor = true;
            // 
            // rbtnCurrentSupplierSaveChanges
            // 
            this.rbtnCurrentSupplierSaveChanges.AutoSize = true;
            this.rbtnCurrentSupplierSaveChanges.Checked = true;
            this.rbtnCurrentSupplierSaveChanges.Location = new System.Drawing.Point(9, 243);
            this.rbtnCurrentSupplierSaveChanges.Name = "rbtnCurrentSupplierSaveChanges";
            this.rbtnCurrentSupplierSaveChanges.Size = new System.Drawing.Size(134, 17);
            this.rbtnCurrentSupplierSaveChanges.TabIndex = 9;
            this.rbtnCurrentSupplierSaveChanges.TabStop = true;
            this.rbtnCurrentSupplierSaveChanges.Text = "Änderungen Speichern";
            this.rbtnCurrentSupplierSaveChanges.UseVisualStyleBackColor = true;
            // 
            // grpbxNewSupplier
            // 
            this.grpbxNewSupplier.Controls.Add(this.tbxNewSupplierPhoneNumber);
            this.grpbxNewSupplier.Controls.Add(this.lblNewSupplierPhoneNumber);
            this.grpbxNewSupplier.Controls.Add(this.tbxNewSupplierStreet);
            this.grpbxNewSupplier.Controls.Add(this.label1);
            this.grpbxNewSupplier.Controls.Add(this.tbxNewSupplierContact);
            this.grpbxNewSupplier.Controls.Add(this.tbxNewSupplierPLZ);
            this.grpbxNewSupplier.Controls.Add(this.lblNewSupplierPLZ);
            this.grpbxNewSupplier.Controls.Add(this.btnSaveNewCustomer);
            this.grpbxNewSupplier.Controls.Add(this.tbxNewSupplierName);
            this.grpbxNewSupplier.Controls.Add(this.lblNewSupplierContact);
            this.grpbxNewSupplier.Controls.Add(this.lblNewSupplierName);
            this.grpbxNewSupplier.Location = new System.Drawing.Point(278, 58);
            this.grpbxNewSupplier.Name = "grpbxNewSupplier";
            this.grpbxNewSupplier.Size = new System.Drawing.Size(258, 236);
            this.grpbxNewSupplier.TabIndex = 12;
            this.grpbxNewSupplier.TabStop = false;
            this.grpbxNewSupplier.Text = "Neuer Lieferant";
            // 
            // tbxNewSupplierPhoneNumber
            // 
            this.tbxNewSupplierPhoneNumber.Location = new System.Drawing.Point(95, 163);
            this.tbxNewSupplierPhoneNumber.Name = "tbxNewSupplierPhoneNumber";
            this.tbxNewSupplierPhoneNumber.Size = new System.Drawing.Size(154, 20);
            this.tbxNewSupplierPhoneNumber.TabIndex = 11;
            // 
            // lblNewSupplierPhoneNumber
            // 
            this.lblNewSupplierPhoneNumber.AutoSize = true;
            this.lblNewSupplierPhoneNumber.Location = new System.Drawing.Point(6, 166);
            this.lblNewSupplierPhoneNumber.Name = "lblNewSupplierPhoneNumber";
            this.lblNewSupplierPhoneNumber.Size = new System.Drawing.Size(83, 13);
            this.lblNewSupplierPhoneNumber.TabIndex = 10;
            this.lblNewSupplierPhoneNumber.Text = "Telefonnummer:";
            // 
            // tbxNewSupplierStreet
            // 
            this.tbxNewSupplierStreet.Location = new System.Drawing.Point(81, 137);
            this.tbxNewSupplierStreet.Name = "tbxNewSupplierStreet";
            this.tbxNewSupplierStreet.Size = new System.Drawing.Size(168, 20);
            this.tbxNewSupplierStreet.TabIndex = 8;
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
            // tbxNewSupplierContact
            // 
            this.tbxNewSupplierContact.Location = new System.Drawing.Point(9, 89);
            this.tbxNewSupplierContact.Name = "tbxNewSupplierContact";
            this.tbxNewSupplierContact.Size = new System.Drawing.Size(240, 20);
            this.tbxNewSupplierContact.TabIndex = 6;
            // 
            // tbxNewSupplierPLZ
            // 
            this.tbxNewSupplierPLZ.Location = new System.Drawing.Point(9, 137);
            this.tbxNewSupplierPLZ.Name = "tbxNewSupplierPLZ";
            this.tbxNewSupplierPLZ.Size = new System.Drawing.Size(57, 20);
            this.tbxNewSupplierPLZ.TabIndex = 4;
            // 
            // lblNewSupplierPLZ
            // 
            this.lblNewSupplierPLZ.AutoSize = true;
            this.lblNewSupplierPLZ.Location = new System.Drawing.Point(6, 121);
            this.lblNewSupplierPLZ.Name = "lblNewSupplierPLZ";
            this.lblNewSupplierPLZ.Size = new System.Drawing.Size(63, 13);
            this.lblNewSupplierPLZ.TabIndex = 5;
            this.lblNewSupplierPLZ.Text = "Postleitzahl:";
            // 
            // btnSaveNewCustomer
            // 
            this.btnSaveNewCustomer.Location = new System.Drawing.Point(9, 193);
            this.btnSaveNewCustomer.Name = "btnSaveNewCustomer";
            this.btnSaveNewCustomer.Size = new System.Drawing.Size(240, 37);
            this.btnSaveNewCustomer.TabIndex = 5;
            this.btnSaveNewCustomer.Text = "Neuen Lieferanten anlegen";
            this.btnSaveNewCustomer.UseVisualStyleBackColor = true;
            // 
            // tbxNewSupplierName
            // 
            this.tbxNewSupplierName.Location = new System.Drawing.Point(9, 41);
            this.tbxNewSupplierName.Name = "tbxNewSupplierName";
            this.tbxNewSupplierName.Size = new System.Drawing.Size(240, 20);
            this.tbxNewSupplierName.TabIndex = 2;
            // 
            // lblNewSupplierContact
            // 
            this.lblNewSupplierContact.AutoSize = true;
            this.lblNewSupplierContact.Location = new System.Drawing.Point(6, 73);
            this.lblNewSupplierContact.Name = "lblNewSupplierContact";
            this.lblNewSupplierContact.Size = new System.Drawing.Size(88, 13);
            this.lblNewSupplierContact.TabIndex = 1;
            this.lblNewSupplierContact.Text = "Ansprechpartner:";
            // 
            // lblNewSupplierName
            // 
            this.lblNewSupplierName.AutoSize = true;
            this.lblNewSupplierName.Location = new System.Drawing.Point(6, 24);
            this.lblNewSupplierName.Name = "lblNewSupplierName";
            this.lblNewSupplierName.Size = new System.Drawing.Size(38, 13);
            this.lblNewSupplierName.TabIndex = 0;
            this.lblNewSupplierName.Text = "Name:";
            // 
            // lstbxSuppliers
            // 
            this.lstbxSuppliers.FormattingEnabled = true;
            this.lstbxSuppliers.Location = new System.Drawing.Point(12, 58);
            this.lstbxSuppliers.Name = "lstbxSuppliers";
            this.lstbxSuppliers.Size = new System.Drawing.Size(260, 511);
            this.lstbxSuppliers.TabIndex = 11;
            this.lstbxSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstbxSuppliers_SelectedIndexChanged);
            // 
            // btnSortLastname
            // 
            this.btnSortLastname.Location = new System.Drawing.Point(12, 574);
            this.btnSortLastname.Name = "btnSortLastname";
            this.btnSortLastname.Size = new System.Drawing.Size(124, 35);
            this.btnSortLastname.TabIndex = 25;
            this.btnSortLastname.Text = "Nach Name sortieren";
            this.btnSortLastname.UseVisualStyleBackColor = true;
            this.btnSortLastname.Click += new System.EventHandler(this.btnSortLastname_Click);
            // 
            // btnSortID
            // 
            this.btnSortID.Location = new System.Drawing.Point(148, 574);
            this.btnSortID.Name = "btnSortID";
            this.btnSortID.Size = new System.Drawing.Size(124, 35);
            this.btnSortID.TabIndex = 26;
            this.btnSortID.Text = "Nach ID sortieren";
            this.btnSortID.UseVisualStyleBackColor = true;
            this.btnSortID.Click += new System.EventHandler(this.btnSortID_Click);
            // 
            // lblCurrentSupplierCredithistory
            // 
            this.lblCurrentSupplierCredithistory.AutoSize = true;
            this.lblCurrentSupplierCredithistory.Location = new System.Drawing.Point(6, 193);
            this.lblCurrentSupplierCredithistory.Name = "lblCurrentSupplierCredithistory";
            this.lblCurrentSupplierCredithistory.Size = new System.Drawing.Size(43, 13);
            this.lblCurrentSupplierCredithistory.TabIndex = 23;
            this.lblCurrentSupplierCredithistory.Text = "Bonität:";
            // 
            // tbxCurrentSupplierCreditHistory
            // 
            this.tbxCurrentSupplierCreditHistory.Location = new System.Drawing.Point(58, 190);
            this.tbxCurrentSupplierCreditHistory.Name = "tbxCurrentSupplierCreditHistory";
            this.tbxCurrentSupplierCreditHistory.ReadOnly = true;
            this.tbxCurrentSupplierCreditHistory.Size = new System.Drawing.Size(191, 20);
            this.tbxCurrentSupplierCreditHistory.TabIndex = 24;
            // 
            // btnDecreaseCreditHistory
            // 
            this.btnDecreaseCreditHistory.Location = new System.Drawing.Point(150, 216);
            this.btnDecreaseCreditHistory.Name = "btnDecreaseCreditHistory";
            this.btnDecreaseCreditHistory.Size = new System.Drawing.Size(99, 21);
            this.btnDecreaseCreditHistory.TabIndex = 25;
            this.btnDecreaseCreditHistory.Text = "Bonität verringern";
            this.btnDecreaseCreditHistory.UseVisualStyleBackColor = true;
            // 
            // btnIncreaseCreditHistory
            // 
            this.btnIncreaseCreditHistory.Location = new System.Drawing.Point(34, 216);
            this.btnIncreaseCreditHistory.Name = "btnIncreaseCreditHistory";
            this.btnIncreaseCreditHistory.Size = new System.Drawing.Size(109, 21);
            this.btnIncreaseCreditHistory.TabIndex = 26;
            this.btnIncreaseCreditHistory.Text = "Bonität erhöhen";
            this.btnIncreaseCreditHistory.UseVisualStyleBackColor = true;
            // 
            // WebShopForm_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 621);
            this.Controls.Add(this.btnSortID);
            this.Controls.Add(this.btnSortLastname);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedSupplier);
            this.Controls.Add(this.grpbxNewSupplier);
            this.Controls.Add(this.lstbxSuppliers);
            this.Name = "WebShopForm_Suppliers";
            this.Text = "WebShopForm_Suppliers";
            this.grpbxSelectedSupplier.ResumeLayout(false);
            this.grpbxSelectedSupplier.PerformLayout();
            this.grpbxNewSupplier.ResumeLayout(false);
            this.grpbxNewSupplier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDatabase;
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.GroupBox grpbxSelectedSupplier;
        private System.Windows.Forms.Label lblCurrentSupplierPhoneNumber;
        private System.Windows.Forms.TextBox tbxCurrentSupplierAddress;
        private System.Windows.Forms.Label lblCurrentSupplierAddress;
        private System.Windows.Forms.TextBox tbxCurrentSupplierContact;
        private System.Windows.Forms.TextBox tbxCurrentSupplierPLZ;
        private System.Windows.Forms.Label lblCurrentSupplierPLZ;
        private System.Windows.Forms.TextBox tbxCurrentSupplierName;
        private System.Windows.Forms.Label lblCurrentSupplierContact;
        private System.Windows.Forms.Label lblCurrentSupplierName;
        private System.Windows.Forms.Button tbnCurrentCustomerSave;
        private System.Windows.Forms.RadioButton rbtnCurrentSupplierRemove;
        private System.Windows.Forms.RadioButton rbtnCurrentSupplierSaveChanges;
        private System.Windows.Forms.GroupBox grpbxNewSupplier;
        private System.Windows.Forms.Label lblNewSupplierPhoneNumber;
        private System.Windows.Forms.TextBox tbxNewSupplierStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewSupplierContact;
        private System.Windows.Forms.TextBox tbxNewSupplierPLZ;
        private System.Windows.Forms.Label lblNewSupplierPLZ;
        private System.Windows.Forms.Button btnSaveNewCustomer;
        private System.Windows.Forms.TextBox tbxNewSupplierName;
        private System.Windows.Forms.Label lblNewSupplierContact;
        private System.Windows.Forms.Label lblNewSupplierName;
        private System.Windows.Forms.ListBox lstbxSuppliers;
        private System.Windows.Forms.TextBox tbxNewSupplierPhoneNumber;
        private System.Windows.Forms.TextBox tbxCurrentSupplierPhoneNumber;
        private System.Windows.Forms.Button btnSortLastname;
        private System.Windows.Forms.Button btnSortID;
        private System.Windows.Forms.Button btnIncreaseCreditHistory;
        private System.Windows.Forms.Button btnDecreaseCreditHistory;
        private System.Windows.Forms.TextBox tbxCurrentSupplierCreditHistory;
        private System.Windows.Forms.Label lblCurrentSupplierCredithistory;
    }
}