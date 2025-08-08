using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class OrdersForm : Form
    {
        // P
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MiniERP;Integrated Security=True";

        public OrdersForm()
        {
            InitializeComponent();
        }

        // Načtení dat po spuštění formuláře
        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadProducts();
        }

        // Načtení zákazníků (ComboBox)
        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CustomerID, Name FROM Customers", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                cmbCustomers.DataSource = dt;
                cmbCustomers.DisplayMember = "Name";
                cmbCustomers.ValueMember = "CustomerID";
            }
        }

        // Načtení produktů (tabulka) 
        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT ProductID, Name, Price FROM Products", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Sloupec pro zadání množství
                dt.Columns.Add("Quantity", typeof(int));
                dgvProducts.DataSource = dt;
            }
        }

        // Nová objednávka / Uložení
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue == null)
            {
                MessageBox.Show("Vyberte zákazníka.");
                return;
            }

            int customerId = Convert.ToInt32(cmbCustomers.SelectedValue);
            List<OrderItem> orderItems = new List<OrderItem>();

            // Cyklus pro Procházení produktů a zjištění zadaného množství
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["Quantity"].Value != null &&
                    row.Cells["Quantity"].Value != DBNull.Value &&
                    int.TryParse(row.Cells["Quantity"].Value.ToString(), out int quantity) &&
                    quantity > 0)
                {
                    int productId = Convert.ToInt32(row.Cells["ProductID"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["Price"].Value);

                    orderItems.Add(new OrderItem
                    {
                        ProductID = productId,
                        Quantity = quantity,
                        UnitPrice = unitPrice
                    });
                }
            }

            if (orderItems.Count == 0)
            {
                MessageBox.Show("Zadejte množství alespoň u jednoho produktu.");
                return;
            }

            try
            {
                // Příprava tabulky pro předání jako Table-Valued Parametr
                var table = new DataTable();
                table.Columns.Add("ProductID", typeof(int));
                table.Columns.Add("Quantity", typeof(int));
                table.Columns.Add("UnitPrice", typeof(decimal));

                foreach (var item in orderItems)
                {
                    table.Rows.Add(item.ProductID, item.Quantity, item.UnitPrice);
                }

                using (var conn = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand("spCreateOrderWithItems", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", customerId);
                    cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                    var itemsParam = cmd.Parameters.AddWithValue("@Items", table);
                    itemsParam.SqlDbType = SqlDbType.Structured;
                    itemsParam.TypeName = "dbo.OrderItemType";

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Objednávka byla úspěšně vytvořena.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání objednávky: " + ex.Message);
            }
        }
    }


    public class OrderItem
    {
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
