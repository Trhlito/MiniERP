using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        // Uzavře formulář bez uložení
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Uložení nového produktu 
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            decimal price;

            // Kontrola vyplněného názvu a kategorie
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Vyplňte prosím název a kategorii produktu.");
                return;
            }

            // Validace, že cena musí být platné číslo a nesmí být záporné
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Neplatná cena.");
                return;
            }

            // Připojení k databázi
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("InsertProductsWithCode", conn)) // Volání uložené procedury (InsertProductsWithCode)
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Předání parametrů 
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@Price", price);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Úspěšné uložení
                    MessageBox.Show("Produkt byl úspěšně přidán.", "Hotovo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Zobrazení chybové hlášky
                MessageBox.Show("Chyba při přidávání produktu: " + ex.Message);
            }
        }
    }
}
