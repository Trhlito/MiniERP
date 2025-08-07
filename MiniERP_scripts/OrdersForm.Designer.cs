namespace ERP3
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProducts;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // lblCustomer – popisek k výběru zákazníka
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(20, 20);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(57, 15);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Zákazník:";

            // cmbCustomers – rozbalovací seznam zákazníků
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(130, 17);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(300, 23);
            this.cmbCustomers.TabIndex = 1;

            // lblProducts – popisek k produktům
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(20, 60);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(112, 15);
            this.lblProducts.TabIndex = 2;
            this.lblProducts.Text = "Dostupné produkty:";

            // dgvProducts – tabulka s produkty
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(20, 80);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(600, 250);
            this.dgvProducts.TabIndex = 3;

            // btnCreateOrder – tlačítko pro vytvoření objednávky
            this.btnCreateOrder.Location = new System.Drawing.Point(520, 350);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(100, 30);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "Vytvořit objednávku";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);

            // OrdersForm – hlavní konfigurace formuláře
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnCreateOrder);
            this.Name = "OrdersForm";
            this.Text = "Nová objednávka";
            this.Load += new System.EventHandler(this.OrdersForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
