namespace Webshop_Management {
    partial class WebShopForm_ClosedOrders {
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
            this.tbxCurrentCompletedOrderCustomer = new System.Windows.Forms.TextBox();
            this.lblCurrentCompletedOrderCustomer = new System.Windows.Forms.Label();
            this.lstbxCompletedOrders = new System.Windows.Forms.ListBox();
            this.lstbxCurrentCompletedOrder = new System.Windows.Forms.ListBox();
            this.lblCurrentCompletedOrderDate = new System.Windows.Forms.Label();
            this.tbxCurrentCompletedOrderDate = new System.Windows.Forms.TextBox();
            this.grpbxSelectedOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectDatabase
            // 
            this.lblSelectDatabase.AutoSize = true;
            this.lblSelectDatabase.Location = new System.Drawing.Point(12, 9);
            this.lblSelectDatabase.Name = "lblSelectDatabase";
            this.lblSelectDatabase.Size = new System.Drawing.Size(124, 13);
            this.lblSelectDatabase.TabIndex = 20;
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
            this.cbbxDatabase.Size = new System.Drawing.Size(575, 21);
            this.cbbxDatabase.TabIndex = 19;
            this.cbbxDatabase.Text = "Abgeschlossene Bestellungen";
            // 
            // grpbxSelectedOrder
            // 
            this.grpbxSelectedOrder.Controls.Add(this.tbxCurrentCompletedOrderDate);
            this.grpbxSelectedOrder.Controls.Add(this.lblCurrentCompletedOrderDate);
            this.grpbxSelectedOrder.Controls.Add(this.lstbxCurrentCompletedOrder);
            this.grpbxSelectedOrder.Controls.Add(this.tbxCurrentCompletedOrderCustomer);
            this.grpbxSelectedOrder.Controls.Add(this.lblCurrentCompletedOrderCustomer);
            this.grpbxSelectedOrder.Location = new System.Drawing.Point(278, 58);
            this.grpbxSelectedOrder.Name = "grpbxSelectedOrder";
            this.grpbxSelectedOrder.Size = new System.Drawing.Size(322, 472);
            this.grpbxSelectedOrder.TabIndex = 18;
            this.grpbxSelectedOrder.TabStop = false;
            this.grpbxSelectedOrder.Text = "Aktuelle Bestellung";
            // 
            // tbxCurrentCompletedOrderCustomer
            // 
            this.tbxCurrentCompletedOrderCustomer.Location = new System.Drawing.Point(59, 22);
            this.tbxCurrentCompletedOrderCustomer.Name = "tbxCurrentCompletedOrderCustomer";
            this.tbxCurrentCompletedOrderCustomer.ReadOnly = true;
            this.tbxCurrentCompletedOrderCustomer.Size = new System.Drawing.Size(250, 20);
            this.tbxCurrentCompletedOrderCustomer.TabIndex = 28;
            // 
            // lblCurrentCompletedOrderCustomer
            // 
            this.lblCurrentCompletedOrderCustomer.AutoSize = true;
            this.lblCurrentCompletedOrderCustomer.Location = new System.Drawing.Point(6, 25);
            this.lblCurrentCompletedOrderCustomer.Name = "lblCurrentCompletedOrderCustomer";
            this.lblCurrentCompletedOrderCustomer.Size = new System.Drawing.Size(41, 13);
            this.lblCurrentCompletedOrderCustomer.TabIndex = 20;
            this.lblCurrentCompletedOrderCustomer.Text = "Kunde:";
            // 
            // lstbxCompletedOrders
            // 
            this.lstbxCompletedOrders.FormattingEnabled = true;
            this.lstbxCompletedOrders.Location = new System.Drawing.Point(12, 58);
            this.lstbxCompletedOrders.Name = "lstbxCompletedOrders";
            this.lstbxCompletedOrders.Size = new System.Drawing.Size(260, 472);
            this.lstbxCompletedOrders.TabIndex = 16;
            // 
            // lstbxCurrentCompletedOrder
            // 
            this.lstbxCurrentCompletedOrder.FormattingEnabled = true;
            this.lstbxCurrentCompletedOrder.Location = new System.Drawing.Point(9, 77);
            this.lstbxCurrentCompletedOrder.Name = "lstbxCurrentCompletedOrder";
            this.lstbxCurrentCompletedOrder.Size = new System.Drawing.Size(307, 381);
            this.lstbxCurrentCompletedOrder.TabIndex = 29;
            // 
            // lblCurrentCompletedOrderDate
            // 
            this.lblCurrentCompletedOrderDate.AutoSize = true;
            this.lblCurrentCompletedOrderDate.Location = new System.Drawing.Point(6, 51);
            this.lblCurrentCompletedOrderDate.Name = "lblCurrentCompletedOrderDate";
            this.lblCurrentCompletedOrderDate.Size = new System.Drawing.Size(99, 13);
            this.lblCurrentCompletedOrderDate.TabIndex = 30;
            this.lblCurrentCompletedOrderDate.Text = "Abgeschlossen am:";
            // 
            // tbxCurrentCompletedOrderDate
            // 
            this.tbxCurrentCompletedOrderDate.Location = new System.Drawing.Point(111, 48);
            this.tbxCurrentCompletedOrderDate.Name = "tbxCurrentCompletedOrderDate";
            this.tbxCurrentCompletedOrderDate.ReadOnly = true;
            this.tbxCurrentCompletedOrderDate.Size = new System.Drawing.Size(87, 20);
            this.tbxCurrentCompletedOrderDate.TabIndex = 31;
            // 
            // WebShopForm_ClosedOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 548);
            this.Controls.Add(this.lblSelectDatabase);
            this.Controls.Add(this.cbbxDatabase);
            this.Controls.Add(this.grpbxSelectedOrder);
            this.Controls.Add(this.lstbxCompletedOrders);
            this.Name = "WebShopForm_ClosedOrders";
            this.Text = "WebShopForm_ClosedOrders";
            this.grpbxSelectedOrder.ResumeLayout(false);
            this.grpbxSelectedOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDatabase;
        private System.Windows.Forms.ComboBox cbbxDatabase;
        private System.Windows.Forms.GroupBox grpbxSelectedOrder;
        private System.Windows.Forms.TextBox tbxCurrentCompletedOrderCustomer;
        private System.Windows.Forms.Label lblCurrentCompletedOrderCustomer;
        private System.Windows.Forms.ListBox lstbxCompletedOrders;
        private System.Windows.Forms.ListBox lstbxCurrentCompletedOrder;
        private System.Windows.Forms.TextBox tbxCurrentCompletedOrderDate;
        private System.Windows.Forms.Label lblCurrentCompletedOrderDate;
    }
}