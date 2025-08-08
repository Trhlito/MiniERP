namespace ERP3
{
    partial class EditCustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        // Ovladače
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;

        // Uvolnění prostředků 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Uživatelského rozhraní
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            lblName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();

            SuspendLayout();

            // Popisek pro pole "Jméno"
            lblName.Text = "Jméno:";
            lblName.Location = new System.Drawing.Point(20, 20);
            lblName.Size = new System.Drawing.Size(100, 20);

            // text:Jméno
            txtName.Location = new System.Drawing.Point(120, 20);
            txtName.Size = new System.Drawing.Size(200, 23);

            // Popisek pro pole "E-mail"
            lblEmail.Text = "E-mail:";
            lblEmail.Location = new System.Drawing.Point(20, 60);
            lblEmail.Size = new System.Drawing.Size(100, 20);

            // text:Email
            txtEmail.Location = new System.Drawing.Point(120, 60);
            txtEmail.Size = new System.Drawing.Size(200, 23);

            // Popisek pro pole "Telefon"
            lblPhone.Text = "Telefon:";
            lblPhone.Location = new System.Drawing.Point(20, 100);
            lblPhone.Size = new System.Drawing.Size(100, 20);

            // text:Telefonní číslo
            txtPhone.Location = new System.Drawing.Point(120, 100);
            txtPhone.Size = new System.Drawing.Size(200, 23);

            // Tlačítko pro uložení změny u zákazníka
            btnSave.Text = "Uložit";
            btnSave.Location = new System.Drawing.Point(120, 140);
            btnSave.Size = new System.Drawing.Size(100, 30);
            btnSave.Click += new System.EventHandler(btnSave_Click);

            // Vlastnosti
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(350, 200);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(btnSave);
            Name = "EditCustomerForm";
            Text = "Upravit zákazníka";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
