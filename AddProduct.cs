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
    public partial class frmAddProduct : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbCategory,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);
        }

        private void txtRateBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" && cmbCategory.Text != "Please Select")
                {
                    MessageBox.Show("Please write Product Name.");
                    txtProductName.Focus();
                }
                else if (cmbCategory.Text == "Please Select")
                {
                    MessageBox.Show("Please select category");
                    cmbCategory.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtRateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBoxCTN_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text == "" && cmbCategory.Text != "Please Select")
                {
                    MessageBox.Show("Please write Product Name.");
                    txtProductName.Focus();
                }
                else if (cmbCategory.Text == "Please Select")
                {
                    MessageBox.Show("Please select category");
                    cmbCategory.Focus();
                }
                else if (txtRateBox.Text == "")
                {
                    MessageBox.Show("Please give a value of rate box.");
                    txtRateBox.Focus();
                }
                else if (txtProductName.Text != "" && cmbCategory.Text != "Please Select" && txtRateBox.Text != "" && txtBoxCTN.Text != "")
                {
                    txtRateCTN.Text = (Convert.ToDouble(txtRateBox.Text) * Convert.ToDouble(txtBoxCTN.Text)).ToString();
                    txtTPPCS.Text = (Convert.ToDouble(txtRateBox.Text) * 100 / 88).ToString();
                    txtTPCTN.Text = (Convert.ToDouble(txtRateBox.Text) * 100 * Convert.ToDouble(txtBoxCTN.Text) / 88).ToString();
                }
                else if (txtBoxCTN.Text == "" || txtBoxCTN.Text == "0")
                {
                    txtRateCTN.Text = "";
                    txtTPPCS.Text = "";
                    txtTPCTN.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtBoxCTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTPCTN.Text != "")
                {
                    String insertQuery = "insert into Products (Product_Name, Category_ID, Box_CTN, Rate_Box, Rate_CTN, TP_PCS, TP_CTN) " +
                                        "values('" + txtProductName.Text + "'," + cmbCategory.SelectedValue + "," + txtBoxCTN.Text + "," + txtRateBox.Text + "," +
                                                txtRateCTN.Text + "," + txtTPPCS.Text + "," + txtTPCTN.Text + ")";

                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    String insertQuery2 = "insert into Inventory (Product_ID, Quantity) values((select max(product_id) from Products), 0)";
                    SqlCommand cmd1 = new SqlCommand(insertQuery2, con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    String adapQuery = "select top 1 product_id, c.Category_Name as Category, Product_Name, Box_CTN, Rate_Box, " +
                                        " Rate_CTN, TP_PCS, TP_CTN " +
                                        " from products p " +
                                        " join Category c on c.Category_ID = p.Category_ID " +
                                        " order by Product_ID desc";
                    SqlDataAdapter da = new SqlDataAdapter(adapQuery, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gvProducts.DataSource = dt;
                    MessageBox.Show(txtProductName.Text + " has successfully added.");
                    txtBoxCTN.Text = "";
                    txtRateCTN.Text = "";
                    txtTPPCS.Text = "";
                    txtTPCTN.Text = "";
                    txtRateBox.Text = "";
                    cmbCategory.SelectedValue = 0;
                    txtProductName.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductView();
        }
        public void ProductView()
        {
            String Query = "select Product_ID, c.Category_Name as Category, Product_Name, Box_CTN, Rate_Box, " +
                                " Rate_CTN, TP_PCS, TP_CTN " +
                                " from products p " +
                                " join Category c on c.Category_ID = p.Category_ID";

            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvProducts.DataSource = dt;
        }

        String ID;
        private void gvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = gvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(ID != "")
                {
                    String DeleteQuery = "Delete from Products where Product_ID = " + ID;
                    SqlCommand cmd = new SqlCommand(DeleteQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ID = "";
                    ProductView();
                    MessageBox.Show("Product has successfully deleted.");
                }
                else if(ID == "")
                {
                    MessageBox.Show("Please select product ID");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
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

        private void stmReport_Click(object sender, EventArgs e)
        {
            frmReport r = new frmReport();
            r.Show();
            this.Close();
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            if(txtProductName.Text != "")
            {
                txtProductName.Text   = string.Join(" ", txtProductName.Text.Split(' ').ToList().ConvertAll(word => word.Substring(0, 1).ToUpper() + word.Substring(1)));

            }
        }
    }
}
