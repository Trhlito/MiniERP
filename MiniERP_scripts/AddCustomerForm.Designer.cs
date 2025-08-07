namespace ERP3
{
    partial class AddCustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        // Ovládací prvky formuláře
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelStatus;

        // Uvolnění prostředků při zavírání formuláře
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        // Inicializace uživatelského rozhraní
        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.lblEmail = new Label();
            this.lblPhone = new Label();
            this.txtName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPhone = new TextBox();
            this.btnSave = new Button();
            this.labelStatus = new Label();
            this.SuspendLayout();

            // 
            // lblName
            // Popisek pro pole "Jméno"
            this.lblName.Location = new System.Drawing.Point(30, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.Text = "Jméno:"; 

            // 
            // txtName
            this.txtName.Location = new System.Drawing.Point(140, 30);
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.Name = "txtName";

            // 
            // lblEmail
            // Popisek pro pole "E-mail"
            this.lblEmail.Location = new System.Drawing.Point(30, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 20);
            this.lblEmail.Text = "E-mail:"; 

            // 
            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(140, 70);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.Name = "txtEmail";

            // 
            // lblPhone
            // Popisek pro pole "Telefon"
            this.lblPhone.Location = new System.Drawing.Point(30, 110);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.Text = "Telefon:"; 

            // 
            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(140, 110);
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.Name = "txtPhone";

            // 
            // btnSave
            // Tlačítko pro uložení zákazníka
            this.btnSave.Location = new System.Drawing.Point(140, 150);
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Uložit"; 
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // labelStatus
            // Štítek pro zobrazení výsledku (úspěch / chyba)
            this.labelStatus.Location = new System.Drawing.Point(30, 190);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(310, 30);
            this.labelStatus.ForeColor = System.Drawing.Color.Red;

            // 
            // AddCustomerForm
            this.ClientSize = new System.Drawing.Size(380, 240);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelStatus);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomerForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Přidat zákazníka"; 
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
