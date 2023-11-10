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
    public partial class frmPurchaseView : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmPurchaseView()
        {
            InitializeComponent();
        }

        private void frmPurchaseView_Load(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbCategory1,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);
        }

        private void cmbCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName1,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory1.SelectedValue.ToString());
        }

        private void cmbProductName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName1.Text + " '" + " and Category_ID = " + cmbCategory1.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtProcductCode1.Text = dr["Product_ID"].ToString();
                }
                con.Close();

                if (cmbProductName1.Text == "Please Select")
                {
                    txtProcductCode1.Text = "";

                }

            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void btnPurchaseView_Click(object sender, EventArgs e)
        {
            if (cmbCategory1.Text == "Please Select")
            {
                MessageBox.Show("Please select Category.");
                cmbCategory1.Focus();
            }
            else if (cmbCategory1.Text != "Please Select" && cmbCategory1.Text == "Please Select")
            {
                MessageBox.Show("Please select Category.");
                cmbProductName1.Focus();
            }
            else if (cmbCategory1.Text != "Please Select" && cmbProductName1.Text != "Please Select")
            {
                if (dtpFrom.Value <= dtpTo.Value)
                {
                    String Query = "select c.Category_Name as Category, p.Product_Name as Product, " +
                                                        " pu.Qty_Pcs, pu.Cartons, pu.Discount, pu.Total_Amount, pu.date" +
                                                        " from Purchases pu " +
                                                        " join Category c on c.Category_ID = pu.Category_ID" +
                                                        " join Products p on p.Product_ID = pu.Product_ID" +
                                                        " where p.Product_ID = " + txtProcductCode1.Text + " and  pu.date between '" + dtpFrom.Text + "' and '" + dtpTo.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(Query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvPurchases.DataSource = dt;

                    String getQuery = "select sum(cartons) as Cartons, sum(total_Amount) as Total_Amount " +
                                    "from Purchases " +
                                    "where Product_ID = " + txtProcductCode1.Text + " and  date between '" + dtpFrom.Text + "' and '" + dtpTo.Text + "'";


                    SqlCommand cmd = new SqlCommand(getQuery, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtTotalCartons.Text = dr["Cartons"].ToString();
                        txtTotalAmount.Text = dr["Total_Amount"].ToString();
                    }
                    con.Close();

                }
                else if (dtpFrom.Value > dtpTo.Value)
                {
                    MessageBox.Show("End date should be greater than start date.");
                }
            }

        }

        private void btnOverall_Click(object sender, EventArgs e)
        {

            if (dtpFrom.Value <= dtpTo.Value)
            {
                String Query = "select c.Category_Name as Category, p.Product_Name as Product, " +
                                                        " pu.Qty_Pcs, pu.Cartons, pu.Discount, pu.Total_Amount, pu.date" +
                                                        " from Purchases pu " +
                                                        " join Category c on c.Category_ID = pu.Category_ID" +
                                                        " join Products p on p.Product_ID = pu.Product_ID" +
                                                        " where pu.date between '" + dtpFrom.Text + "' and '" + dtpTo.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvPurchases.DataSource = dt;

                String getQuery = "select sum(cartons) as Cartons, sum(total_Amount) as Total_Amount " +
                                    "from Purchases " +
                                    "where date between '" + dtpFrom.Text + "' and '" + dtpTo.Text + "'";

                SqlCommand cmd = new SqlCommand(getQuery, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTotalCartons.Text = dr["Cartons"].ToString();
                    txtTotalAmount.Text = dr["Total_Amount"].ToString();
                }
                con.Close();
            }
            else if (dtpFrom.Value > dtpTo.Value)
            {
                MessageBox.Show("End should be greater than start date.");
            }
        }

        private void stmSales_Click(object sender, EventArgs e)
        {
            frmDashboard d = new frmDashboard();
            d.Show();
            this.Close();
        }

        private void stmPurchase_Click(object sender, EventArgs e)
        {
            frmUpdateTarget ut = new frmUpdateTarget();
            ut.Show();
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

        private void stmReport_Click(object sender, EventArgs e)
        {
            frmReport r = new frmReport();
            r.Show();
            this.Close();

        }
    }
}
