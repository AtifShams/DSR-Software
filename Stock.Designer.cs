
namespace AkberAli
{
    partial class frmStock
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
            this.btnStock = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChangeRateBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRateBox = new System.Windows.Forms.TextBox();
            this.txtProcductCode1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.cmbProductName1 = new System.Windows.Forms.ComboBox();
            this.cmbCategory1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvStock = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stmSales = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchaseView = new System.Windows.Forms.ToolStripMenuItem();
            this.stmStock = new System.Windows.Forms.ToolStripMenuItem();
            this.stmAddProdut = new System.Windows.Forms.ToolStripMenuItem();
            this.stmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtChangeRateBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRateBox);
            this.groupBox1.Controls.Add(this.txtProcductCode1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdateRate);
            this.groupBox1.Controls.Add(this.cmbProductName1);
            this.groupBox1.Controls.Add(this.cmbCategory1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1338, 145);
            this.groupBox1.TabIndex = 252;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distributor Price";
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.DarkRed;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Location = new System.Drawing.Point(921, 101);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(162, 35);
            this.btnStock.TabIndex = 294;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1046, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 28);
            this.label3.TabIndex = 293;
            this.label3.Text = "Change Rate Box";
            // 
            // txtChangeRateBox
            // 
            this.txtChangeRateBox.BackColor = System.Drawing.Color.White;
            this.txtChangeRateBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChangeRateBox.Location = new System.Drawing.Point(1211, 57);
            this.txtChangeRateBox.Name = "txtChangeRateBox";
            this.txtChangeRateBox.Size = new System.Drawing.Size(78, 31);
            this.txtChangeRateBox.TabIndex = 292;
            this.txtChangeRateBox.Text = "0";
            this.txtChangeRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChangeRateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChangeRateBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(815, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 291;
            this.label2.Text = "Rate Box";
            // 
            // txtRateBox
            // 
            this.txtRateBox.BackColor = System.Drawing.Color.PeachPuff;
            this.txtRateBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRateBox.Location = new System.Drawing.Point(903, 56);
            this.txtRateBox.Name = "txtRateBox";
            this.txtRateBox.ReadOnly = true;
            this.txtRateBox.Size = new System.Drawing.Size(78, 31);
            this.txtRateBox.TabIndex = 290;
            this.txtRateBox.Text = "0";
            this.txtRateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtProcductCode1
            // 
            this.txtProcductCode1.BackColor = System.Drawing.Color.PeachPuff;
            this.txtProcductCode1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcductCode1.Location = new System.Drawing.Point(694, 55);
            this.txtProcductCode1.Name = "txtProcductCode1";
            this.txtProcductCode1.ReadOnly = true;
            this.txtProcductCode1.Size = new System.Drawing.Size(62, 31);
            this.txtProcductCode1.TabIndex = 288;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 287;
            this.label4.Text = "Product";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 286;
            this.label1.Text = "Category";
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdateRate.FlatAppearance.BorderSize = 0;
            this.btnUpdateRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRate.Location = new System.Drawing.Point(1127, 101);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(162, 35);
            this.btnUpdateRate.TabIndex = 261;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = false;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // cmbProductName1
            // 
            this.cmbProductName1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName1.FormattingEnabled = true;
            this.cmbProductName1.Location = new System.Drawing.Point(440, 55);
            this.cmbProductName1.Name = "cmbProductName1";
            this.cmbProductName1.Size = new System.Drawing.Size(248, 30);
            this.cmbProductName1.TabIndex = 273;
            this.cmbProductName1.SelectedIndexChanged += new System.EventHandler(this.cmbProductName1_SelectedIndexChanged);
            // 
            // cmbCategory1
            // 
            this.cmbCategory1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory1.FormattingEnabled = true;
            this.cmbCategory1.Items.AddRange(new object[] {
            "select",
            "powder",
            "soap"});
            this.cmbCategory1.Location = new System.Drawing.Point(106, 54);
            this.cmbCategory1.Name = "cmbCategory1";
            this.cmbCategory1.Size = new System.Drawing.Size(229, 30);
            this.cmbCategory1.TabIndex = 271;
            this.cmbCategory1.SelectedIndexChanged += new System.EventHandler(this.cmbCategory1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gvStock);
            this.groupBox3.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1338, 539);
            this.groupBox3.TabIndex = 295;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock";
            // 
            // gvStock
            // 
            this.gvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStock.BackgroundColor = System.Drawing.Color.DarkRed;
            this.gvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStock.Location = new System.Drawing.Point(10, 30);
            this.gvStock.Name = "gvStock";
            this.gvStock.Size = new System.Drawing.Size(1304, 503);
            this.gvStock.TabIndex = 262;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmSales,
            this.stmPurchase,
            this.stmPurchaseView,
            this.stmStock,
            this.stmAddProdut,
            this.stmReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 36);
            this.menuStrip1.TabIndex = 296;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stmSales
            // 
            this.stmSales.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmSales.ForeColor = System.Drawing.Color.DarkRed;
            this.stmSales.Name = "stmSales";
            this.stmSales.Size = new System.Drawing.Size(123, 32);
            this.stmSales.Text = "Dashboard";
            this.stmSales.Click += new System.EventHandler(this.stmSales_Click);
            // 
            // stmPurchase
            // 
            this.stmPurchase.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmPurchase.ForeColor = System.Drawing.Color.DarkRed;
            this.stmPurchase.Name = "stmPurchase";
            this.stmPurchase.Size = new System.Drawing.Size(154, 32);
            this.stmPurchase.Text = "Update Target";
            this.stmPurchase.Click += new System.EventHandler(this.stmPurchase_Click);
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
            // 
            // stmAddProdut
            // 
            this.stmAddProdut.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmAddProdut.ForeColor = System.Drawing.Color.DarkRed;
            this.stmAddProdut.Name = "stmAddProdut";
            this.stmAddProdut.Size = new System.Drawing.Size(135, 32);
            this.stmAddProdut.Text = "Add Product";
            this.stmAddProdut.Click += new System.EventHandler(this.stmAddProdut_Click);
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
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStock";
            this.Text = "Stock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProcductCode1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateRate;
        private System.Windows.Forms.ComboBox cmbProductName1;
        private System.Windows.Forms.ComboBox cmbCategory1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChangeRateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRateBox;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvStock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stmSales;
        private System.Windows.Forms.ToolStripMenuItem stmPurchase;
        private System.Windows.Forms.ToolStripMenuItem stmPurchaseView;
        private System.Windows.Forms.ToolStripMenuItem stmStock;
        private System.Windows.Forms.ToolStripMenuItem stmAddProdut;
        private System.Windows.Forms.ToolStripMenuItem stmReport;
    }
}