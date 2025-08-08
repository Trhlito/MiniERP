using System;
using System.Windows.Forms;

namespace ERP3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            btnHomepage_Click(null, null);
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            // Smazání obsahu - Vrácení na úvodní stránku
            panelContent.Controls.Clear();

            // Design pro Úvodní stránku
            Label lblWelcome = new Label();
            lblWelcome.Text = "Vítejte v systému MiniERP!";
            lblWelcome.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(20, 20);

            panelContent.Controls.Add(lblWelcome);
        }

        // Přiřazení pro Zákazníky
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            CustomersForm customersForm = new CustomersForm();
            customersForm.TopLevel = false;
            customersForm.FormBorderStyle = FormBorderStyle.None;
            customersForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(customersForm);
            customersForm.Show();
        }

        // Přiřazení pro Produkty
        private void btnProducts_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            ProductsForm productsForm = new ProductsForm();
            productsForm.TopLevel = false;
            productsForm.FormBorderStyle = FormBorderStyle.None;
            productsForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(productsForm);
            productsForm.Show();
        }

        // Přiřazení pro Objednávky
        private void btnOrders_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            OrderHistoryForm orderHistoryForm = new OrderHistoryForm();
            orderHistoryForm.TopLevel = false;
            orderHistoryForm.FormBorderStyle = FormBorderStyle.None;
            orderHistoryForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(orderHistoryForm);
            orderHistoryForm.Show();
        }
        // Přiřazení pro Sklad
        private void btnStock_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();

            StockForm stockForm = new StockForm();
            stockForm.TopLevel = false;
            stockForm.FormBorderStyle = FormBorderStyle.None;
            stockForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(stockForm);
            stockForm.Show();
        }

        // Přiřazení pro ukončení - killnutí  
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
