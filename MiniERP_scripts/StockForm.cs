using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class StockForm : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MiniERP;Integrated Security=True";

        public StockForm()
        {
            InitializeComponent();
        }

        // Načte stav zásob při načtení formuláře
        private void StockForm_Load(object sender, EventArgs e)
        {
            LoadStock();
        }

        // Načtení dat o zásobách z databáze
        private void LoadStock()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT ProductID, Name, Stock FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvStock.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání skladu: " + ex.Message);
            }
        }

        // Přidání množství ke skladu pro vybraný produkt
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte produkt pro přidání množství.");
                return;
            }

            int productId = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["ProductID"].Value);
            int amount = (int)nudQuantity.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Products SET Stock = Stock + @Amount WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Množství bylo přidáno.");
                LoadStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při přidávání na sklad: " + ex.Message);
            }
        }

        // Odebrání množství ze skladu pro vybraný produkt
        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte produkt pro odebrání množství.");
                return;
            }

            int productId = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["ProductID"].Value);
            int amount = (int)nudQuantity.Value;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Products SET Stock = CASE WHEN Stock - @Amount >= 0 THEN Stock - @Amount ELSE 0 END WHERE ProductID = @ProductID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@ProductID", productId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Množství bylo odebráno.");
                LoadStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při odebírání ze skladu: " + ex.Message);
            }
        }
    }
}
