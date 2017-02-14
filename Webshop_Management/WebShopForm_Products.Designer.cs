namespace Webshop_Management {
    partial class WebShopForm_Products {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.lstbxProducts = new System.Windows.Forms.ListBox();
            this.grpbxNewItem = new System.Windows.Forms.GroupBox();
            this.tbxNewProductAmount = new System.Windows.Forms.TextBox();
            this.lblNewProductAmount = new System.Windows.Forms.Label();
            this.btnSaveNewItem = new System.Windows.Forms.Button();
            this.tbxNewProductDescription = new System.Windows.Forms.RichTextBox();
            this.tbxNewProductName = new System.Windows.Forms.TextBox();
            this.lblNewProductDescription = new System.Windows.Forms.Label();
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.grpbxSelectedItem = new System.Windows.Forms.GroupBox();
            this.btnCurrentProductDelete = new System.Windows.Forms.Button();
            this.tbxCurrentProductAmount = new System.Windows.Forms.TextBox();
            this.lblCurrentProductAmount = new System.Windows.Forms.Label();
            this.tbnSaveChanges = new System.Windows.Forms.Button();
            this.tbxCurrentProductDescription = new System.Windows.Forms.RichTextBox();
            this.lblCurrentProductName = new System.Windows.Forms.Label();
            this.tbxCurrentProductName = new System.Windows.Forms.TextBox();
            this.lblCurrentProductDescription = new System.Windows.Forms.Label();
            this.cbbxDatabase = new System.Windows.Forms.ComboBox();
            this.lblSelectDatabase = new System.Windows.Forms.Label();
            this.grpbxNewItem.SuspendLayout();
            this.grpbxSelectedItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbxProducts
            // 
            this.lstbxProducts.FormattingEnabled = true;
            this.lstbxProducts.Location = new System.Drawing.Point(14, 62);
            this.lstbxProducts.Name = "lstbxProducts";
            this.lstbxProducts.Size = new System.Drawing.Size(260, 485);
            this.lstbxProducts.TabIndex = 0;
            this.lstbxProducts.SelectedIndexChanged += new System.EventHandler(this.lstbxItems_SelectedIndexChanged);
            // 
            // grpbxNewItem
            // 
            this.grpbxNewItem.Controls.Add(this.tbxNewProductAmount);
            this.grpbxNewItem.Controls.Add(this.lblNewProductAmount);
            this.grpbxNewItem.Controls.Add(this.btnSaveNewItem);
            this.grpbxNewItem.Controls.Add(this.tbxNewProductDescription);
            this.grpbxNewItem.Controls.Add(this.tbxNewProductName);
            this.grpbxNewItem.Controls.Add(this.lblNewProductDescription);
            this.grpbxNewItem.Controls.Add(this.lblNewProductName);
            this.grpbxNewItem.Location = new System.Drawing.Point(280, 62);
            this.grpbxNewItem.Name = "grpbxNewItem";
            this.grpbxNewItem.Size = new System.Drawing.Size(258, 236);
            this.grpbxNewItem.TabIndex = 2;
            this.grpbxNewItem.TabStop = false;
            this.grpbxNewItem.Text = "Neues Produkt";
            // 
            // tbxNewProductAmount
            // 
            this.tbxNewProductAmount.Location = new System.Drawing.Point(55, 159);
            this.tbxNewProductAmount.Name = "tbxNewProductAmount";
            this.tbxNewProductAmount.Size = new System.Drawing.Size(197, 20);
            this.tbxNewProductAmount.TabIndex = 4;
            // 
            // lblNewProductAmount
            // 
            this.lblNewProductAmount.AutoSize = true;
            this.lblNewProductAmount.Location = new System.Drawing.Point(6, 162);
            this.lblNewProductAmount.Name = "lblNewProductAmount";
            this.lblNewProductAmount.Size = new System.Drawing.Size(42, 13);
            this.lblNewProductAmount.TabIndex = 5;
            this.lblNewProductAmount.Text = "Anzahl:";
            // 
            // btnSaveNewItem
            // 
            this.btnSaveNewItem.Location = new System.Drawing.Point(9, 193);
            this.btnSaveNewItem.Name = "btnSaveNewItem";
            this.btnSaveNewItem.Size = new System.Drawing.Size(243, 37);
            this.btnSaveNewItem.TabIndex = 5;
            this.btnSaveNewItem.Text = "Neues Produkt anlegen";
            this.btnSaveNewItem.UseVisualStyleBackColor = true;
            this.btnSaveNewItem.Click += new System.EventHandler(this.btnSaveNewItem_Click);
            // 
            // tbxNewProductDescription
            // 
            this.tbxNewProductDescription.Location = new System.Drawing.Point(9, 106);
            this.tbxNewProductDescription.Name = "tbxNewProductDescription";
            this.tbxNewProductDescription.Size = new System.Drawing.Size(243, 43);
            this.tbxNewProductDescription.TabIndex = 3;
            this.tbxNewProductDescription.Text = "";
            // 
            // tbxNewProductName
            // 
            this.tbxNewProductName.Location = new System.Drawing.Point(9, 47);
            this.tbxNewProductName.Name = "tbxNewProductName";
            this.tbxNewProductName.Size = new System.Drawing.Size(243, 20);
            this.tbxNewProductName.TabIndex = 2;
            // 
            // lblNewProductDescription
            // 
            this.lblNewProductDescription.AutoSize = true;
            this.lblNewProductDescription.Location = new System.Drawing.Point(6, 89);
            this.lblNewProductDescription.Name = "lblNewProductDescription";
            this.lblNewProductDescription.Size = new System.Drawing.Size(111, 13);
            this.lblNewProductDescription.TabIndex = 1;
            this.lblNewProductDescription.Text = "Produktbeschreibung:";
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Location = new System.Drawing.Point(6, 30);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(73, 13);
            this.lblNewProductName.TabIndex = 0;
            this.lblNewProductName.Text = "Produktname:";
            // 
            // grpbxSelectedItem
            // 
            this.grpbxSelectedItem.Controls.Add(this.btnCurrentProductDelete);
            this.grpbxSelectedItem.Controls.Add(this.tbxCurrentProductAmount);
            this.grpbxSelectedItem.Controls.Add(this.lblCurrentProductAmount);
            this.grpbxSelectedItem.Controls.Add(this.tbnSaveChanges);
            this.grpbxSelectedItem.Controls.Add(this.tbxCurrentProductDescription);
            this.grpbxSelectedItem.Controls.Add(this.lblCurrentProductName);
            this.grpbxSelectedItem.Controls.Add(this.tbxCurrentProductName);
            this.grpbxSelectedItem.Controls.Add(this.lblCurrentProductDescription);
            this.grpbxSelectedItem.Location = new System.Drawing.Point(280, 319);
            this.grpbxSelectedItem.Name = "grpbxSelectedItem";
            this.grpbxSelectedItem.Size = new System.Drawing.Size(258, 228);
            this.grpbxSelectedItem.TabIndex = 3;
            this.grpbxSelectedItem.TabStop = false;
            this.grpbxSelectedItem.Text = "Ausgewähltes Produkt";
            // 
            // btnCurrentProductDelete
            // 
            this.btnCurrentProductDelete.Location = new System.Drawing.Point(140, 187);
            this.btnCurrentProductDelete.Name = "btnCurrentProductDelete";
            this.btnCurrentProductDelete.Size = new System.Drawing.Size(112, 35);
            this.btnCurrentProductDelete.TabIndex = 12;
            this.btnCurrentProductDelete.Text = "Produkt löschen";
            this.btnCurrentProductDelete.UseVisualStyleBackColor = true;
            this.btnCurrentProductDelete.Click += new System.EventHandler(this.btnCurrentProductDelete_Click);
            // 
            // tbxCurrentProductAmount
            // 
            this.tbxCurrentProductAmount.Location = new System.Drawing.Point(55, 156);
            this.tbxCurrentProductAmount.Name = "tbxCurrentProductAmount";
            this.tbxCurrentProductAmount.Size = new System.Drawing.Size(88, 20);
            this.tbxCurrentProductAmount.TabIndex = 8;
            // 
            // lblCurrentProductAmount
            // 
            this.lblCurrentProductAmount.AutoSize = true;
            this.lblCurrentProductAmount.Location = new System.Drawing.Point(6, 159);
            this.lblCurrentProductAmount.Name = "lblCurrentProductAmount";
            this.lblCurrentProductAmount.Size = new System.Drawing.Size(42, 13);
            this.lblCurrentProductAmount.TabIndex = 7;
            this.lblCurrentProductAmount.Text = "Anzahl:";
            // 
            // tbnSaveChanges
            // 
            this.tbnSaveChanges.Location = new System.Drawing.Point(9, 187);
            this.tbnSaveChanges.Name = "tbnSaveChanges";
            this.tbnSaveChanges.Size = new System.Drawing.Size(108, 35);
            this.tbnSaveChanges.TabIndex = 11;
            this.tbnSaveChanges.Text = "Änderungen speichern";
            this.tbnSaveChanges.UseVisualStyleBackColor = true;
            this.tbnSaveChanges.Click += new System.EventHandler(this.tbnSaveChanges_Click);
            // 
            // tbxCurrentProductDescription
            // 
            this.tbxCurrentProductDescription.Location = new System.Drawing.Point(9, 104);
            this.tbxCurrentProductDescription.Name = "tbxCurrentProductDescription";
            this.tbxCurrentProductDescription.Size = new System.Drawing.Size(243, 43);
            this.tbxCurrentProductDescription.TabIndex = 7;
            this.tbxCurrentProductDescription.Text = "";
            // 
            // lblCurrentProductName
            // 
            this.lblCurrentProductName.AutoSize = true;
            this.lblCurrentProductName.Location = new System.Drawing.Point(6, 28);
            this.lblCurrentProductName.Name = "lblCurrentProductName";
            this.lblCurrentProductName.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentProductName.TabIndex = 4;
            this.lblCurrentProductName.Text = "Produktname:";
            // 
            // tbxCurrentProductName
            // 
            this.tbxCurrentProductName.Location = new System.Drawing.Point(9, 45);
            this.tbxCurrentProductName.Name = "tbxCurrentProductName";
            this.tbxCurrentProductName.Size = new System.Drawing.Size(243, 20);
            this.tbxCurrentProductName.TabIndex = 6;
            // 
            // lblCurrentProductDescription
            // 
            this.lblCurrentProductDescription.AutoSize = true;
            this.lblCurrentProductDescription.Location = new System.Drawing.Point(6, 87);
            this.lblCurrentProductDescription.Name = "lblCurrentProductDescription";
            this.lblCurrentProductDescription.Size = new System.Drawing.Size(111, 13);
            this.lblCurrentProductDescription.TabIndex = 5;
            this.lblCurrentProductDescription.Text = "Produktbeschreibung:";
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
            this.cbbxDatabase.Location = new System.Drawing.Point(14, 35);
            this.cbbxDatabase.Name = "cbbxDatabase";
            this.cbbxDatabase.Size = new System.Drawing.Size(525, 21);
            this.cbbxDatabase.TabIndex = 4;
            this.cbbxDatabase.Text = "Produkte";
            this.cbbxDatabase.SelectedIndexChanged += new System.EventHandler(this.cbbxDatabase_SelectedIndexChanged);
            // 
            // lblSelectDatabase
            // 
            this.lblSelectDatabase.AutoSize = true;
            this.lblSelectDatabase.Location = new System.Drawing.Point(14, 13);
            this.lblSelectDatabase.Name = "lblSelectDatabase";
            this.lblSelectDatabase.Size = new System.Drawing.Size(124, 13);
            this.lblSelectDatabase.TabIndex = 5;
            this.lblSelectDatabase.Text = "Zu ändernde Datenbank";
            // 
            // Form_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 564);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedItem);
            this.Controls.Add(this.grpbxNewItem);
            this.Controls.Add(this.lstbxProducts);
            this.Name = "Form_Management";
            this.Text = "Shopmanagement";
            this.grpbxNewItem.ResumeLayout(false);
            this.grpbxNewItem.PerformLayout();
            this.grpbxSelectedItem.ResumeLayout(false);
            this.grpbxSelectedItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxProducts;
        private System.Windows.Forms.GroupBox grpbxNewItem;
        private System.Windows.Forms.TextBox tbxNewProductAmount;
        private System.Windows.Forms.Label lblNewProductAmount;
        private System.Windows.Forms.Button btnSaveNewItem;
        private System.Windows.Forms.RichTextBox tbxNewProductDescription;
        private System.Windows.Forms.TextBox tbxNewProductName;
        private System.Windows.Forms.Label lblNewProductDescription;
        private System.Windows.Forms.Label lblNewProductName;
        private System.Windows.Forms.GroupBox grpbxSelectedItem;
        private System.Windows.Forms.TextBox tbxCurrentProductAmount;
        private System.Windows.Forms.Label lblCurrentProductAmount;
        private System.Windows.Forms.Button tbnSaveChanges;
        private System.Windows.Forms.RichTextBox tbxCurrentProductDescription;
        private System.Windows.Forms.Label lblCurrentProductName;
        private System.Windows.Forms.TextBox tbxCurrentProductName;
        private System.Windows.Forms.Label lblCurrentProductDescription;
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.Label lblSelectDatabase;
        private System.Windows.Forms.Button btnCurrentProductDelete;
    }
}

