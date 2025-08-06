namespace ERP3
{
    partial class EditProductForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        // Uvolnění prostředků
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        // Inicializace komponent formuláře
        private void InitializeComponent()
        {
            txtName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            cmbCategory = new System.Windows.Forms.ComboBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            SuspendLayout();

            // TextBox pro název produktu
            txtName.Location = new System.Drawing.Point(30, 30);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Název produktu";
            txtName.Size = new System.Drawing.Size(240, 23);

            // TextBox pro cenu
            txtPrice.Location = new System.Drawing.Point(30, 70);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Cena";
            txtPrice.Size = new System.Drawing.Size(240, 23);

            // ComboBox pro výběr kategorie
            cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategory.Location = new System.Drawing.Point(30, 110);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new System.Drawing.Size(240, 23);
            cmbCategory.Items.AddRange(new object[] { "Notebook", "Monitor", "Příslušenství" });

            // Tlačítko pro uložení změn
            btnSave.Location = new System.Drawing.Point(30, 150);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 30);
            btnSave.Text = "Uložit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += new System.EventHandler(btnSave_Click);

            // Tlačítko pro zrušení úprav
            btnCancel.Location = new System.Drawing.Point(170, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 30);
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += new System.EventHandler(btnCancel_Click);

            // Vlastnosti formuláře
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 210);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "EditProductForm";
            Text = "Upravit produkt";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
