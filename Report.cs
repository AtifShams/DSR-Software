using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkberAli
{
    public partial class frmReport : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmReport()
        {
            InitializeComponent();
        }
        
        private void frmReport_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            String YesterdayDate = d.Date.AddDays(-1).ToString().Remove(9);
            String Query = "select Opening_Inventory, Sales, Sales_Return, Purchases, Purchases_Return, Closing_Inventory, Date " +
                            "from report where date = '" + YesterdayDate + "'";
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvReport.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(dtpFrom.Value <= dtpTo.Value)
            {
                String Query = "select Opening_Inventory, Sales, Sales_Return, Purchases, Purchases_Return, Closing_Inventory, Date " +
                            "from report where date between '" + dtpFrom.Text + "' and '"+dtpTo.Text +"' and date != '"+TodayDate.GUID()+"'";
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvReport.DataSource = dt;
            }
            if(dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("End date should be greater than start date.");
            }
        }

        private void stmDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard d = new frmDashboard();
            d.Show();
            this.Close();
        }

        private void stmUpdateTarget_Click(object sender, EventArgs e)
        {
            frmUpdateTarget ut = new frmUpdateTarget();
            ut.Show();
            this.Close();
        }

        private void stmPurchaseView_Click(object sender, EventArgs e)
        {
            frmPurchaseView pv = new frmPurchaseView();
            pv.Show();
            this.Close();
        }

        private void stmStock_Click(object sender, EventArgs e)
        {
            frmStock s = new frmStock();
            s.Show();
            this.Close();
        }

        private void stmAddProdut_Click(object sender, EventArgs e)
        {
            frmAddProduct ap = new frmAddProduct();
            ap.Show();
            this.Close();
        }
    }
}
