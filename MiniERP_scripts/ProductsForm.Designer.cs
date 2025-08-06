namespace ERP3
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;

        // Komponenty formuláře
        private System.Windows.Forms.DataGridView dataGridProducts; // Tabulka produktů
        private System.Windows.Forms.Button btnLoadProducts;        // Tlačítko pro načtení produktů z DB
        private System.Windows.Forms.Button btnAddProduct;          // Tlačítko pro přidání nového produktu
        private System.Windows.Forms.Button btnEditProduct;         // Tlačítko pro úpravu vybraného produktu
        private System.Windows.Forms.Button btnDeleteProduct;       // Tlačítko pro smazání produktu
        private System.Windows.Forms.TextBox txtSearchProduct;      // Textbox pro filtrování produktů

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // Inicializace komponent
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.SuspendLayout();

            // === DataGridView: Výpis produktů ===
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Location = new System.Drawing.Point(20, 20);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(740, 280);
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.MultiSelect = false;

            // === Tlačítko: Načíst produkty z databáze ===
            this.btnLoadProducts.Location = new System.Drawing.Point(20, 310);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(100, 30);
            this.btnLoadProducts.Text = "Načíst";
            this.btnLoadProducts.UseVisualStyleBackColor = true;
            this.btnLoadProducts.Click += new System.EventHandler(this.ProductsForm_Load);

            // === Tlačítko: Přidat nový produkt ===
            this.btnAddProduct.Location = new System.Drawing.Point(130, 310);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 30);
            this.btnAddProduct.Text = "Přidat";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);

            // === Tlačítko: Upravit vybraný produkt ===
            this.btnEditProduct.Location = new System.Drawing.Point(240, 310);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(100, 30);
            this.btnEditProduct.Text = "Upravit";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.BtnEditProduct_Click);

            // === Tlačítko: Smazat vybraný produkt ===
            this.btnDeleteProduct.Location = new System.Drawing.Point(350, 310);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteProduct.Text = "Smazat";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.BtnDeleteProduct_Click);

            // === TextBox: Vyhledávání produktů ===
            this.txtSearchProduct.Location = new System.Drawing.Point(20, 350);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(740, 23);
            this.txtSearchProduct.PlaceholderText = "Hledat produkt...";
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);

            // === ProductsForm (hlavní okno) ===
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.btnLoadProducts);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Name = "ProductsForm";
            this.Text = "Produkty";
            this.Load += new System.EventHandler(this.ProductsForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
