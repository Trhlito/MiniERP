using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class OrderHistoryForm : Form
    {
        // Připojovací řetězec k databázi
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=MiniERP;Integrated Security=True;TrustServerCertificate=True;";

        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        // Událost při načtení formuláře
        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        // Načte objednávky z databáze a zobrazí je v tabulce
        private void LoadOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT OrderID, CustomerID, OrderDate FROM Orders", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvOrders.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání objednávek: " + ex.Message);
            }
        }

        // Otevře formulář pro vytvoření nové objednávky
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();

            // Po zavření formuláře znovu načti historii objednávek
            LoadOrders();
        }
    }
}
