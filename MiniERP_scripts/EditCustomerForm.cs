using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ERP3
{
    public partial class EditCustomerForm : Form
    {
        // ID zákazníka
        private int customerId;

        // Předání aktuálních hodnot zákazníka
        public EditCustomerForm(int id, string name, string email, string phone)
        {
            InitializeComponent();
            customerId = id;
            txtName.Text = name;
            txtEmail.Text = email;
            txtPhone.Text = phone;
        }

        // Uložení změn do databáze!
        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text.Trim();
            string newEmail = txtEmail.Text.Trim();
            string newPhone = txtPhone.Text.Trim();

            // Kontrola nutných polí
            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newEmail))
            {
                MessageBox.Show("Please fill in both name and email.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Připojení a dotaz(update) 
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=MiniERP;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "UPDATE Customers SET Name = @Name, Email = @Email, Phone = @Phone WHERE CustomerID = @CustomerID";

            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);

            // Parametry dotazu
            cmd.Parameters.AddWithValue("@Name", newName);
            cmd.Parameters.AddWithValue("@Email", newEmail);
            cmd.Parameters.AddWithValue("@Phone", newPhone);
            cmd.Parameters.AddWithValue("@CustomerID", customerId);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer was successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
