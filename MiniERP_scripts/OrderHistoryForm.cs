using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class OrderHistoryForm : Form
    {
        // Připojení
        private string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=MiniERP;Integrated Security=True;TrustServerCertificate=True;";

        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        // volání po aktualizaci
        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        // aktualizace z databáze
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

        // Vytvoření nové objednávky - volání formuláře
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            OrdersForm form = new OrdersForm();
            form.ShowDialog();

            // Po zavření formuláře provede aktualizaci
            LoadOrders();
        }
    }
}
