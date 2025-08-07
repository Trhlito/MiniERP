namespace ERP3
{
    partial class LoginForm
    {
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnOk;

        private void InitializeComponent()
        {
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnOk = new Button();
            SuspendLayout();

            // 
            // lblUsername
            // Popisek pro uživatelské jméno
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 30);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(116, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Přihlašovací jméno";

            // 
            // txtUsername
            // TextBox pro zadání uživatelského jména
            txtUsername.Location = new Point(50, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 2;

            // 
            // lblPassword
            // Popisek pro heslo
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 85);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(39, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Heslo";

            // 
            // txtPassword
            // TextBox pro zadání hesla
            txtPassword.Location = new Point(50, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 4;

            // 
            // btnOk
            // Tlačítko pro potvrzení přihlášení
            btnOk.Location = new Point(90, 150);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 35);
            btnOk.TabIndex = 5;
            btnOk.Text = "Potvrdit";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;

            // 
            // LoginForm
            // Vlastnosti formuláře přihlášení
            ClientSize = new Size(300, 220);
            Controls.Add(btnOk);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "LoginForm";
            Text = "Přihlášení";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
