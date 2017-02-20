namespace Webshop_Management {
    partial class WebShopForm_OpenOrders {
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
            this.grpbxSelectedOrder = new System.Windows.Forms.GroupBox();
            this.tbxCurrentOrderCreateTime = new System.Windows.Forms.TextBox();
            this.lblCurrentOrderCreateTime = new System.Windows.Forms.Label();
            this.btnCurrentOrderClose = new System.Windows.Forms.Button();
            this.btnCurrentOrderDelete = new System.Windows.Forms.Button();
            this.btnCurrentOrderRemoveProduct = new System.Windows.Forms.Button();
            this.tbxCurrentOrderCustomer = new System.Windows.Forms.TextBox();
            this.clstbxCurrentOrderCart = new System.Windows.Forms.CheckedListBox();
            this.lblCurrentOrderCustomer = new System.Windows.Forms.Label();
            this.grpbxNewOrder = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedProducts = new System.Windows.Forms.Button();
            this.clstbxShoppingCart = new System.Windows.Forms.CheckedListBox();
            this.btnNewOrderAddProduct = new System.Windows.Forms.Button();
            this.tbxNewOrderProductAmount = new System.Windows.Forms.TextBox();
            this.lblNewOrderProductAmount = new System.Windows.Forms.Label();
            this.cbxNewOrderCustomer = new System.Windows.Forms.ComboBox();
            this.lblNewOrderCustomer = new System.Windows.Forms.Label();
            this.lblNewOrderProduct = new System.Windows.Forms.Label();
            this.cbxNewOrderProduct = new System.Windows.Forms.ComboBox();
            this.btnCreateNewOrder = new System.Windows.Forms.Button();
            this.lstbxOrders = new System.Windows.Forms.ListBox();
            this.grpbxSelectedOrder.SuspendLayout();
            this.grpbxNewOrder.SuspendLayout();
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
            this.cbbxDatabase.Text = "Offene Bestellungen";
            // 
            // grpbxSelectedOrder
            // 
            this.grpbxSelectedOrder.Controls.Add(this.tbxCurrentOrderCreateTime);
            this.grpbxSelectedOrder.Controls.Add(this.lblCurrentOrderCreateTime);
            this.grpbxSelectedOrder.Controls.Add(this.btnCurrentOrderClose);
            this.grpbxSelectedOrder.Controls.Add(this.btnCurrentOrderDelete);
            this.grpbxSelectedOrder.Controls.Add(this.btnCurrentOrderRemoveProduct);
            this.grpbxSelectedOrder.Controls.Add(this.tbxCurrentOrderCustomer);
            this.grpbxSelectedOrder.Controls.Add(this.clstbxCurrentOrderCart);
            this.grpbxSelectedOrder.Controls.Add(this.lblCurrentOrderCustomer);
            this.grpbxSelectedOrder.Location = new System.Drawing.Point(278, 315);
            this.grpbxSelectedOrder.Name = "grpbxSelectedOrder";
            this.grpbxSelectedOrder.Size = new System.Drawing.Size(446, 240);
            this.grpbxSelectedOrder.TabIndex = 13;
            this.grpbxSelectedOrder.TabStop = false;
            this.grpbxSelectedOrder.Text = "Aktuelle Bestellung";
            // 
            // tbxCurrentOrderCreateTime
            // 
            this.tbxCurrentOrderCreateTime.Location = new System.Drawing.Point(70, 48);
            this.tbxCurrentOrderCreateTime.Name = "tbxCurrentOrderCreateTime";
            this.tbxCurrentOrderCreateTime.ReadOnly = true;
            this.tbxCurrentOrderCreateTime.Size = new System.Drawing.Size(182, 20);
            this.tbxCurrentOrderCreateTime.TabIndex = 33;
            // 
            // lblCurrentOrderCreateTime
            // 
            this.lblCurrentOrderCreateTime.AutoSize = true;
            this.lblCurrentOrderCreateTime.Location = new System.Drawing.Point(6, 51);
            this.lblCurrentOrderCreateTime.Name = "lblCurrentOrderCreateTime";
            this.lblCurrentOrderCreateTime.Size = new System.Drawing.Size(58, 13);
            this.lblCurrentOrderCreateTime.TabIndex = 32;
            this.lblCurrentOrderCreateTime.Text = "Erstellt am:";
            // 
            // btnCurrentOrderClose
            // 
            this.btnCurrentOrderClose.Location = new System.Drawing.Point(312, 191);
            this.btnCurrentOrderClose.Name = "btnCurrentOrderClose";
            this.btnCurrentOrderClose.Size = new System.Drawing.Size(128, 37);
            this.btnCurrentOrderClose.TabIndex = 31;
            this.btnCurrentOrderClose.Text = "Bestellung abschließen";
            this.btnCurrentOrderClose.UseVisualStyleBackColor = true;
            // 
            // btnCurrentOrderDelete
            // 
            this.btnCurrentOrderDelete.Location = new System.Drawing.Point(163, 191);
            this.btnCurrentOrderDelete.Name = "btnCurrentOrderDelete";
            this.btnCurrentOrderDelete.Size = new System.Drawing.Size(143, 37);
            this.btnCurrentOrderDelete.TabIndex = 30;
            this.btnCurrentOrderDelete.Text = "Bestellung stornieren";
            this.btnCurrentOrderDelete.UseVisualStyleBackColor = true;
            this.btnCurrentOrderDelete.Click += new System.EventHandler(this.btnCurrentOrderDelete_Click);
            // 
            // btnCurrentOrderRemoveProduct
            // 
            this.btnCurrentOrderRemoveProduct.Location = new System.Drawing.Point(9, 191);
            this.btnCurrentOrderRemoveProduct.Name = "btnCurrentOrderRemoveProduct";
            this.btnCurrentOrderRemoveProduct.Size = new System.Drawing.Size(148, 37);
            this.btnCurrentOrderRemoveProduct.TabIndex = 29;
            this.btnCurrentOrderRemoveProduct.Text = "Ausgewählte Produkte entfernen";
            this.btnCurrentOrderRemoveProduct.UseVisualStyleBackColor = true;
            this.btnCurrentOrderRemoveProduct.Click += new System.EventHandler(this.btnCurrentOrderRemoveProduct_Click);
            // 
            // tbxCurrentOrderCustomer
            // 
            this.tbxCurrentOrderCustomer.Location = new System.Drawing.Point(59, 22);
            this.tbxCurrentOrderCustomer.Name = "tbxCurrentOrderCustomer";
            this.tbxCurrentOrderCustomer.ReadOnly = true;
            this.tbxCurrentOrderCustomer.Size = new System.Drawing.Size(381, 20);
            this.tbxCurrentOrderCustomer.TabIndex = 28;
            // 
            // clstbxCurrentOrderCart
            // 
            this.clstbxCurrentOrderCart.CheckOnClick = true;
            this.clstbxCurrentOrderCart.FormattingEnabled = true;
            this.clstbxCurrentOrderCart.Location = new System.Drawing.Point(9, 76);
            this.clstbxCurrentOrderCart.Name = "clstbxCurrentOrderCart";
            this.clstbxCurrentOrderCart.Size = new System.Drawing.Size(431, 109);
            this.clstbxCurrentOrderCart.TabIndex = 25;
            // 
            // lblCurrentOrderCustomer
            // 
            this.lblCurrentOrderCustomer.AutoSize = true;
            this.lblCurrentOrderCustomer.Location = new System.Drawing.Point(6, 25);
            this.lblCurrentOrderCustomer.Name = "lblCurrentOrderCustomer";
            this.lblCurrentOrderCustomer.Size = new System.Drawing.Size(41, 13);
            this.lblCurrentOrderCustomer.TabIndex = 20;
            this.lblCurrentOrderCustomer.Text = "Kunde:";
            // 
            // grpbxNewOrder
            // 
            this.grpbxNewOrder.Controls.Add(this.btnRemoveSelectedProducts);
            this.grpbxNewOrder.Controls.Add(this.clstbxShoppingCart);
            this.grpbxNewOrder.Controls.Add(this.btnNewOrderAddProduct);
            this.grpbxNewOrder.Controls.Add(this.tbxNewOrderProductAmount);
            this.grpbxNewOrder.Controls.Add(this.lblNewOrderProductAmount);
            this.grpbxNewOrder.Controls.Add(this.cbxNewOrderCustomer);
            this.grpbxNewOrder.Controls.Add(this.lblNewOrderCustomer);
            this.grpbxNewOrder.Controls.Add(this.lblNewOrderProduct);
            this.grpbxNewOrder.Controls.Add(this.cbxNewOrderProduct);
            this.grpbxNewOrder.Controls.Add(this.btnCreateNewOrder);
            this.grpbxNewOrder.Location = new System.Drawing.Point(278, 58);
            this.grpbxNewOrder.Name = "grpbxNewOrder";
            this.grpbxNewOrder.Size = new System.Drawing.Size(446, 236);
            this.grpbxNewOrder.TabIndex = 12;
            this.grpbxNewOrder.TabStop = false;
            this.grpbxNewOrder.Text = "Neue Bestellung";
            // 
            // btnRemoveSelectedProducts
            // 
            this.btnRemoveSelectedProducts.Location = new System.Drawing.Point(259, 119);
            this.btnRemoveSelectedProducts.Name = "btnRemoveSelectedProducts";
            this.btnRemoveSelectedProducts.Size = new System.Drawing.Size(181, 37);
            this.btnRemoveSelectedProducts.TabIndex = 17;
            this.btnRemoveSelectedProducts.Text = "Ausgewählte Produkte entfernen";
            this.btnRemoveSelectedProducts.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedProducts.Click += new System.EventHandler(this.btnRemoveSelectedProducts_Click);
            // 
            // clstbxShoppingCart
            // 
            this.clstbxShoppingCart.CheckOnClick = true;
            this.clstbxShoppingCart.FormattingEnabled = true;
            this.clstbxShoppingCart.Location = new System.Drawing.Point(259, 20);
            this.clstbxShoppingCart.Name = "clstbxShoppingCart";
            this.clstbxShoppingCart.Size = new System.Drawing.Size(181, 94);
            this.clstbxShoppingCart.TabIndex = 16;
            // 
            // btnNewOrderAddProduct
            // 
            this.btnNewOrderAddProduct.Location = new System.Drawing.Point(9, 119);
            this.btnNewOrderAddProduct.Name = "btnNewOrderAddProduct";
            this.btnNewOrderAddProduct.Size = new System.Drawing.Size(243, 37);
            this.btnNewOrderAddProduct.TabIndex = 15;
            this.btnNewOrderAddProduct.Text = "Produkt zum Warenkorb hinzufügen";
            this.btnNewOrderAddProduct.UseVisualStyleBackColor = true;
            this.btnNewOrderAddProduct.Click += new System.EventHandler(this.btnNewOrderAddProduct_Click);
            // 
            // tbxNewOrderProductAmount
            // 
            this.tbxNewOrderProductAmount.Location = new System.Drawing.Point(59, 93);
            this.tbxNewOrderProductAmount.Name = "tbxNewOrderProductAmount";
            this.tbxNewOrderProductAmount.Size = new System.Drawing.Size(193, 20);
            this.tbxNewOrderProductAmount.TabIndex = 14;
            // 
            // lblNewOrderProductAmount
            // 
            this.lblNewOrderProductAmount.AutoSize = true;
            this.lblNewOrderProductAmount.Location = new System.Drawing.Point(6, 96);
            this.lblNewOrderProductAmount.Name = "lblNewOrderProductAmount";
            this.lblNewOrderProductAmount.Size = new System.Drawing.Size(42, 13);
            this.lblNewOrderProductAmount.TabIndex = 13;
            this.lblNewOrderProductAmount.Text = "Anzahl:";
            // 
            // cbxNewOrderCustomer
            // 
            this.cbxNewOrderCustomer.FormattingEnabled = true;
            this.cbxNewOrderCustomer.Location = new System.Drawing.Point(59, 23);
            this.cbxNewOrderCustomer.Name = "cbxNewOrderCustomer";
            this.cbxNewOrderCustomer.Size = new System.Drawing.Size(193, 21);
            this.cbxNewOrderCustomer.TabIndex = 12;
            this.cbxNewOrderCustomer.Text = "<Bitte auswählen>";
            // 
            // lblNewOrderCustomer
            // 
            this.lblNewOrderCustomer.AutoSize = true;
            this.lblNewOrderCustomer.Location = new System.Drawing.Point(6, 26);
            this.lblNewOrderCustomer.Name = "lblNewOrderCustomer";
            this.lblNewOrderCustomer.Size = new System.Drawing.Size(41, 13);
            this.lblNewOrderCustomer.TabIndex = 11;
            this.lblNewOrderCustomer.Text = "Kunde:";
            // 
            // lblNewOrderProduct
            // 
            this.lblNewOrderProduct.AutoSize = true;
            this.lblNewOrderProduct.Location = new System.Drawing.Point(6, 62);
            this.lblNewOrderProduct.Name = "lblNewOrderProduct";
            this.lblNewOrderProduct.Size = new System.Drawing.Size(47, 13);
            this.lblNewOrderProduct.TabIndex = 10;
            this.lblNewOrderProduct.Text = "Produkt:";
            // 
            // cbxNewOrderProduct
            // 
            this.cbxNewOrderProduct.FormattingEnabled = true;
            this.cbxNewOrderProduct.Location = new System.Drawing.Point(59, 59);
            this.cbxNewOrderProduct.Name = "cbxNewOrderProduct";
            this.cbxNewOrderProduct.Size = new System.Drawing.Size(193, 21);
            this.cbxNewOrderProduct.TabIndex = 9;
            this.cbxNewOrderProduct.Text = "<Bitte auswählen>";
            // 
            // btnCreateNewOrder
            // 
            this.btnCreateNewOrder.Location = new System.Drawing.Point(9, 182);
            this.btnCreateNewOrder.Name = "btnCreateNewOrder";
            this.btnCreateNewOrder.Size = new System.Drawing.Size(431, 48);
            this.btnCreateNewOrder.TabIndex = 5;
            this.btnCreateNewOrder.Text = "Neue Bestellung anlegen";
            this.btnCreateNewOrder.UseVisualStyleBackColor = true;
            this.btnCreateNewOrder.Click += new System.EventHandler(this.btnCreateNewOrder_Click);
            // 
            // lstbxOrders
            // 
            this.lstbxOrders.FormattingEnabled = true;
            this.lstbxOrders.Location = new System.Drawing.Point(12, 58);
            this.lstbxOrders.Name = "lstbxOrders";
            this.lstbxOrders.Size = new System.Drawing.Size(260, 498);
            this.lstbxOrders.TabIndex = 11;
            this.lstbxOrders.SelectedIndexChanged += new System.EventHandler(this.lstbxOrders_SelectedIndexChanged);
            // 
            // WebShopForm_OpenOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 567);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedOrder);
            this.Controls.Add(this.grpbxNewOrder);
            this.Controls.Add(this.lstbxOrders);
            this.Name = "WebShopForm_OpenOrders";
            this.Text = "WebShopForm_OpenOrders";
            this.grpbxSelectedOrder.ResumeLayout(false);
            this.grpbxSelectedOrder.PerformLayout();
            this.grpbxNewOrder.ResumeLayout(false);
            this.grpbxNewOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDatabase;
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.GroupBox grpbxSelectedOrder;
        private System.Windows.Forms.GroupBox grpbxNewOrder;
        private System.Windows.Forms.Label lblNewOrderProduct;
        private System.Windows.Forms.ComboBox cbxNewOrderProduct;
        private System.Windows.Forms.Button btnCreateNewOrder;
        private System.Windows.Forms.ListBox lstbxOrders;
        private System.Windows.Forms.ComboBox cbxNewOrderCustomer;
        private System.Windows.Forms.Label lblNewOrderCustomer;
        private System.Windows.Forms.Button btnNewOrderAddProduct;
        private System.Windows.Forms.TextBox tbxNewOrderProductAmount;
        private System.Windows.Forms.Label lblNewOrderProductAmount;
        private System.Windows.Forms.TextBox tbxCurrentOrderCustomer;
        private System.Windows.Forms.CheckedListBox clstbxCurrentOrderCart;
        private System.Windows.Forms.Label lblCurrentOrderCustomer;
        private System.Windows.Forms.Button btnRemoveSelectedProducts;
        private System.Windows.Forms.CheckedListBox clstbxShoppingCart;
        private System.Windows.Forms.Button btnCurrentOrderRemoveProduct;
        private System.Windows.Forms.Button btnCurrentOrderDelete;
        private System.Windows.Forms.Button btnCurrentOrderClose;
        private System.Windows.Forms.TextBox tbxCurrentOrderCreateTime;
        private System.Windows.Forms.Label lblCurrentOrderCreateTime;
    }
}