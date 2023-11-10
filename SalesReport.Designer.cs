
namespace AkberAli
{
    partial class frmSalesReport
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
            this.btnSales = new System.Windows.Forms.Button();
            this.btnIndvidualSales = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtBookerID = new System.Windows.Forms.TextBox();
            this.cmbBooker = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stmSales = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.stmPurchasesReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.stmSalesReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.stmSalesReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.DarkRed;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(720, 66);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(162, 35);
            this.btnSales.TabIndex = 262;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnIndvidualSales
            // 
            this.btnIndvidualSales.BackColor = System.Drawing.Color.DarkRed;
            this.btnIndvidualSales.FlatAppearance.BorderSize = 0;
            this.btnIndvidualSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndvidualSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndvidualSales.ForeColor = System.Drawing.Color.White;
            this.btnIndvidualSales.Location = new System.Drawing.Point(914, 66);
            this.btnIndvidualSales.Name = "btnIndvidualSales";
            this.btnIndvidualSales.Size = new System.Drawing.Size(162, 35);
            this.btnIndvidualSales.TabIndex = 261;
            this.btnIndvidualSales.Text = "Indvidual Sales";
            this.btnIndvidualSales.UseVisualStyleBackColor = false;
            this.btnIndvidualSales.Click += new System.EventHandler(this.btnIndvidualSales_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(944, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Start";
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(1002, 27);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(155, 26);
            this.dtpTo.TabIndex = 11;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(615, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(155, 26);
            this.dtpFrom.TabIndex = 10;
            // 
            // txtBookerID
            // 
            this.txtBookerID.BackColor = System.Drawing.Color.PeachPuff;
            this.txtBookerID.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookerID.Location = new System.Drawing.Point(348, 24);
            this.txtBookerID.Name = "txtBookerID";
            this.txtBookerID.ReadOnly = true;
            this.txtBookerID.Size = new System.Drawing.Size(62, 31);
            this.txtBookerID.TabIndex = 9;
            // 
            // cmbBooker
            // 
            this.cmbBooker.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBooker.FormattingEnabled = true;
            this.cmbBooker.Location = new System.Drawing.Point(98, 21);
            this.cmbBooker.Name = "cmbBooker";
            this.cmbBooker.Size = new System.Drawing.Size(244, 36);
            this.cmbBooker.TabIndex = 7;
            this.cmbBooker.SelectedIndexChanged += new System.EventHandler(this.cmbBooker_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gvResult);
            this.groupBox2.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1338, 545);
            this.groupBox2.TabIndex = 250;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales";
            // 
            // gvResult
            // 
            this.gvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvResult.BackgroundColor = System.Drawing.Color.DarkRed;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Location = new System.Drawing.Point(23, 30);
            this.gvResult.Name = "gvResult";
            this.gvResult.Size = new System.Drawing.Size(1295, 494);
            this.gvResult.TabIndex = 262;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Booker";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSales);
            this.groupBox1.Controls.Add(this.btnIndvidualSales);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.txtBookerID);
            this.groupBox1.Controls.Add(this.cmbBooker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1338, 108);
            this.groupBox1.TabIndex = 249;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stmSales,
            this.stmPurchases,
            this.stmPurchasesReturn,
            this.stmSalesReturn,
            this.stmSalesReport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 36);
            this.menuStrip1.TabIndex = 251;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stmSales
            // 
            this.stmSales.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmSales.ForeColor = System.Drawing.Color.DarkRed;
            this.stmSales.Name = "stmSales";
            this.stmSales.Size = new System.Drawing.Size(73, 32);
            this.stmSales.Text = "Sales";
            this.stmSales.Click += new System.EventHandler(this.stmSales_Click);
            // 
            // stmPurchases
            // 
            this.stmPurchases.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmPurchases.ForeColor = System.Drawing.Color.DarkRed;
            this.stmPurchases.Name = "stmPurchases";
            this.stmPurchases.Size = new System.Drawing.Size(118, 32);
            this.stmPurchases.Text = "Purchases";
            this.stmPurchases.Click += new System.EventHandler(this.stmPurchases_Click);
            // 
            // stmPurchasesReturn
            // 
            this.stmPurchasesReturn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmPurchasesReturn.ForeColor = System.Drawing.Color.DarkRed;
            this.stmPurchasesReturn.Name = "stmPurchasesReturn";
            this.stmPurchasesReturn.Size = new System.Drawing.Size(181, 32);
            this.stmPurchasesReturn.Text = "Purchases Return";
            this.stmPurchasesReturn.Click += new System.EventHandler(this.stmPurchasesReturn_Click_1);
            // 
            // stmSalesReturn
            // 
            this.stmSalesReturn.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmSalesReturn.ForeColor = System.Drawing.Color.DarkRed;
            this.stmSalesReturn.Name = "stmSalesReturn";
            this.stmSalesReturn.Size = new System.Drawing.Size(136, 32);
            this.stmSalesReturn.Text = "Sales Return";
            this.stmSalesReturn.Click += new System.EventHandler(this.stmSalesReturn_Click_1);
            // 
            // stmSalesReport
            // 
            this.stmSalesReport.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stmSalesReport.ForeColor = System.Drawing.Color.DarkRed;
            this.stmSalesReport.Name = "stmSalesReport";
            this.stmSalesReport.Size = new System.Drawing.Size(137, 32);
            this.stmSalesReport.Text = "Sales Report";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DarkRed;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1108, 66);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(162, 35);
            this.btnPrint.TabIndex = 264;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSalesReport";
            this.Text = "Sales Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesReport_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnIndvidualSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txtBookerID;
        private System.Windows.Forms.ComboBox cmbBooker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stmSales;
        private System.Windows.Forms.ToolStripMenuItem stmPurchases;
        private System.Windows.Forms.ToolStripMenuItem stmPurchasesReturn;
        private System.Windows.Forms.ToolStripMenuItem stmSalesReturn;
        private System.Windows.Forms.ToolStripMenuItem stmSalesReport;
        private System.Windows.Forms.Button btnPrint;
    }
}