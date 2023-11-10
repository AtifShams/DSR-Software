
namespace AkberAli
{
    partial class frmAddProduct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProducts = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBoxCTN = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtTPCTN = new System.Windows.Forms.TextBox();
            this.txtRateCTN = new System.Windows.Forms.TextBox();
            this.txtTPPCS = new System.Windows.Forms.TextBox();
            this.txtRateBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stmDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.stmUpdateTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchaseView = new System.Windows.Forms.ToolStripMenuItem();
            this.stmStock = new System.Windows.Forms.ToolStripMenuItem();
            this.stmAddProdut = new System.Windows.Forms.ToolStripMenuItem();
            this.stmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProducts);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtBoxCTN);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.txtTPCTN);
            this.groupBox1.Controls.Add(this.txtRateCTN);
            this.groupBox1.Controls.Add(this.txtTPPCS);
            this.groupBox1.Controls.Add(this.txtRateBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.textBox20);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1338, 169);
            this.groupBox1.TabIndex = 251;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.DarkRed;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(867, 120);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(162, 35);
            this.btnProducts.TabIndex = 284;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(376, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(308, 31);
            this.txtProductName.TabIndex = 283;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // txtBoxCTN
            // 
            this.txtBoxCTN.BackColor = System.Drawing.Color.White;
            this.txtBoxCTN.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCTN.Location = new System.Drawing.Point(838, 72);
            this.txtBoxCTN.Name = "txtBoxCTN";
            this.txtBoxCTN.Size = new System.Drawing.Size(65, 25);
            this.txtBoxCTN.TabIndex = 280;
            this.txtBoxCTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxCTN.TextChanged += new System.EventHandler(this.txtBoxCTN_TextChanged);
            this.txtBoxCTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCTN_KeyPress);
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.DarkRed;
            this.textBox19.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ForeColor = System.Drawing.Color.White;
            this.textBox19.Location = new System.Drawing.Point(1059, 34);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(71, 27);
            this.textBox19.TabIndex = 279;
            this.textBox19.Text = "TP/PCS";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(1078, 120);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(162, 35);
            this.btnAddProduct.TabIndex = 261;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtTPCTN
            // 
            this.txtTPCTN.BackColor = System.Drawing.Color.PeachPuff;
            this.txtTPCTN.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPCTN.Location = new System.Drawing.Point(1160, 70);
            this.txtTPCTN.Name = "txtTPCTN";
            this.txtTPCTN.ReadOnly = true;
            this.txtTPCTN.Size = new System.Drawing.Size(78, 25);
            this.txtTPCTN.TabIndex = 277;
            this.txtTPCTN.Text = "0";
            this.txtTPCTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateCTN
            // 
            this.txtRateCTN.BackColor = System.Drawing.Color.PeachPuff;
            this.txtRateCTN.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateCTN.Location = new System.Drawing.Point(933, 70);
            this.txtRateCTN.Name = "txtRateCTN";
            this.txtRateCTN.ReadOnly = true;
            this.txtRateCTN.Size = new System.Drawing.Size(96, 25);
            this.txtRateCTN.TabIndex = 276;
            this.txtRateCTN.Text = "0";
            this.txtRateCTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTPPCS
            // 
            this.txtTPPCS.BackColor = System.Drawing.Color.PeachPuff;
            this.txtTPPCS.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPPCS.Location = new System.Drawing.Point(1059, 70);
            this.txtTPPCS.Name = "txtTPPCS";
            this.txtTPPCS.ReadOnly = true;
            this.txtTPPCS.Size = new System.Drawing.Size(71, 25);
            this.txtTPPCS.TabIndex = 275;
            this.txtTPPCS.Text = "0";
            this.txtTPPCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateBox
            // 
            this.txtRateBox.BackColor = System.Drawing.Color.White;
            this.txtRateBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateBox.Location = new System.Drawing.Point(714, 74);
            this.txtRateBox.Name = "txtRateBox";
            this.txtRateBox.Size = new System.Drawing.Size(94, 25);
            this.txtRateBox.TabIndex = 274;
            this.txtRateBox.TextChanged += new System.EventHandler(this.txtRateBox_TextChanged);
            this.txtRateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRateBox_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkRed;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(376, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(308, 27);
            this.textBox1.TabIndex = 272;
            this.textBox1.Text = "Product Name";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "select",
            "powder",
            "soap"});
            this.cmbCategory.Location = new System.Drawing.Point(128, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(229, 30);
            this.cmbCategory.TabIndex = 271;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.DarkRed;
            this.textBox20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.ForeColor = System.Drawing.Color.White;
            this.textBox20.Location = new System.Drawing.Point(1160, 34);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(78, 27);
            this.textBox20.TabIndex = 270;
            this.textBox20.Text = "TP/CTN";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.DarkRed;
            this.textBox16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ForeColor = System.Drawing.Color.White;
            this.textBox16.Location = new System.Drawing.Point(933, 34);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(96, 27);
            this.textBox16.TabIndex = 268;
            this.textBox16.Text = "Rate/CTN";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.DarkRed;
            this.textBox14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(838, 34);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(65, 27);
            this.textBox14.TabIndex = 267;
            this.textBox14.Text = "Box/CTN";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.DarkRed;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(714, 34);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(94, 27);
            this.textBox9.TabIndex = 266;
            this.textBox9.Text = "Rate/Box";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.DarkRed;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(376, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(864, 27);
            this.textBox7.TabIndex = 264;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvProducts);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(12, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1338, 445);
            this.groupBox2.TabIndex = 252;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // gvProducts
            // 
            this.gvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProducts.BackgroundColor = System.Drawing.Color.DarkRed;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Location = new System.Drawing.Point(17, 30);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.Size = new System.Drawing.Size(1306, 398);
            this.gvProducts.TabIndex = 262;
            this.gvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProducts_CellContentClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1148, 674);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 35);
            this.btnDelete.TabIndex = 285;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmDashboard,
            this.stmUpdateTarget,
            this.stmPurchaseView,
            this.stmStock,
            this.stmAddProdut,
            this.stmReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 36);
            this.menuStrip1.TabIndex = 286;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stmDashboard
            // 
            this.stmDashboard.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmDashboard.ForeColor = System.Drawing.Color.DarkRed;
            this.stmDashboard.Name = "stmDashboard";
            this.stmDashboard.Size = new System.Drawing.Size(123, 32);
            this.stmDashboard.Text = "Dashboard";
            this.stmDashboard.Click += new System.EventHandler(this.stmDashboard_Click);
            // 
            // stmUpdateTarget
            // 
            this.stmUpdateTarget.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmUpdateTarget.ForeColor = System.Drawing.Color.DarkRed;
            this.stmUpdateTarget.Name = "stmUpdateTarget";
            this.stmUpdateTarget.Size = new System.Drawing.Size(154, 32);
            this.stmUpdateTarget.Text = "Update Target";
            this.stmUpdateTarget.Click += new System.EventHandler(this.stmUpdateTarget_Click);
            // 
            // stmPurchaseView
            // 
            this.stmPurchaseView.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmPurchaseView.ForeColor = System.Drawing.Color.DarkRed;
            this.stmPurchaseView.Name = "stmPurchaseView";
            this.stmPurchaseView.Size = new System.Drawing.Size(155, 32);
            this.stmPurchaseView.Text = "Purchase View";
            this.stmPurchaseView.Click += new System.EventHandler(this.stmPurchaseView_Click);
            // 
            // stmStock
            // 
            this.stmStock.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmStock.ForeColor = System.Drawing.Color.DarkRed;
            this.stmStock.Name = "stmStock";
            this.stmStock.Size = new System.Drawing.Size(74, 32);
            this.stmStock.Text = "Stock";
            this.stmStock.Click += new System.EventHandler(this.stmStock_Click);
            // 
            // stmAddProdut
            // 
            this.stmAddProdut.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmAddProdut.ForeColor = System.Drawing.Color.DarkRed;
            this.stmAddProdut.Name = "stmAddProdut";
            this.stmAddProdut.Size = new System.Drawing.Size(135, 32);
            this.stmAddProdut.Text = "Add Product";
            // 
            // stmReport
            // 
            this.stmReport.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmReport.ForeColor = System.Drawing.Color.DarkRed;
            this.stmReport.Name = "stmReport";
            this.stmReport.Size = new System.Drawing.Size(83, 32);
            this.stmReport.Text = "Report";
            this.stmReport.Click += new System.EventHandler(this.stmReport_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddProduct";
            this.Text = "Add Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtBoxCTN;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtTPCTN;
        private System.Windows.Forms.TextBox txtRateCTN;
        private System.Windows.Forms.TextBox txtTPPCS;
        private System.Windows.Forms.TextBox txtRateBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stmDashboard;
        private System.Windows.Forms.ToolStripMenuItem stmUpdateTarget;
        private System.Windows.Forms.ToolStripMenuItem stmPurchaseView;
        private System.Windows.Forms.ToolStripMenuItem stmStock;
        private System.Windows.Forms.ToolStripMenuItem stmAddProdut;
        private System.Windows.Forms.ToolStripMenuItem stmReport;
    }
}