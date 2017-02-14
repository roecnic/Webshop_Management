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
            this.grpbxSelectedCustomer = new System.Windows.Forms.GroupBox();
            this.lblCurrentCustomerSex = new System.Windows.Forms.Label();
            this.cbxCurrentCustomerSex = new System.Windows.Forms.ComboBox();
            this.tbxCurrentCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCurrentCustomerAddress = new System.Windows.Forms.Label();
            this.tbxCurrentCustomerLastname = new System.Windows.Forms.TextBox();
            this.tbxCurrentCustomerPLZ = new System.Windows.Forms.TextBox();
            this.lblCurrentCustomerPLZ = new System.Windows.Forms.Label();
            this.tbxCurrentCustomerFirstname = new System.Windows.Forms.TextBox();
            this.lblCurrentCustomerLastname = new System.Windows.Forms.Label();
            this.lblCurrentCustomerFirstname = new System.Windows.Forms.Label();
            this.tbnCurrentCustomerSave = new System.Windows.Forms.Button();
            this.rbtnCurrentCustomerRemove = new System.Windows.Forms.RadioButton();
            this.rbtnCurrentCustomerSaveChanges = new System.Windows.Forms.RadioButton();
            this.grpbxNewCustomer = new System.Windows.Forms.GroupBox();
            this.lblNewCustomerSex = new System.Windows.Forms.Label();
            this.cbbxNewCustomerSex = new System.Windows.Forms.ComboBox();
            this.tbxNewCustomerStreet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNewCustomerLastname = new System.Windows.Forms.TextBox();
            this.tbxNewCustomerPLZ = new System.Windows.Forms.TextBox();
            this.lblNewCustomerPLZ = new System.Windows.Forms.Label();
            this.btnSaveNewCustomer = new System.Windows.Forms.Button();
            this.tbxNewCustomerFirstname = new System.Windows.Forms.TextBox();
            this.lblNewCustomerLastName = new System.Windows.Forms.Label();
            this.lblNewCustomerFirstname = new System.Windows.Forms.Label();
            this.lstbxCustomers = new System.Windows.Forms.ListBox();
            this.grpbxSelectedCustomer.SuspendLayout();
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
            // grpbxSelectedCustomer
            // 
            this.grpbxSelectedCustomer.Controls.Add(this.lblCurrentCustomerSex);
            this.grpbxSelectedCustomer.Controls.Add(this.cbxCurrentCustomerSex);
            this.grpbxSelectedCustomer.Controls.Add(this.tbxCurrentCustomerAddress);
            this.grpbxSelectedCustomer.Controls.Add(this.lblCurrentCustomerAddress);
            this.grpbxSelectedCustomer.Controls.Add(this.tbxCurrentCustomerLastname);
            this.grpbxSelectedCustomer.Controls.Add(this.tbxCurrentCustomerPLZ);
            this.grpbxSelectedCustomer.Controls.Add(this.lblCurrentCustomerPLZ);
            this.grpbxSelectedCustomer.Controls.Add(this.tbxCurrentCustomerFirstname);
            this.grpbxSelectedCustomer.Controls.Add(this.lblCurrentCustomerLastname);
            this.grpbxSelectedCustomer.Controls.Add(this.lblCurrentCustomerFirstname);
            this.grpbxSelectedCustomer.Controls.Add(this.tbnCurrentCustomerSave);
            this.grpbxSelectedCustomer.Controls.Add(this.rbtnCurrentCustomerRemove);
            this.grpbxSelectedCustomer.Controls.Add(this.rbtnCurrentCustomerSaveChanges);
            this.grpbxSelectedCustomer.Location = new System.Drawing.Point(278, 315);
            this.grpbxSelectedCustomer.Name = "grpbxSelectedCustomer";
            this.grpbxSelectedCustomer.Size = new System.Drawing.Size(258, 254);
            this.grpbxSelectedCustomer.TabIndex = 8;
            this.grpbxSelectedCustomer.TabStop = false;
            this.grpbxSelectedCustomer.Text = "Aktueller Kunde";
            // 
            // lblCurrentCustomerSex
            // 
            this.lblCurrentCustomerSex.AutoSize = true;
            this.lblCurrentCustomerSex.Location = new System.Drawing.Point(6, 167);
            this.lblCurrentCustomerSex.Name = "lblCurrentCustomerSex";
            this.lblCurrentCustomerSex.Size = new System.Drawing.Size(64, 13);
            this.lblCurrentCustomerSex.TabIndex = 21;
            this.lblCurrentCustomerSex.Text = "Geschlecht:";
            // 
            // cbxCurrentCustomerSex
            // 
            this.cbxCurrentCustomerSex.FormattingEnabled = true;
            this.cbxCurrentCustomerSex.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbxCurrentCustomerSex.Location = new System.Drawing.Point(83, 164);
            this.cbxCurrentCustomerSex.Name = "cbxCurrentCustomerSex";
            this.cbxCurrentCustomerSex.Size = new System.Drawing.Size(93, 21);
            this.cbxCurrentCustomerSex.TabIndex = 20;
            this.cbxCurrentCustomerSex.Text = "Männlich";
            // 
            // tbxCurrentCustomerAddress
            // 
            this.tbxCurrentCustomerAddress.Location = new System.Drawing.Point(81, 138);
            this.tbxCurrentCustomerAddress.Name = "tbxCurrentCustomerAddress";
            this.tbxCurrentCustomerAddress.Size = new System.Drawing.Size(168, 20);
            this.tbxCurrentCustomerAddress.TabIndex = 19;
            // 
            // lblCurrentCustomerAddress
            // 
            this.lblCurrentCustomerAddress.AutoSize = true;
            this.lblCurrentCustomerAddress.Location = new System.Drawing.Point(80, 122);
            this.lblCurrentCustomerAddress.Name = "lblCurrentCustomerAddress";
            this.lblCurrentCustomerAddress.Size = new System.Drawing.Size(127, 13);
            this.lblCurrentCustomerAddress.TabIndex = 18;
            this.lblCurrentCustomerAddress.Text = "Straße und Hausnummer:";
            // 
            // tbxCurrentCustomerLastname
            // 
            this.tbxCurrentCustomerLastname.Location = new System.Drawing.Point(9, 90);
            this.tbxCurrentCustomerLastname.Name = "tbxCurrentCustomerLastname";
            this.tbxCurrentCustomerLastname.Size = new System.Drawing.Size(240, 20);
            this.tbxCurrentCustomerLastname.TabIndex = 17;
            // 
            // tbxCurrentCustomerPLZ
            // 
            this.tbxCurrentCustomerPLZ.Location = new System.Drawing.Point(9, 138);
            this.tbxCurrentCustomerPLZ.Name = "tbxCurrentCustomerPLZ";
            this.tbxCurrentCustomerPLZ.Size = new System.Drawing.Size(57, 20);
            this.tbxCurrentCustomerPLZ.TabIndex = 15;
            // 
            // lblCurrentCustomerPLZ
            // 
            this.lblCurrentCustomerPLZ.AutoSize = true;
            this.lblCurrentCustomerPLZ.Location = new System.Drawing.Point(6, 122);
            this.lblCurrentCustomerPLZ.Name = "lblCurrentCustomerPLZ";
            this.lblCurrentCustomerPLZ.Size = new System.Drawing.Size(63, 13);
            this.lblCurrentCustomerPLZ.TabIndex = 16;
            this.lblCurrentCustomerPLZ.Text = "Postleitzahl:";
            // 
            // tbxCurrentCustomerFirstname
            // 
            this.tbxCurrentCustomerFirstname.Location = new System.Drawing.Point(9, 42);
            this.tbxCurrentCustomerFirstname.Name = "tbxCurrentCustomerFirstname";
            this.tbxCurrentCustomerFirstname.Size = new System.Drawing.Size(243, 20);
            this.tbxCurrentCustomerFirstname.TabIndex = 14;
            // 
            // lblCurrentCustomerLastname
            // 
            this.lblCurrentCustomerLastname.AutoSize = true;
            this.lblCurrentCustomerLastname.Location = new System.Drawing.Point(6, 74);
            this.lblCurrentCustomerLastname.Name = "lblCurrentCustomerLastname";
            this.lblCurrentCustomerLastname.Size = new System.Drawing.Size(62, 13);
            this.lblCurrentCustomerLastname.TabIndex = 13;
            this.lblCurrentCustomerLastname.Text = "Nachname:";
            // 
            // lblCurrentCustomerFirstname
            // 
            this.lblCurrentCustomerFirstname.AutoSize = true;
            this.lblCurrentCustomerFirstname.Location = new System.Drawing.Point(6, 25);
            this.lblCurrentCustomerFirstname.Name = "lblCurrentCustomerFirstname";
            this.lblCurrentCustomerFirstname.Size = new System.Drawing.Size(52, 13);
            this.lblCurrentCustomerFirstname.TabIndex = 12;
            this.lblCurrentCustomerFirstname.Text = "Vorname:";
            // 
            // tbnCurrentCustomerSave
            // 
            this.tbnCurrentCustomerSave.Location = new System.Drawing.Point(150, 203);
            this.tbnCurrentCustomerSave.Name = "tbnCurrentCustomerSave";
            this.tbnCurrentCustomerSave.Size = new System.Drawing.Size(102, 35);
            this.tbnCurrentCustomerSave.TabIndex = 11;
            this.tbnCurrentCustomerSave.Text = "Anwenden";
            this.tbnCurrentCustomerSave.UseVisualStyleBackColor = true;
            // 
            // rbtnCurrentCustomerRemove
            // 
            this.rbtnCurrentCustomerRemove.AutoSize = true;
            this.rbtnCurrentCustomerRemove.Location = new System.Drawing.Point(9, 221);
            this.rbtnCurrentCustomerRemove.Name = "rbtnCurrentCustomerRemove";
            this.rbtnCurrentCustomerRemove.Size = new System.Drawing.Size(110, 17);
            this.rbtnCurrentCustomerRemove.TabIndex = 10;
            this.rbtnCurrentCustomerRemove.TabStop = true;
            this.rbtnCurrentCustomerRemove.Text = "Kunden entfernen";
            this.rbtnCurrentCustomerRemove.UseVisualStyleBackColor = true;
            // 
            // rbtnCurrentCustomerSaveChanges
            // 
            this.rbtnCurrentCustomerSaveChanges.AutoSize = true;
            this.rbtnCurrentCustomerSaveChanges.Checked = true;
            this.rbtnCurrentCustomerSaveChanges.Location = new System.Drawing.Point(9, 202);
            this.rbtnCurrentCustomerSaveChanges.Name = "rbtnCurrentCustomerSaveChanges";
            this.rbtnCurrentCustomerSaveChanges.Size = new System.Drawing.Size(134, 17);
            this.rbtnCurrentCustomerSaveChanges.TabIndex = 9;
            this.rbtnCurrentCustomerSaveChanges.TabStop = true;
            this.rbtnCurrentCustomerSaveChanges.Text = "Änderungen Speichern";
            this.rbtnCurrentCustomerSaveChanges.UseVisualStyleBackColor = true;
            // 
            // grpbxNewCustomer
            // 
            this.grpbxNewCustomer.Controls.Add(this.lblNewCustomerSex);
            this.grpbxNewCustomer.Controls.Add(this.cbbxNewCustomerSex);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerStreet);
            this.grpbxNewCustomer.Controls.Add(this.label1);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerLastname);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerPLZ);
            this.grpbxNewCustomer.Controls.Add(this.lblNewCustomerPLZ);
            this.grpbxNewCustomer.Controls.Add(this.btnSaveNewCustomer);
            this.grpbxNewCustomer.Controls.Add(this.tbxNewCustomerFirstname);
            this.grpbxNewCustomer.Controls.Add(this.lblNewCustomerLastName);
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
            this.lblNewCustomerSex.Size = new System.Drawing.Size(64, 13);
            this.lblNewCustomerSex.TabIndex = 10;
            this.lblNewCustomerSex.Text = "Geschlecht:";
            // 
            // cbbxNewCustomerSex
            // 
            this.cbbxNewCustomerSex.FormattingEnabled = true;
            this.cbbxNewCustomerSex.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.cbbxNewCustomerSex.Location = new System.Drawing.Point(83, 163);
            this.cbbxNewCustomerSex.Name = "cbbxNewCustomerSex";
            this.cbbxNewCustomerSex.Size = new System.Drawing.Size(93, 21);
            this.cbbxNewCustomerSex.TabIndex = 9;
            this.cbbxNewCustomerSex.Text = "Männlich";
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
            this.tbxNewCustomerLastname.Location = new System.Drawing.Point(9, 89);
            this.tbxNewCustomerLastname.Name = "tbxNewCustomerLastname";
            this.tbxNewCustomerLastname.Size = new System.Drawing.Size(240, 20);
            this.tbxNewCustomerLastname.TabIndex = 6;
            // 
            // tbxNewCustomerPLZ
            // 
            this.tbxNewCustomerPLZ.Location = new System.Drawing.Point(9, 137);
            this.tbxNewCustomerPLZ.Name = "tbxNewCustomerPLZ";
            this.tbxNewCustomerPLZ.Size = new System.Drawing.Size(57, 20);
            this.tbxNewCustomerPLZ.TabIndex = 4;
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
            // btnSaveNewCustomer
            // 
            this.btnSaveNewCustomer.Location = new System.Drawing.Point(9, 193);
            this.btnSaveNewCustomer.Name = "btnSaveNewCustomer";
            this.btnSaveNewCustomer.Size = new System.Drawing.Size(243, 37);
            this.btnSaveNewCustomer.TabIndex = 5;
            this.btnSaveNewCustomer.Text = "Neuen Kunden anlegen";
            this.btnSaveNewCustomer.UseVisualStyleBackColor = true;
            // 
            // tbxNewCustomerFirstname
            // 
            this.tbxNewCustomerFirstname.Location = new System.Drawing.Point(9, 41);
            this.tbxNewCustomerFirstname.Name = "tbxNewCustomerFirstname";
            this.tbxNewCustomerFirstname.Size = new System.Drawing.Size(243, 20);
            this.tbxNewCustomerFirstname.TabIndex = 2;
            // 
            // lblNewCustomerLastName
            // 
            this.lblNewCustomerLastName.AutoSize = true;
            this.lblNewCustomerLastName.Location = new System.Drawing.Point(6, 73);
            this.lblNewCustomerLastName.Name = "lblNewCustomerLastName";
            this.lblNewCustomerLastName.Size = new System.Drawing.Size(62, 13);
            this.lblNewCustomerLastName.TabIndex = 1;
            this.lblNewCustomerLastName.Text = "Nachname:";
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
            // lstbxCustomers
            // 
            this.lstbxCustomers.FormattingEnabled = true;
            this.lstbxCustomers.Location = new System.Drawing.Point(12, 58);
            this.lstbxCustomers.Name = "lstbxCustomers";
            this.lstbxCustomers.Size = new System.Drawing.Size(260, 511);
            this.lstbxCustomers.TabIndex = 6;
            // 
            // WebShopForm_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 581);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedCustomer);
            this.Controls.Add(this.grpbxNewCustomer);
            this.Controls.Add(this.lstbxCustomers);
            this.Name = "WebShopForm_Customer";
            this.Text = "WebShopForm_Customer";
            this.grpbxSelectedCustomer.ResumeLayout(false);
            this.grpbxSelectedCustomer.PerformLayout();
            this.grpbxNewCustomer.ResumeLayout(false);
            this.grpbxNewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDatabase;
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.GroupBox grpbxSelectedCustomer;
        private System.Windows.Forms.Button tbnCurrentCustomerSave;
        private System.Windows.Forms.RadioButton rbtnCurrentCustomerRemove;
        private System.Windows.Forms.RadioButton rbtnCurrentCustomerSaveChanges;
        private System.Windows.Forms.GroupBox grpbxNewCustomer;
        private System.Windows.Forms.TextBox tbxNewCustomerStreet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNewCustomerLastname;
        private System.Windows.Forms.TextBox tbxNewCustomerPLZ;
        private System.Windows.Forms.Label lblNewCustomerPLZ;
        private System.Windows.Forms.Button btnSaveNewCustomer;
        private System.Windows.Forms.TextBox tbxNewCustomerFirstname;
        private System.Windows.Forms.Label lblNewCustomerLastName;
        private System.Windows.Forms.Label lblNewCustomerFirstname;
        private System.Windows.Forms.ListBox lstbxCustomers;
        private System.Windows.Forms.Label lblCurrentCustomerSex;
        private System.Windows.Forms.ComboBox cbxCurrentCustomerSex;
        private System.Windows.Forms.TextBox tbxCurrentCustomerAddress;
        private System.Windows.Forms.Label lblCurrentCustomerAddress;
        private System.Windows.Forms.TextBox tbxCurrentCustomerLastname;
        private System.Windows.Forms.TextBox tbxCurrentCustomerPLZ;
        private System.Windows.Forms.Label lblCurrentCustomerPLZ;
        private System.Windows.Forms.TextBox tbxCurrentCustomerFirstname;
        private System.Windows.Forms.Label lblCurrentCustomerLastname;
        private System.Windows.Forms.Label lblCurrentCustomerFirstname;
        private System.Windows.Forms.Label lblNewCustomerSex;
        private System.Windows.Forms.ComboBox cbbxNewCustomerSex;
    }
}