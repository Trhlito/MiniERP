namespace ERP3
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        
        //Vlastnosti 
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnHomepage = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();

            this.panelMenu.SuspendLayout();
            this.SuspendLayout();

            // Hlavní Menu
            this.panelMenu.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.btnStock);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.btnHomepage);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(150, 450);
            this.panelMenu.TabIndex = 0;

            // Tlačítko pro Ukončení aplikace
            this.btnExit.Location = new System.Drawing.Point(12, 340);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Konec";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);


            // Titul
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitle.Location = new System.Drawing.Point(3, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "MiniERP";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);

            // Tlačítko: Sklad
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStock.Location = new System.Drawing.Point(12, 285);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(130, 40);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Sklad";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);

            // Tlačítko: Objednávky
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOrders.Location = new System.Drawing.Point(12, 235);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(130, 40);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Objednávky";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);

            // Tlačítko: Produkty
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProducts.Location = new System.Drawing.Point(12, 185);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(130, 40);
            this.btnProducts.TabIndex = 2;
            this.btnProducts.Text = "Produkty";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);


            // Tlačítko: Zákazníci
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.Location = new System.Drawing.Point(12, 135);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(130, 40);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Zákazníci";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);

            // Domovská stránka
            this.btnHomepage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHomepage.Location = new System.Drawing.Point(12, 85);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(130, 40);
            this.btnHomepage.TabIndex = 0;
            this.btnHomepage.Text = "Úvodní stránka";
            this.btnHomepage.UseVisualStyleBackColor = true;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);

            // Obsah
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(150, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(650, 450);
            this.panelContent.TabIndex = 1;

            // Vlastnosti Okna
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainForm";
            this.Text = "MiniERP - Hlavní okno";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
