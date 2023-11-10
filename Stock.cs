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
    public partial class frmStock : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
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
                    txtRateBox.Text = dr["Rate_Box"].ToString();
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

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProcductCode1.Text != "" && txtChangeRateBox.Text != "")
                {
                    String UpdateQuery = "update Products set  Rate_Box = "+txtChangeRateBox.Text+", Rate_CTN = "+txtChangeRateBox.Text+"*Box_CTN, "+
                                           " TP_PCS = ("+txtChangeRateBox.Text+"* 100) / 90, TP_CTN = ("+txtChangeRateBox.Text+"* 100 * Box_CTN) / 90"+
                                           " where Product_Id = "+txtProcductCode1.Text;
                    SqlCommand cmd = new SqlCommand(UpdateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Box Rate of " + cmbProductName1.Text + "has successfully updated");
                    
                    String DataAdap = "select c.Category_Name, p.Product_Name, i.Quantity as Pieces, " +
                            " cast(CAST(i.Quantity as decimal(10, 2)) / cast(p.Box_CTN as decimal(10, 2)) as decimal(10, 2)) as Cartons, p.Box_CTN, p.RAte_Box, " +
                            " p.Rate_CTN, p.TP_PCS, p.TP_CTN " +
                            " from Inventory i " +
                            " join Products p on p.Product_ID = i.Product_ID " +
                            " join Category c on p.Category_ID = c.Category_ID "+
                            "Where i.Product_ID = "+txtProcductCode1.Text;
                    SqlDataAdapter da = new SqlDataAdapter(DataAdap, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvStock.DataSource = dt;
                    cmbCategory1.SelectedValue = 0;
                    cmbProductName1.SelectedValue = 0;
                    txtProcductCode1.Text = "";
                    txtRateBox.Text = "";
                    txtChangeRateBox.Text = "0";
                }
                else if (txtProcductCode1.Text == "")
                {
                    MessageBox.Show("Please select Product.");
                }
                else if (txtChangeRateBox.Text == "")
                {
                    MessageBox.Show("Please enter some value in Change Rate Box");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtChangeRateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            String Query = "select c.Category_Name, p.Product_Name, i.Quantity as Pieces, " +
                            " cast(CAST(i.Quantity as decimal(10, 2)) / cast(p.Box_CTN as decimal(10, 2)) as decimal(10, 2)) as Cartons, p.Box_CTN, p.RAte_Box, " +
                            " p.Rate_CTN, p.TP_PCS, p.TP_CTN " +
                            " from Inventory i " +
                            " join Products p on p.Product_ID = i.Product_ID " +
                            " join Category c on p.Category_ID = c.Category_ID";

            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvStock.DataSource = dt;
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

        private void stmPurchaseView_Click(object sender, EventArgs e)
        {
            frmPurchaseView pv = new frmPurchaseView();
            pv.Show();
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
