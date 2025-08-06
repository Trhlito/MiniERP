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
            // Clear the content panel on the right
            panelContent.Controls.Clear();

            // Add default welcome content
            Label lblWelcome = new Label();
            lblWelcome.Text = "Welcome to the MiniERP System!";
            lblWelcome.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(20, 20);

            panelContent.Controls.Add(lblWelcome);
        }

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Placeholder for potential label click logic
        }
    }
}
