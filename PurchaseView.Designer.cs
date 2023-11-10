
namespace AkberAli
{
    partial class frmPurchaseView
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
            this.btnOverall = new System.Windows.Forms.Button();
            this.txtProcductCode1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSpecificProduct = new System.Windows.Forms.Button();
            this.cmbProductName1 = new System.Windows.Forms.ComboBox();
            this.cmbCategory1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvPurchases = new System.Windows.Forms.DataGridView();
            this.txtTotalCartons = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stmSales = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchaseView = new System.Windows.Forms.ToolStripMenuItem();
            this.stmStock = new System.Windows.Forms.ToolStripMenuItem();
            this.stmAddProdut = new System.Windows.Forms.ToolStripMenuItem();
            this.stmReport = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchases)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOverall);
            this.groupBox1.Controls.Add(this.txtProcductCode1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.btnSpecificProduct);
            this.groupBox1.Controls.Add(this.cmbProductName1);
            this.groupBox1.Controls.Add(this.cmbCategory1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1338, 161);
            this.groupBox1.TabIndex = 251;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // btnOverall
            // 
            this.btnOverall.BackColor = System.Drawing.Color.DarkRed;
            this.btnOverall.FlatAppearance.BorderSize = 0;
            this.btnOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverall.ForeColor = System.Drawing.Color.White;
            this.btnOverall.Location = new System.Drawing.Point(958, 111);
            this.btnOverall.Name = "btnOverall";
            this.btnOverall.Size = new System.Drawing.Size(162, 35);
            this.btnOverall.TabIndex = 289;
            this.btnOverall.Text = "Overall";
            this.btnOverall.UseVisualStyleBackColor = false;
            this.btnOverall.Click += new System.EventHandler(this.btnOverall_Click);
            // 
            // txtProcductCode1
            // 
            this.txtProcductCode1.BackColor = System.Drawing.Color.PeachPuff;
            this.txtProcductCode1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcductCode1.Location = new System.Drawing.Point(716, 54);
            this.txtProcductCode1.Name = "txtProcductCode1";
            this.txtProcductCode1.ReadOnly = true;
            this.txtProcductCode1.Size = new System.Drawing.Size(62, 31);
            this.txtProcductCode1.TabIndex = 288;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 55);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1114, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 285;
            this.label3.Text = "End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(825, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 284;
            this.label2.Text = "Start";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(1172, 56);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(155, 26);
            this.dtpTo.TabIndex = 283;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(897, 56);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(155, 26);
            this.dtpFrom.TabIndex = 282;
            // 
            // btnSpecificProduct
            // 
            this.btnSpecificProduct.BackColor = System.Drawing.Color.DarkRed;
            this.btnSpecificProduct.FlatAppearance.BorderSize = 0;
            this.btnSpecificProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecificProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecificProduct.ForeColor = System.Drawing.Color.White;
            this.btnSpecificProduct.Location = new System.Drawing.Point(1152, 111);
            this.btnSpecificProduct.Name = "btnSpecificProduct";
            this.btnSpecificProduct.Size = new System.Drawing.Size(162, 35);
            this.btnSpecificProduct.TabIndex = 261;
            this.btnSpecificProduct.Text = "Specific Product";
            this.btnSpecificProduct.UseVisualStyleBackColor = false;
            this.btnSpecificProduct.Click += new System.EventHandler(this.btnPurchaseView_Click);
            // 
            // cmbProductName1
            // 
            this.cmbProductName1.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName1.FormattingEnabled = true;
            this.cmbProductName1.Location = new System.Drawing.Point(462, 54);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvPurchases);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(12, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1338, 440);
            this.groupBox2.TabIndex = 282;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchases";
            // 
            // gvPurchases
            // 
            this.gvPurchases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPurchases.BackgroundColor = System.Drawing.Color.DarkRed;
            this.gvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPurchases.Location = new System.Drawing.Point(10, 30);
            this.gvPurchases.Name = "gvPurchases";
            this.gvPurchases.Size = new System.Drawing.Size(1304, 393);
            this.gvPurchases.TabIndex = 262;
            // 
            // txtTotalCartons
            // 
            this.txtTotalCartons.BackColor = System.Drawing.Color.PeachPuff;
            this.txtTotalCartons.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCartons.Location = new System.Drawing.Point(774, 671);
            this.txtTotalCartons.Name = "txtTotalCartons";
            this.txtTotalCartons.ReadOnly = true;
            this.txtTotalCartons.Size = new System.Drawing.Size(151, 31);
            this.txtTotalCartons.TabIndex = 264;
            this.txtTotalCartons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkRed;
            this.label17.Location = new System.Drawing.Point(614, 672);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 28);
            this.label17.TabIndex = 263;
            this.label17.Text = "Total Cartons";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.PeachPuff;
            this.txtTotalAmount.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(1156, 672);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(157, 31);
            this.txtTotalAmount.TabIndex = 284;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(1000, 673);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 28);
            this.label16.TabIndex = 283;
            this.label16.Text = "Total Amount";
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
            this.menuStrip1.TabIndex = 285;
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
            // frmPurchaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTotalCartons);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPurchaseView";
            this.Text = "PurchaseView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchases)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSpecificProduct;
        private System.Windows.Forms.ComboBox cmbProductName1;
        private System.Windows.Forms.ComboBox cmbCategory1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txtProcductCode1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvPurchases;
        private System.Windows.Forms.TextBox txtTotalCartons;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnOverall;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stmSales;
        private System.Windows.Forms.ToolStripMenuItem stmPurchase;
        private System.Windows.Forms.ToolStripMenuItem stmPurchaseView;
        private System.Windows.Forms.ToolStripMenuItem stmStock;
        private System.Windows.Forms.ToolStripMenuItem stmAddProdut;
        private System.Windows.Forms.ToolStripMenuItem stmReport;
    }
}