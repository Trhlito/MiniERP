using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ERP3
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        // Událost: Uložení nového zákazníka do databáze
        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Kontrola nutných polí
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in both name and email.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Připojení a SQL dotazy
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "INSERT INTO Customers (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";

            using SqlConnection connection = new SqlConnection(connectionString);
            using SqlCommand command = new SqlCommand(query, connection);

            // Předání parametrů do dotazu
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                // Kontrola výsledku – úspěšné vložení
                if (result > 0)
                {
                    labelStatus.Text = "Customer was successfully added.";
                    labelStatus.ForeColor = Color.Green;
                    this.DialogResult = DialogResult.OK;
                    this.Close(); // Zavření formuláře
                }
                else
                {
                    labelStatus.Text = "Saving failed.";
                    labelStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                // Chybová zpráva
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
