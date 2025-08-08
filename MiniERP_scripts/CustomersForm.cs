using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ERP3
{
    public partial class CustomersForm : Form
    {
        private DataTable customerTable;

        public CustomersForm()
        {
            InitializeComponent();
        }

        // Načtení zákazníků z databáze
        private void CustomersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // Načtení nového zákazníka
        private void btnLoadCustomers_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        // Filtrování zákazníků
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearch.Text.Trim().Replace("'", "''");
            if (customerTable != null)
            {
                customerTable.DefaultView.RowFilter = $"Name LIKE '%{filterText}%' OR Email LIKE '%{filterText}%'";
            }
        }

        // Připojení a update
        private void LoadCustomers()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT CustomerID, Name, Email, Phone FROM Customers";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    customerTable = new DataTable();
                    adapter.Fill(customerTable);
                    dataGridCustomers.DataSource = customerTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při načítání dat: " + ex.Message);
                }
            }
        }

        // Otevře formulář pro přidání zákazníka
        private void AddCustomer()
        {
            using (var dialog = new AddCustomerForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }

        // Zvoleného zákazníka načte do formuláře úpravy zákazníka
        private void EditCustomer()
        {
            if (dataGridCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte zákazníka k úpravě.");
                return;
            }

            var row = dataGridCustomers.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["CustomerID"].Value);
            string name = row.Cells["Name"].Value.ToString();
            string email = row.Cells["Email"].Value.ToString();
            string phone = row.Cells["Phone"].Value.ToString();

            using (var dialog = new EditCustomerForm(id, name, email, phone))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadCustomers();
                }
            }
        }

        // Zvoleného zákazníka smaže
        private void DeleteCustomer()
        {
            if (dataGridCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte zákazníka ke smazání.");
                return;
            }

            var result = MessageBox.Show("Opravdu chcete smazat tohoto zákazníka?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int customerId = Convert.ToInt32(dataGridCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
                string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                LoadCustomers();
            }
        }

        // Ovládací prvky
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}
