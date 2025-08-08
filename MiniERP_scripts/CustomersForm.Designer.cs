namespace ERP3
{
    partial class CustomersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadCustomers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridCustomers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnLoadCustomers = new Button();
            btnAddCustomer = new Button();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            txtSearch = new TextBox();
            dataGridCustomers = new DataGridView();

            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).BeginInit();
            SuspendLayout();

            // Tabulka "Customers"
            dataGridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCustomers.Location = new Point(20, 20);
            dataGridCustomers.MultiSelect = false;
            dataGridCustomers.Name = "dataGridCustomers";
            dataGridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCustomers.Size = new Size(610, 280);
            dataGridCustomers.TabIndex = 0;

            // Tlačítko pro načtení zákazníků
            btnLoadCustomers.Location = new Point(20, 310);
            btnLoadCustomers.Name = "btnLoadCustomers";
            btnLoadCustomers.Size = new Size(150, 30);
            btnLoadCustomers.Text = "Načíst zákazníky";
            btnLoadCustomers.UseVisualStyleBackColor = true;
            btnLoadCustomers.Click += btnLoadCustomers_Click;

            // Tlačítko přidání zákazníka
            btnAddCustomer.Location = new Point(180, 310);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(130, 30);
            btnAddCustomer.Text = "Přidat";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += (s, e) => AddCustomer();

            // Tlačítko úprava zákazníka
            btnEditCustomer.Location = new Point(320, 310);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(130, 30);
            btnEditCustomer.Text = "Upravit";
            btnEditCustomer.UseVisualStyleBackColor = true;
            btnEditCustomer.Click += (s, e) => EditCustomer();

            // Tlačítko smazání zákazníka
            btnDeleteCustomer.Location = new Point(460, 310);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(130, 30);
            btnDeleteCustomer.Text = "Smazat";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += (s, e) => DeleteCustomer();

            // Pole hledání zákazníků / Filtrování
            txtSearch.Location = new Point(20, 350);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Hledat zákazníka...";
            txtSearch.Size = new Size(610, 23);
            txtSearch.TextChanged += txtSearch_TextChanged;

            // Vlastnosti
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 400);
            Controls.Add(dataGridCustomers);
            Controls.Add(btnLoadCustomers);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(txtSearch);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomersForm";
            Text = "Zákazníci";
            Load += CustomersForm_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
