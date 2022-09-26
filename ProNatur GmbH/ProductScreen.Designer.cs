
namespace ProNatur_GmbH
{
    partial class ProductScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.btnProdEdit = new System.Windows.Forms.Button();
            this.btnFieldsClear = new System.Windows.Forms.Button();
            this.btnProdDelete = new System.Windows.Forms.Button();
            this.productsDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(84, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(261, 23);
            this.tbName.TabIndex = 1;
            // 
            // tbBrand
            // 
            this.tbBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBrand.ForeColor = System.Drawing.Color.White;
            this.tbBrand.Location = new System.Drawing.Point(84, 62);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(172, 23);
            this.tbBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie:";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.Location = new System.Drawing.Point(84, 120);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(83, 23);
            this.tbPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis:";
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.ForeColor = System.Drawing.Color.White;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.cbCategory.Location = new System.Drawing.Point(84, 91);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(172, 23);
            this.cbCategory.TabIndex = 8;
            // 
            // btnProdSave
            // 
            this.btnProdSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdSave.ForeColor = System.Drawing.Color.White;
            this.btnProdSave.Location = new System.Drawing.Point(84, 162);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(83, 23);
            this.btnProdSave.TabIndex = 9;
            this.btnProdSave.Text = "Speichern";
            this.btnProdSave.UseVisualStyleBackColor = false;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // btnProdEdit
            // 
            this.btnProdEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdEdit.ForeColor = System.Drawing.Color.White;
            this.btnProdEdit.Location = new System.Drawing.Point(173, 162);
            this.btnProdEdit.Name = "btnProdEdit";
            this.btnProdEdit.Size = new System.Drawing.Size(83, 23);
            this.btnProdEdit.TabIndex = 10;
            this.btnProdEdit.Text = "Bearbeiten";
            this.btnProdEdit.UseVisualStyleBackColor = false;
            this.btnProdEdit.Click += new System.EventHandler(this.btnProdEdit_Click);
            // 
            // btnFieldsClear
            // 
            this.btnFieldsClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnFieldsClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFieldsClear.ForeColor = System.Drawing.Color.White;
            this.btnFieldsClear.Location = new System.Drawing.Point(262, 162);
            this.btnFieldsClear.Name = "btnFieldsClear";
            this.btnFieldsClear.Size = new System.Drawing.Size(83, 23);
            this.btnFieldsClear.TabIndex = 11;
            this.btnFieldsClear.Text = "Leeren";
            this.btnFieldsClear.UseVisualStyleBackColor = false;
            this.btnFieldsClear.Click += new System.EventHandler(this.btnFieldsClear_Click);
            // 
            // btnProdDelete
            // 
            this.btnProdDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdDelete.ForeColor = System.Drawing.Color.White;
            this.btnProdDelete.Location = new System.Drawing.Point(351, 162);
            this.btnProdDelete.Name = "btnProdDelete";
            this.btnProdDelete.Size = new System.Drawing.Size(83, 23);
            this.btnProdDelete.TabIndex = 12;
            this.btnProdDelete.Text = "Löschen";
            this.btnProdDelete.UseVisualStyleBackColor = false;
            this.btnProdDelete.Click += new System.EventHandler(this.btnProdDelete_Click);
            // 
            // productsDGV
            // 
            this.productsDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.productsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDGV.Location = new System.Drawing.Point(13, 203);
            this.productsDGV.Name = "productsDGV";
            this.productsDGV.RowTemplate.Height = 25;
            this.productsDGV.Size = new System.Drawing.Size(774, 254);
            this.productsDGV.TabIndex = 13;
            // 
            // ProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.productsDGV);
            this.Controls.Add(this.btnProdDelete);
            this.Controls.Add(this.btnFieldsClear);
            this.Controls.Add(this.btnProdEdit);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.productsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnProdSave;
        private System.Windows.Forms.Button btnProdEdit;
        private System.Windows.Forms.Button btnFieldsClear;
        private System.Windows.Forms.Button btnProdDelete;
        private System.Windows.Forms.DataGridView productsDGV;
    }
}