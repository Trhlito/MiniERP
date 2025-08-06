namespace ERP3
{
    partial class StockForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnRemoveStock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();

            // DataGridView – tabulka zásob
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(20, 20);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(500, 250);
            this.dgvStock.MultiSelect = false;

            // NumericUpDown – pole pro zadání množství
            this.nudQuantity.Location = new System.Drawing.Point(20, 290);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Maximum = 10000;
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 23);

            // Tlačítko pro přidání na sklad
            this.btnAddStock.Location = new System.Drawing.Point(160, 290);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(120, 30);
            this.btnAddStock.Text = "Přidat na sklad";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);

            // Tlačítko pro odebrání ze skladu
            this.btnRemoveStock.Location = new System.Drawing.Point(300, 290);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(120, 30);
            this.btnRemoveStock.Text = "Odebrat ze skladu";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            this.btnRemoveStock.Click += new System.EventHandler(this.btnRemoveStock_Click);

            // Nastavení formuláře
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 350);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddStock);
            this.Controls.Add(this.btnRemoveStock);
            this.Name = "StockForm";
            this.Text = "Sklad";

            // Událost při načtení formuláře
            this.Load += new System.EventHandler(this.StockForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
