using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class EditProductForm : Form
    {
        private int productId;

        // Konstruktor přijímá hodnoty pro předvyplnění polí formuláře
        public EditProductForm(int id, string name, decimal price, string category)
        {
            InitializeComponent();
            productId = id;
            txtName.Text = name;
            txtPrice.Text = price.ToString("0.00");
            cmbCategory.SelectedItem = category;
        }

        // Uložení změn produktu do databáze
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString();

            // Validace ceny
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Neplatná cena.");
                return;
            }

            // Kontrola vyplnění všech polí
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Vyplňte prosím všechna pole.");
                return;
            }

            // Připojení k databázi a provedení aktualizačního dotazu
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "UPDATE Products SET Name = @Name, Price = @Price, Category = @Category WHERE ProductID = @ProductID";

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@ProductID", productId);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produkt byl úspěšně aktualizován.");
                this.DialogResult = DialogResult.OK;
                this.Close(); // Zavření formuláře po úspěchu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při aktualizaci produktu: " + ex.Message);
            }
        }

        // Zavření formuláře bez uložení
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
