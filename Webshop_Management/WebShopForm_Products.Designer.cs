namespace Webshop_Management {
    partial class From_Management {
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
            this.tbxNewAmount = new System.Windows.Forms.TextBox();
            this.lblNewAmount = new System.Windows.Forms.Label();
            this.btnSaveNewItem = new System.Windows.Forms.Button();
            this.rtbxNewItemDescription = new System.Windows.Forms.RichTextBox();
            this.tbxNewItemName = new System.Windows.Forms.TextBox();
            this.lblNewItemDescription = new System.Windows.Forms.Label();
            this.lblNewItemName = new System.Windows.Forms.Label();
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
            this.lstbxProducts.Size = new System.Drawing.Size(228, 485);
            this.lstbxProducts.TabIndex = 0;
            this.lstbxProducts.SelectedIndexChanged += new System.EventHandler(this.lstbxItems_SelectedIndexChanged);
            // 
            // grpbxNewItem
            // 
            this.grpbxNewItem.Controls.Add(this.tbxNewAmount);
            this.grpbxNewItem.Controls.Add(this.lblNewAmount);
            this.grpbxNewItem.Controls.Add(this.btnSaveNewItem);
            this.grpbxNewItem.Controls.Add(this.rtbxNewItemDescription);
            this.grpbxNewItem.Controls.Add(this.tbxNewItemName);
            this.grpbxNewItem.Controls.Add(this.lblNewItemDescription);
            this.grpbxNewItem.Controls.Add(this.lblNewItemName);
            this.grpbxNewItem.Location = new System.Drawing.Point(280, 62);
            this.grpbxNewItem.Name = "grpbxNewItem";
            this.grpbxNewItem.Size = new System.Drawing.Size(258, 236);
            this.grpbxNewItem.TabIndex = 2;
            this.grpbxNewItem.TabStop = false;
            this.grpbxNewItem.Text = "Neues Produkt";
            // 
            // tbxNewAmount
            // 
            this.tbxNewAmount.Location = new System.Drawing.Point(55, 159);
            this.tbxNewAmount.Name = "tbxNewAmount";
            this.tbxNewAmount.Size = new System.Drawing.Size(197, 20);
            this.tbxNewAmount.TabIndex = 4;
            // 
            // lblNewAmount
            // 
            this.lblNewAmount.AutoSize = true;
            this.lblNewAmount.Location = new System.Drawing.Point(6, 162);
            this.lblNewAmount.Name = "lblNewAmount";
            this.lblNewAmount.Size = new System.Drawing.Size(42, 13);
            this.lblNewAmount.TabIndex = 5;
            this.lblNewAmount.Text = "Anzahl:";
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
            // rtbxNewItemDescription
            // 
            this.rtbxNewItemDescription.Location = new System.Drawing.Point(9, 106);
            this.rtbxNewItemDescription.Name = "rtbxNewItemDescription";
            this.rtbxNewItemDescription.Size = new System.Drawing.Size(243, 43);
            this.rtbxNewItemDescription.TabIndex = 3;
            this.rtbxNewItemDescription.Text = "";
            // 
            // tbxNewItemName
            // 
            this.tbxNewItemName.Location = new System.Drawing.Point(9, 47);
            this.tbxNewItemName.Name = "tbxNewItemName";
            this.tbxNewItemName.Size = new System.Drawing.Size(243, 20);
            this.tbxNewItemName.TabIndex = 2;
            // 
            // lblNewItemDescription
            // 
            this.lblNewItemDescription.AutoSize = true;
            this.lblNewItemDescription.Location = new System.Drawing.Point(6, 89);
            this.lblNewItemDescription.Name = "lblNewItemDescription";
            this.lblNewItemDescription.Size = new System.Drawing.Size(111, 13);
            this.lblNewItemDescription.TabIndex = 1;
            this.lblNewItemDescription.Text = "Produktbeschreibung:";
            // 
            // lblNewItemName
            // 
            this.lblNewItemName.AutoSize = true;
            this.lblNewItemName.Location = new System.Drawing.Point(6, 30);
            this.lblNewItemName.Name = "lblNewItemName";
            this.lblNewItemName.Size = new System.Drawing.Size(73, 13);
            this.lblNewItemName.TabIndex = 0;
            this.lblNewItemName.Text = "Produktname:";
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
            this.grpbxSelectedItem.Location = new System.Drawing.Point(280, 319);
            this.grpbxSelectedItem.Name = "grpbxSelectedItem";
            this.grpbxSelectedItem.Size = new System.Drawing.Size(258, 228);
            this.grpbxSelectedItem.TabIndex = 3;
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
            this.btnReduceSelectedAmount.Click += new System.EventHandler(this.btnReduceSelectedAmount_Click);
            // 
            // btnIncreaseSelectedAmount
            // 
            this.btnIncreaseSelectedAmount.Location = new System.Drawing.Point(149, 156);
            this.btnIncreaseSelectedAmount.Name = "btnIncreaseSelectedAmount";
            this.btnIncreaseSelectedAmount.Size = new System.Drawing.Size(45, 20);
            this.btnIncreaseSelectedAmount.TabIndex = 12;
            this.btnIncreaseSelectedAmount.Text = "+";
            this.btnIncreaseSelectedAmount.UseVisualStyleBackColor = true;
            this.btnIncreaseSelectedAmount.Click += new System.EventHandler(this.btnIncreaseSelectedAmount_Click);
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
            this.tbnSave.Click += new System.EventHandler(this.tbnSave_Click);
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
            this.rbtnRemoveItem.CheckedChanged += new System.EventHandler(this.rbtnRemoveItem_CheckedChanged);
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
            this.rbtnSaveChanges.CheckedChanged += new System.EventHandler(this.rbtnSaveChanges_CheckedChanged);
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
            // From_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 564);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedItem);
            this.Controls.Add(this.grpbxNewItem);
            this.Controls.Add(this.lstbxProducts);
            this.Name = "From_Management";
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
        private System.Windows.Forms.TextBox tbxNewAmount;
        private System.Windows.Forms.Label lblNewAmount;
        private System.Windows.Forms.Button btnSaveNewItem;
        private System.Windows.Forms.RichTextBox rtbxNewItemDescription;
        private System.Windows.Forms.TextBox tbxNewItemName;
        private System.Windows.Forms.Label lblNewItemDescription;
        private System.Windows.Forms.Label lblNewItemName;
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
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.Label lblSelectDatabase;
    }
}

