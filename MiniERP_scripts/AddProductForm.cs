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

        // Zpracuje uložení nového produktu do databáze
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString() ?? "";
            decimal price;

            // Validace: kontrola vyplněného názvu a kategorie
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Vyplňte prosím název a kategorii produktu.");
                return;
            }

            // Validace: cena musí být platné číslo a nesmí být záporná
            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Neplatná cena.");
                return;
            }

            // Připojovací řetězec k databázi
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("InsertProductsWithCode", conn)) // Volání uložené procedury
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Předání parametrů do procedury
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
                // Zobrazení chybové hlášky v případě selhání
                MessageBox.Show("Chyba při přidávání produktu: " + ex.Message);
            }
        }
    }
}
