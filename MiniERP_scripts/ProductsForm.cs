using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP3
{
    public partial class ProductsForm : Form
    {
        // Datová tabulka pro načtené produkty
        private DataTable productsTable;

        public ProductsForm()
        {
            InitializeComponent();
        }

        // Událost při načtení formuláře
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        // Načte produkty z databáze a zobrazí je v tabulce
        private void LoadProducts()
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "SELECT ProductID, Name, Category, ProductCode, Price, Stock FROM Products";

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            try
            {
                productsTable = new DataTable();
                adapter.Fill(productsTable);
                dataGridProducts.DataSource = productsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání produktů: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Otevře formulář pro přidání nového produktu
        private void AddProduct()
        {
            using (var dialog = new AddProductForm())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        // Otevře formulář pro úpravu vybraného produktu
        private void EditProduct()
        {
            if (dataGridProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte produkt k úpravě.", "Úprava produktu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dataGridProducts.SelectedRows[0];

            try
            {
                int id = Convert.ToInt32(row.Cells["ProductID"].Value);
                string name = row.Cells["Name"].Value.ToString();
                string category = row.Cells["Category"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                int stock = Convert.ToInt32(row.Cells["Stock"].Value);

                using (var form = new EditProductForm(id, name, price, category))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při načítání dat produktu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Smaže vybraný produkt z databáze
        private void DeleteProduct()
        {
            if (dataGridProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vyberte produkt ke smazání.", "Mazání produktu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Opravdu chcete smazat tento produkt?", "Potvrzení", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int productId = Convert.ToInt32(dataGridProducts.SelectedRows[0].Cells["ProductID"].Value);

                string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
                string query = "DELETE FROM Products WHERE ProductID = @ProductID";

                try
                {
                    using SqlConnection connection = new SqlConnection(connectionString);
                    using SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProductID", productId);
                    connection.Open();
                    command.ExecuteNonQuery();
                    LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chyba při mazání produktu: " + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Filtrování produktů podle textu ve vyhledávacím poli
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtSearchProduct.Text.Trim().Replace("'", "''");
            if (productsTable != null)
            {
                productsTable.DefaultView.RowFilter =
                    $"Name LIKE '%{filterText}%' OR Category LIKE '%{filterText}%' OR ProductCode LIKE '%{filterText}%'";
            }
        }

        // Přiřazení funkcí ke kliknutím na tlačítka
        private void BtnAddProduct_Click(object sender, EventArgs e) => AddProduct();
        private void BtnEditProduct_Click(object sender, EventArgs e) => EditProduct();
        private void BtnDeleteProduct_Click(object sender, EventArgs e) => DeleteProduct();
    }
}
