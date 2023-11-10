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
    public partial class frmUpdateTarget : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmUpdateTarget()
        {
            InitializeComponent();
        }

        private void frmUpdateTarget_Load(object sender, EventArgs e)
        {
           
            DataAdaptionCategory.BindCombo(cmbBooker,
                                    SearchFilter.tblBooker,
                                    SearchFilter.BookerName,
                                    SearchFilter.BookerID,
                                    String.Empty); 

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

                    txtProductCode1.Text = dr["Product_ID"].ToString();
                    txtPcsInCN1.Text = dr["Box_CTN"].ToString();
                    txtCostPrice1.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName1.Text == "Please Select")
                {
                    txtProductCode1.Text = "";
                    txtPieces1.Text = "";
                    txtPcsInCN1.Text = "";
                    txtCartons1.Text = "";
                    txtCostPrice1.Text = "";
                    txtTotalPrice1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory1.Text == "Please Select" && txtCartons1.Text != "" && txtCartons1.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory1.Focus();
                    txtCartons1.Text = "";
                }
                if (cmbProductName1.Text == "Please Select" && cmbCategory1.Text != "Please Select" && txtCartons1.Text != "" && txtCartons1.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName1.Focus();
                    txtCartons1.Text = "";
                }
                if (txtCartons1.Text != "" && txtCartons1.Text != "0")
                {
                    txtPieces1.Text = (Convert.ToInt32(txtPcsInCN1.Text) * Convert.ToInt32(txtCartons1.Text)).ToString();
                    txtTotalPrice1.Text = (Convert.ToInt32(txtPieces1.Text) * Convert.ToInt32(txtCostPrice1.Text)).ToString();
                }
                if (txtCartons1.Text == "" || txtCartons1.Text == "0")
                {
                    txtPieces1.Text = "";
                    txtTotalPrice1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdateTarget_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBooker.Text == "Please Select")
                {
                    MessageBox.Show("Please select Booker.");
                    cmbBooker.Focus();
                }
                else if (txtTotalPrice1.Text == "")
                {
                    MessageBox.Show("Please Category and Product.");
                    cmbCategory1.Focus();
                }
                else if (txtTotalPrice1.Text != "" && cmbBooker.Text != "Please Select")
                {
                    String InsertQuery = "Insert into Target (Booker_ID, Category_ID, Product_ID, Cartons, Total_Amount) values(" + cmbBooker.SelectedValue + "," +
                                                                                                                                 cmbCategory1.SelectedValue + "," +
                                                                                                                                 txtProductCode1.Text + "," +
                                                                                                                                 txtCartons1.Text + "," +
                                                                                                                                 txtTotalPrice1.Text + ")";

                    SqlCommand cmd = new SqlCommand(InsertQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    String updateQuery = "update TotalTarget set " +
                                         " Total_Cartons = (select sum(cartons) from Target where Booker_ID = " + cmbBooker.SelectedValue + "), " +
                                         " Total_Amount = (select sum(Total_Amount) from Target where Booker_ID = "+cmbBooker.SelectedValue+") " +
                                         " where Booker_ID = "+cmbBooker.SelectedValue;

                    SqlCommand cmd1 = new SqlCommand(updateQuery, con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    TargetView(cmbBooker.SelectedValue.ToString());
                    cmbCategory1.SelectedValue = 0;
                    cmbProductName1.SelectedValue = 0;
                    txtProductCode1.Text = "";
                    txtPieces1.Text = "";
                    txtPcsInCN1.Text = "";
                    txtCartons1.Text = "";
                    txtCostPrice1.Text = "";
                    txtTotalPrice1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
          
        }

        private void cmbBooker_SelectedIndexChanged(object sender, EventArgs e)
        {
   
            if (cmbBooker.Text != "Please Select" )
            {
                TargetView(Convert.ToString(cmbBooker.SelectedValue));

            }
        }
        public void TargetView(String Booker)
        {
            String TargetView = "select b.Name as Booker_Name, c.Category_Name as Category, p.Product_Name, sum(Cartons) as Cartons, sum(Total_Amount) as Total_Amount" +
                                    " from target t " +
                                    " join Products p on p.Product_ID = t.Product_ID " +
                                    " join Booker b on b.Booker_ID = t.Booker_ID " +
                                    " join Category c on c.Category_ID = t.Category_ID " +
                                    " where t.Booker_ID = " + Booker +
                                    " group by p.Product_Name, b.Name, c.Category_Name";

            SqlDataAdapter da = new SqlDataAdapter(TargetView, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTarget.DataSource = dt;
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBooker.Text == "Please Select")
                {
                    MessageBox.Show("Please select Booker.");
                    cmbBooker.Focus();
                }
                else if (cmbBooker.Text != "Please Select")
                {
                    String resetQuery = "Delete from Target " +
                                       "where Booker_ID = " + cmbBooker.SelectedValue;

                    String resetQuery2 = "update totaltarget set Total_Cartons= 0, Total_Amount = 0 " +
                                       "where Booker_ID = " + cmbBooker.SelectedValue;
                    SqlCommand cmd = new SqlCommand(resetQuery + resetQuery2, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Target has successfully remove from " + cmbBooker.Text);
                    TargetView(cmbBooker.SelectedValue.ToString());
                    cmbCategory1.SelectedValue = 0;
                    cmbProductName1.SelectedValue = 0;
                    txtProductCode1.Text = "";
                    txtPieces1.Text = "";
                    txtPcsInCN1.Text = "";
                    txtCartons1.Text = "";
                    txtCostPrice1.Text = "";
                    txtTotalPrice1.Text = "";
                }
                else
                {
                    MessageBox.Show("Please check it. There is something missing.");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void btnTargetView_Click(object sender, EventArgs e)
        {
            String Query = "select b.Name as Booker_Name, c.Category_Name as Category, p.Product_Name, sum(Cartons) as Cartons, sum(Total_Amount) as Total_Amount" +
                                    " from target t " +
                                    " join Products p on p.Product_ID = t.Product_ID " +
                                    " join Booker b on b.Booker_ID = t.Booker_ID " +
                                    " join Category c on c.Category_ID = t.Category_ID " +
                                    " group by p.Product_Name, b.Name, c.Category_Name";

            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvTarget.DataSource = dt;
        }

        private void stmDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard d = new frmDashboard();
            d.Show();
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

        private void stmReport_Click(object sender, EventArgs e)
        {
            frmReport r = new frmReport();
            r.Show();
            this.Close();
        }
    }
}
