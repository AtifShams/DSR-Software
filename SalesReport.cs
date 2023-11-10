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
    public partial class frmSalesReport : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmSalesReport()
        {
            InitializeComponent();
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbBooker,
                                    SearchFilter.tblBooker,
                                    SearchFilter.BookerName,
                                    SearchFilter.BookerID,
                                    String.Empty);

            SalesView();
        }

        private void cmbBooker_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from Booker where Booker_ID = " + cmbBooker.SelectedValue;
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtBookerID.Text = dr["Booker_ID"].ToString();
            }
            con.Close();
            if (cmbBooker.Text == "Please Select")
            {
                txtBookerID.Text = "";
            }
        }
        public void SalesView()
        {
            String query = "SELECT b.Name as Booker, " +
                            " SUM(Qty_PCS) as Qty_PCS, SUM(Cartons) as Cartons,  " +
                            " SUM(Total_Amount) as TotalAmount " +
                            " FROM sales sa " +
                            " JOIN Booker b ON b.Booker_ID = sa.Booker_ID " +
                            " WHERE Date = '" + TodayDate.GUID() + "'" +
                            " GROUP BY b.Name";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvResult.DataSource = dt;
        }

        private void btnIndvidualSales_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookerID.Text != "" && dtpFrom.Value <= dtpTo.Value)
                {
                    String Query = "select b.Name as Booker, a.Area_Name as Area, s.Name as Shop, c.Category_Name as Category, " +
                                " p.Product_Name as Product, Qty_PCS, Cartons, Discount, Total_Amount, Date " +
                                " from sales sa " +
                                " join Booker b on b.Booker_ID = sa.Booker_ID " +
                                " join Area a on a.Area_ID = sa.Area_ID " +
                                " join Shops s on s.Shop_ID = sa.Shop_ID " +
                                " join Category c on c.Category_ID = sa.Category_ID " +
                                " join Products p on p.Product_ID = sa.Product_ID " +
                                " where b.Booker_ID = " + txtBookerID.Text + " and date between '" + dtpFrom.Text + "'" + " and '" + dtpTo.Text + "'";

                    SqlDataAdapter dap = new SqlDataAdapter(Query, con);
                    DataTable dta = new DataTable();
                    dap.Fill(dta);

                    gvResult.DataSource = dta;
                }
                else if (txtBookerID.Text != "" && dtpFrom.Value > dtpTo.Value)
                {
                    MessageBox.Show("Start Date should not be greater. Please select right date rang.");
                }
                else if (txtBookerID.Text == "")
                {
                    MessageBox.Show("Please select Booker.");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpFrom.Value <= dtpTo.Value)
                {
                    String query = " SELECT b.Name as Booker, " +
                                   " SUM(sa.Qty_PCS) as Qty_PCS, SUM(sa.Cartons) as Ach_CTN, " +
                                   " SUM(sa.Total_Amount) as Ach_Amt, t.Total_Cartons as Trg_CTN, " +
                                   " t.Total_Amount as Trg_Amt, SUM(sa.Cartons)-t.Total_Cartons as Bal_CTN," +
                                   " SUM(sa.Total_Amount)- t.Total_Amount as Bal_Amt  " +
                                   " FROM sales sa " +
                                   " JOIN Booker b ON b.Booker_ID = sa.Booker_ID " +
                                   " join TotalTarget t on t.Booker_ID = sa.Booker_ID " +
                                   " WHERE Date between '" + dtpFrom.Text + "' and '" + dtpTo.Text + "'" +
                                   " GROUP BY b.Name, t.Total_Cartons, t.Total_Amount";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvResult.DataSource = dt;
                }
                else if (dtpFrom.Value > dtpTo.Value)
                {
                    MessageBox.Show("End date should be greater than start date.");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void stmSales_Click(object sender, EventArgs e)
        {
            frmSales s = new frmSales();
            s.Show();
            this.Close();
        }

        private void stmPurchases_Click(object sender, EventArgs e)
        {
            frmPurchase p = new frmPurchase();
            p.Show();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRDLCReport rr = new frmRDLCReport();
            rr.Show();
            this.Close();
        }

        private void stmPurchasesReturn_Click_1(object sender, EventArgs e)
        {
            PurchaseReturn pr = new PurchaseReturn();
            pr.Show();
            this.Close();
        }

        private void stmSalesReturn_Click_1(object sender, EventArgs e)
        {
            frmSaleReturn sr = new frmSaleReturn();
            sr.Show();
            this.Close();
        }
    }
}
