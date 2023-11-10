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
    public partial class frmPurchase : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmPurchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            txtDis.Text = "0";
            DataAdaptionCategory.BindCombo(cmbCategory1,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory2,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory3,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory4,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory5,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory6,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory7,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory8,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory9,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory10,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory11,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory12,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory13,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory14,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory15,
                                    SearchFilter.tblCategory,
                                    SearchFilter.CategoryName,
                                    SearchFilter.CategoryID,
                                    String.Empty);

            DataAdaptionCategory.BindCombo(cmbCategory16,
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

        private void cmbCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName2,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory2.SelectedValue.ToString());
        }

        private void cmbCategory3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName3,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory3.SelectedValue.ToString());
        }

        private void cmbCategory4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName4,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory4.SelectedValue.ToString());
        }

        private void cmbCategory5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName5,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory5.SelectedValue.ToString());
        }

        private void cmbCategory6_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName6,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory6.SelectedValue.ToString());
        }

        private void cmbCategory7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName7,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory7.SelectedValue.ToString());
        }

        private void cmbCategory8_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName8,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory8.SelectedValue.ToString());
        }

        private void cmbCategory9_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName9,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory9.SelectedValue.ToString());
        }

        private void cmbCategory10_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName10,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory10.SelectedValue.ToString());
        }

        private void cmbCategory11_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName11,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory11.SelectedValue.ToString());
        }

        private void cmbCategory12_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName12,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory12.SelectedValue.ToString());
        }

        private void cmbCategory13_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName13,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory13.SelectedValue.ToString());
        }

        private void cmbCategory14_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName14,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory14.SelectedValue.ToString());
        }

        private void cmbCategory15_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName15,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory15.SelectedValue.ToString());
        }

        private void cmbCategory16_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName16,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory16.SelectedValue.ToString());
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

        private void cmbProductName2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName2.Text + " '" + " and Category_ID = " + cmbCategory2.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode2.Text = dr["Product_ID"].ToString();
                    txtPcsInCN2.Text = dr["Box_CTN"].ToString();
                    txtCostPrice2.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName2.Text == "Please Select")
                {
                    txtProductCode2.Text = "";
                    txtPieces2.Text = "";
                    txtPcsInCN2.Text = "";
                    txtCartons2.Text = "";
                    txtCostPrice2.Text = "";
                    txtTotalPrice2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName3.Text + " '" + " and Category_ID = " + cmbCategory3.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode3.Text = dr["Product_ID"].ToString();
                    txtPcsInCN3.Text = dr["Box_CTN"].ToString();
                    txtCostPrice3.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName3.Text == "Please Select")
                {
                    txtProductCode3.Text = "";
                    txtPieces3.Text = "";
                    txtPcsInCN3.Text = "";
                    txtCartons3.Text = "";
                    txtCostPrice3.Text = "";
                    txtTotalPrice3.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName4.Text + " '" + " and Category_ID = " + cmbCategory4.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode4.Text = dr["Product_ID"].ToString();
                    txtPcsInCN4.Text = dr["Box_CTN"].ToString();
                    txtCostPrice4.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName4.Text == "Please Select")
                {
                    txtProductCode4.Text = "";
                    txtPieces4.Text = "";
                    txtPcsInCN4.Text = "";
                    txtCartons4.Text = "";
                    txtCostPrice4.Text = "";
                    txtTotalPrice4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName5_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName5.Text + " '" + " and Category_ID = " + cmbCategory5.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode5.Text = dr["Product_ID"].ToString();
                    txtPcsInCN5.Text = dr["Box_CTN"].ToString();
                    txtCostPrice5.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName5.Text == "Please Select")
                {
                    txtProductCode5.Text = "";
                    txtPieces5.Text = "";
                    txtPcsInCN5.Text = "";
                    txtCartons5.Text = "";
                    txtCostPrice5.Text = "";
                    txtTotalPrice5.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName6.Text + " '" + " and Category_ID = " + cmbCategory6.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode6.Text = dr["Product_ID"].ToString();
                    txtPcsInCN6.Text = dr["Box_CTN"].ToString();
                    txtCostPrice6.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName6.Text == "Please Select")
                {
                    txtProductCode6.Text = "";
                    txtPieces6.Text = "";
                    txtPcsInCN6.Text = "";
                    txtCartons6.Text = "";
                    txtCostPrice6.Text = "";
                    txtTotalPrice6.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName7.Text + " '" + " and Category_ID = " + cmbCategory7.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode7.Text = dr["Product_ID"].ToString();
                    txtPcsInCN7.Text = dr["Box_CTN"].ToString();
                    txtCostPrice7.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName7.Text == "Please Select")
                {
                    txtProductCode7.Text = "";
                    txtPieces7.Text = "";
                    txtPcsInCN7.Text = "";
                    txtCartons7.Text = "";
                    txtCostPrice7.Text = "";
                    txtTotalPrice7.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName8.Text + " '" + " and Category_ID = " + cmbCategory8.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode8.Text = dr["Product_ID"].ToString();
                    txtPcsInCN8.Text = dr["Box_CTN"].ToString();
                    txtCostPrice8.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName8.Text == "Please Select")
                {
                    txtProductCode8.Text = "";
                    txtPieces8.Text = "";
                    txtPcsInCN8.Text = "";
                    txtCartons8.Text = "";
                    txtCostPrice8.Text = "";
                    txtTotalPrice8.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName9_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName9.Text + " '" + " and Category_ID = " + cmbCategory9.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode9.Text = dr["Product_ID"].ToString();
                    txtPcsInCN9.Text = dr["Box_CTN"].ToString();
                    txtCostPrice9.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName9.Text == "Please Select")
                {
                    txtProductCode9.Text = "";
                    txtPieces9.Text = "";
                    txtPcsInCN9.Text = "";
                    txtCartons9.Text = "";
                    txtCostPrice9.Text = "";
                    txtTotalPrice9.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName10_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName10.Text + " '" + " and Category_ID = " + cmbCategory10.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode10.Text = dr["Product_ID"].ToString();
                    txtPcsInCN10.Text = dr["Box_CTN"].ToString();
                    txtCostPrice10.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName10.Text == "Please Select")
                {
                    txtProductCode10.Text = "";
                    txtPieces10.Text = "";
                    txtPcsInCN10.Text = "";
                    txtCartons10.Text = "";
                    txtCostPrice10.Text = "";
                    txtTotalPrice10.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName11_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName11.Text + " '" + " and Category_ID = " + cmbCategory11.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode11.Text = dr["Product_ID"].ToString();
                    txtPcsInCN11.Text = dr["Box_CTN"].ToString();
                    txtCostPrice11.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName11.Text == "Please Select")
                {
                    txtProductCode11.Text = "";
                    txtPieces11.Text = "";
                    txtPcsInCN11.Text = "";
                    txtCartons11.Text = "";
                    txtCostPrice11.Text = "";
                    txtTotalPrice11.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName12_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName12.Text + " '" + " and Category_ID = " + cmbCategory12.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode12.Text = dr["Product_ID"].ToString();
                    txtPcsInCN12.Text = dr["Box_CTN"].ToString();
                    txtCostPrice12.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName12.Text == "Please Select")
                {
                    txtProductCode12.Text = "";
                    txtPieces12.Text = "";
                    txtPcsInCN12.Text = "";
                    txtCartons12.Text = "";
                    txtCostPrice12.Text = "";
                    txtTotalPrice12.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName13_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName13.Text + " '" + " and Category_ID = " + cmbCategory13.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode13.Text = dr["Product_ID"].ToString();
                    txtPcsInCN13.Text = dr["Box_CTN"].ToString();
                    txtCostPrice13.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName13.Text == "Please Select")
                {
                    txtProductCode13.Text = "";
                    txtPieces13.Text = "";
                    txtPcsInCN13.Text = "";
                    txtCartons13.Text = "";
                    txtCostPrice13.Text = "";
                    txtTotalPrice13.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName14_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName14.Text + " '" + " and Category_ID = " + cmbCategory14.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode14.Text = dr["Product_ID"].ToString();
                    txtPcsInCN14.Text = dr["Box_CTN"].ToString();
                    txtCostPrice14.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName14.Text == "Please Select")
                {
                    txtProductCode14.Text = "";
                    txtPieces14.Text = "";
                    txtPcsInCN14.Text = "";
                    txtCartons14.Text = "";
                    txtCostPrice14.Text = "";
                    txtTotalPrice14.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName15_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName15.Text + " '" + " and Category_ID = " + cmbCategory15.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode15.Text = dr["Product_ID"].ToString();
                    txtPcsInCN15.Text = dr["Box_CTN"].ToString();
                    txtCostPrice15.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName15.Text == "Please Select")
                {
                    txtProductCode15.Text = "";
                    txtPieces15.Text = "";
                    txtPcsInCN15.Text = "";
                    txtCartons15.Text = "";
                    txtCostPrice15.Text = "";
                    txtTotalPrice15.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void cmbProductName16_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select * from Products where Product_Name = '" + cmbProductName16.Text + " '" + " and Category_ID = " + cmbCategory16.SelectedValue;
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    txtProductCode16.Text = dr["Product_ID"].ToString();
                    txtPcsInCN16.Text = dr["Box_CTN"].ToString();
                    txtCostPrice16.Text = dr["Rate_Box"].ToString();

                }
                con.Close();

                if (cmbProductName16.Text == "Please Select")
                {
                    txtProductCode16.Text = "";
                    txtPieces16.Text = "";
                    txtPcsInCN16.Text = "";
                    txtCartons16.Text = "";
                    txtCostPrice16.Text = "";
                    txtTotalPrice16.Text = "";
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

        private void txtCartons2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory2.Text == "Please Select" && txtCartons2.Text != "" && txtCartons2.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory2.Focus();
                    txtCartons2.Text = "";
                }
                if (cmbProductName2.Text == "Please Select" && cmbCategory2.Text != "Please Select" && txtCartons2.Text != "" && txtCartons2.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName2.Focus();
                    txtCartons2.Text = "";
                }
                if (txtCartons2.Text != "" && txtCartons2.Text != "0")
                {
                    txtPieces2.Text = (Convert.ToInt32(txtPcsInCN2.Text) * Convert.ToInt32(txtCartons2.Text)).ToString();
                    txtTotalPrice2.Text = (Convert.ToInt32(txtPieces2.Text) * Convert.ToInt32(txtCostPrice2.Text)).ToString();
                }
                if (txtCartons2.Text == "" || txtCartons2.Text == "0")
                {
                    txtPieces2.Text = "";
                    txtTotalPrice2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory3.Text == "Please Select" && txtCartons3.Text != "" && txtCartons3.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory3.Focus();
                    txtCartons3.Text = "";
                }
                if (cmbProductName3.Text == "Please Select" && cmbCategory3.Text != "Please Select" && txtCartons3.Text != "" && txtCartons3.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName3.Focus();
                    txtCartons3.Text = "";
                }
                if (txtCartons3.Text != "" && txtCartons3.Text != "0")
                {
                    txtPieces3.Text = (Convert.ToInt32(txtPcsInCN3.Text) * Convert.ToInt32(txtCartons3.Text)).ToString();
                    txtTotalPrice3.Text = (Convert.ToInt32(txtPieces3.Text) * Convert.ToInt32(txtCostPrice3.Text)).ToString();
                }
                if (txtCartons3.Text == "" || txtCartons3.Text == "0")
                {
                    txtPieces3.Text = "";
                    txtTotalPrice3.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory4.Text == "Please Select" && txtCartons4.Text != "" && txtCartons4.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory4.Focus();
                    txtCartons4.Text = "";
                }
                if (cmbProductName4.Text == "Please Select" && cmbCategory4.Text != "Please Select" && txtCartons4.Text != "" && txtCartons4.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName4.Focus();
                    txtCartons4.Text = "";
                }
                if (txtCartons4.Text != "" && txtCartons4.Text != "0")
                {
                    txtPieces4.Text = (Convert.ToInt32(txtPcsInCN4.Text) * Convert.ToInt32(txtCartons4.Text)).ToString();
                    txtTotalPrice4.Text = (Convert.ToInt32(txtPieces4.Text) * Convert.ToInt32(txtCostPrice4.Text)).ToString();
                }
                if (txtCartons4.Text == "" || txtCartons4.Text == "0")
                {
                    txtPieces4.Text = "";
                    txtTotalPrice4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory5.Text == "Please Select" && txtCartons5.Text != "" && txtCartons5.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory5.Focus();
                    txtCartons5.Text = "";
                }
                if (cmbProductName5.Text == "Please Select" && cmbCategory5.Text != "Please Select" && txtCartons5.Text != "" && txtCartons5.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName5.Focus();
                    txtCartons5.Text = "";
                }
                if (txtCartons5.Text != "" && txtCartons5.Text != "0")
                {
                    txtPieces5.Text = (Convert.ToInt32(txtPcsInCN5.Text) * Convert.ToInt32(txtCartons5.Text)).ToString();
                    txtTotalPrice5.Text = (Convert.ToInt32(txtPieces5.Text) * Convert.ToInt32(txtCostPrice5.Text)).ToString();
                }
                if (txtCartons5.Text == "" || txtCartons5.Text == "0")
                {
                    txtPieces5.Text = "";
                    txtTotalPrice5.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory6.Text == "Please Select" && txtCartons6.Text != "" && txtCartons6.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory6.Focus();
                    txtCartons6.Text = "";
                }
                if (cmbProductName6.Text == "Please Select" && cmbCategory6.Text != "Please Select" && txtCartons6.Text != "" && txtCartons6.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName6.Focus();
                    txtCartons6.Text = "";
                }
                if (txtCartons6.Text != "" && txtCartons6.Text != "0")
                {
                    txtPieces6.Text = (Convert.ToInt32(txtPcsInCN6.Text) * Convert.ToInt32(txtCartons6.Text)).ToString();
                    txtTotalPrice6.Text = (Convert.ToInt32(txtPieces6.Text) * Convert.ToInt32(txtCostPrice6.Text)).ToString();
                }
                if (txtCartons6.Text == "" || txtCartons6.Text == "0")
                {
                    txtPieces6.Text = "";
                    txtTotalPrice6.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory7.Text == "Please Select" && txtCartons7.Text != "" && txtCartons7.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory7.Focus();
                    txtCartons7.Text = "";
                }
                if (cmbProductName7.Text == "Please Select" && cmbCategory7.Text != "Please Select" && txtCartons7.Text != "" && txtCartons7.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName7.Focus();
                    txtCartons7.Text = "";
                }
                if (txtCartons7.Text != "" && txtCartons7.Text != "0")
                {
                    txtPieces7.Text = (Convert.ToInt32(txtPcsInCN7.Text) * Convert.ToInt32(txtCartons7.Text)).ToString();
                    txtTotalPrice7.Text = (Convert.ToInt32(txtPieces7.Text) * Convert.ToInt32(txtCostPrice7.Text)).ToString();
                }
                if (txtCartons7.Text == "" || txtCartons7.Text == "0")
                {
                    txtPieces7.Text = "";
                    txtTotalPrice7.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory8.Text == "Please Select" && txtCartons8.Text != "" && txtCartons8.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory8.Focus();
                    txtCartons8.Text = "";
                }
                if (cmbProductName8.Text == "Please Select" && cmbCategory8.Text != "Please Select" && txtCartons8.Text != "" && txtCartons8.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName8.Focus();
                    txtCartons8.Text = "";
                }
                if (txtCartons8.Text != "" && txtCartons8.Text != "0")
                {
                    txtPieces8.Text = (Convert.ToInt32(txtPcsInCN8.Text) * Convert.ToInt32(txtCartons8.Text)).ToString();
                    txtTotalPrice8.Text = (Convert.ToInt32(txtPieces8.Text) * Convert.ToInt32(txtCostPrice8.Text)).ToString();
                }
                if (txtCartons8.Text == "" || txtCartons8.Text == "0")
                {
                    txtPieces8.Text = "";
                    txtTotalPrice8.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory9.Text == "Please Select" && txtCartons9.Text != "" && txtCartons9.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory9.Focus();
                    txtCartons9.Text = "";
                }
                if (cmbProductName9.Text == "Please Select" && cmbCategory9.Text != "Please Select" && txtCartons9.Text != "" && txtCartons9.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName9.Focus();
                    txtCartons9.Text = "";
                }
                if (txtCartons9.Text != "" && txtCartons9.Text != "0")
                {
                    txtPieces9.Text = (Convert.ToInt32(txtPcsInCN9.Text) * Convert.ToInt32(txtCartons9.Text)).ToString();
                    txtTotalPrice9.Text = (Convert.ToInt32(txtPieces9.Text) * Convert.ToInt32(txtCostPrice9.Text)).ToString();
                }
                if (txtCartons9.Text == "" || txtCartons9.Text == "0")
                {
                    txtPieces9.Text = "";
                    txtTotalPrice9.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory10.Text == "Please Select" && txtCartons10.Text != "" && txtCartons10.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory10.Focus();
                    txtCartons10.Text = "";
                }
                if (cmbProductName10.Text == "Please Select" && cmbCategory10.Text != "Please Select" && txtCartons10.Text != "" && txtCartons10.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName10.Focus();
                    txtCartons10.Text = "";
                }
                if (txtCartons10.Text != "" && txtCartons10.Text != "0")
                {
                    txtPieces10.Text = (Convert.ToInt32(txtPcsInCN10.Text) * Convert.ToInt32(txtCartons10.Text)).ToString();
                    txtTotalPrice10.Text = (Convert.ToInt32(txtPieces10.Text) * Convert.ToInt32(txtCostPrice10.Text)).ToString();
                }
                if (txtCartons10.Text == "" || txtCartons10.Text == "0")
                {
                    txtPieces10.Text = "";
                    txtTotalPrice10.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory11.Text == "Please Select" && txtCartons11.Text != "" && txtCartons11.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory11.Focus();
                    txtCartons11.Text = "";
                }
                if (cmbProductName11.Text == "Please Select" && cmbCategory11.Text != "Please Select" && txtCartons11.Text != "" && txtCartons11.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName11.Focus();
                    txtCartons11.Text = "";
                }
                if (txtCartons11.Text != "" && txtCartons11.Text != "0")
                {
                    txtPieces11.Text = (Convert.ToInt32(txtPcsInCN11.Text) * Convert.ToInt32(txtCartons11.Text)).ToString();
                    txtTotalPrice11.Text = (Convert.ToInt32(txtPieces11.Text) * Convert.ToInt32(txtCostPrice11.Text)).ToString();
                }
                if (txtCartons11.Text == "" || txtCartons11.Text == "0")
                {
                    txtPieces11.Text = "";
                    txtTotalPrice11.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory12.Text == "Please Select" && txtCartons12.Text != "" && txtCartons12.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory12.Focus();
                    txtCartons12.Text = "";
                }
                if (cmbProductName12.Text == "Please Select" && cmbCategory12.Text != "Please Select" && txtCartons12.Text != "" && txtCartons12.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName12.Focus();
                    txtCartons12.Text = "";
                }
                if (txtCartons12.Text != "" && txtCartons12.Text != "0")
                {
                    txtPieces12.Text = (Convert.ToInt32(txtPcsInCN12.Text) * Convert.ToInt32(txtCartons12.Text)).ToString();
                    txtTotalPrice12.Text = (Convert.ToInt32(txtPieces12.Text) * Convert.ToInt32(txtCostPrice12.Text)).ToString();
                }
                if (txtCartons12.Text == "" || txtCartons12.Text == "0")
                {
                    txtPieces12.Text = "";
                    txtTotalPrice12.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory13.Text == "Please Select" && txtCartons13.Text != "" && txtCartons13.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory13.Focus();
                    txtCartons13.Text = "";
                }
                if (cmbProductName13.Text == "Please Select" && cmbCategory13.Text != "Please Select" && txtCartons13.Text != "" && txtCartons13.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName13.Focus();
                    txtCartons13.Text = "";
                }
                if (txtCartons13.Text != "" && txtCartons13.Text != "0")
                {
                    txtPieces13.Text = (Convert.ToInt32(txtPcsInCN13.Text) * Convert.ToInt32(txtCartons13.Text)).ToString();
                    txtTotalPrice13.Text = (Convert.ToInt32(txtPieces13.Text) * Convert.ToInt32(txtCostPrice13.Text)).ToString();
                }
                if (txtCartons13.Text == "" || txtCartons13.Text == "0")
                {
                    txtPieces13.Text = "";
                    txtTotalPrice13.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory14.Text == "Please Select" && txtCartons14.Text != "" && txtCartons14.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory14.Focus();
                    txtCartons14.Text = "";
                }
                if (cmbProductName14.Text == "Please Select" && cmbCategory14.Text != "Please Select" && txtCartons14.Text != "" && txtCartons14.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName14.Focus();
                    txtCartons14.Text = "";
                }
                if (txtCartons14.Text != "" && txtCartons14.Text != "0")
                {
                    txtPieces14.Text = (Convert.ToInt32(txtPcsInCN14.Text) * Convert.ToInt32(txtCartons14.Text)).ToString();
                    txtTotalPrice14.Text = (Convert.ToInt32(txtPieces14.Text) * Convert.ToInt32(txtCostPrice14.Text)).ToString();
                }
                if (txtCartons14.Text == "" || txtCartons14.Text == "0")
                {
                    txtPieces14.Text = "";
                    txtTotalPrice14.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory15.Text == "Please Select" && txtCartons15.Text != "" && txtCartons15.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory15.Focus();
                    txtCartons15.Text = "";
                }
                if (cmbProductName15.Text == "Please Select" && cmbCategory15.Text != "Please Select" && txtCartons15.Text != "" && txtCartons15.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName15.Focus();
                    txtCartons15.Text = "";
                }
                if (txtCartons15.Text != "" && txtCartons15.Text != "0")
                {
                    txtPieces15.Text = (Convert.ToInt32(txtPcsInCN15.Text) * Convert.ToInt32(txtCartons15.Text)).ToString();
                    txtTotalPrice15.Text = (Convert.ToInt32(txtPieces15.Text) * Convert.ToInt32(txtCostPrice15.Text)).ToString();
                }
                if (txtCartons15.Text == "" || txtCartons15.Text == "0")
                {
                    txtPieces15.Text = "";
                    txtTotalPrice15.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void txtCartons16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory16.Text == "Please Select" && txtCartons16.Text != "" && txtCartons16.Text != "0")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory16.Focus();
                    txtCartons16.Text = "";
                }
                if (cmbProductName16.Text == "Please Select" && cmbCategory16.Text != "Please Select" && txtCartons16.Text != "" && txtCartons16.Text != "0")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName16.Focus();
                    txtCartons16.Text = "";
                }
                if (txtCartons16.Text != "" && txtCartons16.Text != "0")
                {
                    txtPieces16.Text = (Convert.ToInt32(txtPcsInCN16.Text) * Convert.ToInt32(txtCartons16.Text)).ToString();
                    txtTotalPrice16.Text = (Convert.ToInt32(txtPieces16.Text) * Convert.ToInt32(txtCostPrice16.Text)).ToString();
                }
                if (txtCartons16.Text == "" || txtCartons16.Text == "0")
                {
                    txtPieces16.Text = "";
                    txtTotalPrice16.Text = "";
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

        private void txtCartons2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCartons16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            cmbCategory1.SelectedValue = 0;
            cmbCategory2.SelectedValue = 0;
            cmbCategory3.SelectedValue = 0;
            cmbCategory4.SelectedValue = 0;
            cmbCategory5.SelectedValue = 0;
            cmbCategory6.SelectedValue = 0;
            cmbCategory7.SelectedValue = 0;
            cmbCategory8.SelectedValue = 0;
            cmbCategory9.SelectedValue = 0;
            cmbCategory10.SelectedValue = 0;
            cmbCategory11.SelectedValue = 0;
            cmbCategory12.SelectedValue = 0;
            cmbCategory13.SelectedValue = 0;
            cmbCategory14.SelectedValue = 0;
            cmbCategory15.SelectedValue = 0;
            cmbCategory16.SelectedValue = 0;


            cmbProductName1.SelectedValue = 0;
            cmbProductName2.SelectedValue = 0;
            cmbProductName3.SelectedValue = 0;
            cmbProductName4.SelectedValue = 0;
            cmbProductName5.SelectedValue = 0;
            cmbProductName6.SelectedValue = 0;
            cmbProductName7.SelectedValue = 0;
            cmbProductName8.SelectedValue = 0;
            cmbProductName9.SelectedValue = 0;
            cmbProductName10.SelectedValue = 0;
            cmbProductName11.SelectedValue = 0;
            cmbProductName12.SelectedValue = 0;
            cmbProductName13.SelectedValue = 0;
            cmbProductName14.SelectedValue = 0;
            cmbProductName15.SelectedValue = 0;
            cmbProductName16.SelectedValue = 0;

            txtProductCode1.Text = "";
            txtProductCode2.Text = "";
            txtProductCode3.Text = "";
            txtProductCode4.Text = "";
            txtProductCode5.Text = "";
            txtProductCode6.Text = "";
            txtProductCode7.Text = "";
            txtProductCode8.Text = "";
            txtProductCode9.Text = "";
            txtProductCode10.Text = "";
            txtProductCode11.Text = "";
            txtProductCode12.Text = "";
            txtProductCode13.Text = "";
            txtProductCode14.Text = "";
            txtProductCode15.Text = "";
            txtProductCode16.Text = "";

            txtPieces1.Text = "";
            txtPieces2.Text = "";
            txtPieces3.Text = "";
            txtPieces4.Text = "";
            txtPieces5.Text = "";
            txtPieces6.Text = "";
            txtPieces7.Text = "";
            txtPieces8.Text = "";
            txtPieces9.Text = "";
            txtPieces10.Text = "";
            txtPieces11.Text = "";
            txtPieces12.Text = "";
            txtPieces13.Text = "";
            txtPieces14.Text = "";
            txtPieces15.Text = "";
            txtPieces16.Text = "";

            txtPcsInCN1.Text = "";
            txtPcsInCN2.Text = "";
            txtPcsInCN3.Text = "";
            txtPcsInCN4.Text = "";
            txtPcsInCN5.Text = "";
            txtPcsInCN6.Text = "";
            txtPcsInCN7.Text = "";
            txtPcsInCN8.Text = "";
            txtPcsInCN9.Text = "";
            txtPcsInCN10.Text = "";
            txtPcsInCN11.Text = "";
            txtPcsInCN12.Text = "";
            txtPcsInCN13.Text = "";
            txtPcsInCN14.Text = "";
            txtPcsInCN15.Text = "";
            txtPcsInCN16.Text = "";

            txtCartons1.Text = "";
            txtCartons2.Text = "";
            txtCartons3.Text = "";
            txtCartons4.Text = "";
            txtCartons5.Text = "";
            txtCartons6.Text = "";
            txtCartons7.Text = "";
            txtCartons8.Text = "";
            txtCartons9.Text = "";
            txtCartons10.Text = "";
            txtCartons11.Text = "";
            txtCartons12.Text = "";
            txtCartons13.Text = "";
            txtCartons14.Text = "";
            txtCartons15.Text = "";
            txtCartons16.Text = "";

            txtCostPrice1.Text = "";
            txtCostPrice2.Text = "";
            txtCostPrice3.Text = "";
            txtCostPrice4.Text = "";
            txtCostPrice5.Text = "";
            txtCostPrice6.Text = "";
            txtCostPrice7.Text = "";
            txtCostPrice8.Text = "";
            txtCostPrice9.Text = "";
            txtCostPrice10.Text = "";
            txtCostPrice11.Text = "";
            txtCostPrice12.Text = "";
            txtCostPrice13.Text = "";
            txtCostPrice14.Text = "";
            txtCostPrice15.Text = "";
            txtCostPrice16.Text = "";

            txtTotalPrice1.Text = "";
            txtTotalPrice2.Text = "";
            txtTotalPrice3.Text = "";
            txtTotalPrice4.Text = "";
            txtTotalPrice5.Text = "";
            txtTotalPrice6.Text = "";
            txtTotalPrice7.Text = "";
            txtTotalPrice8.Text = "";
            txtTotalPrice9.Text = "";
            txtTotalPrice10.Text = "";
            txtTotalPrice11.Text = "";
            txtTotalPrice12.Text = "";
            txtTotalPrice13.Text = "";
            txtTotalPrice14.Text = "";
            txtTotalPrice15.Text = "";
            txtTotalPrice16.Text = "";

            txtTotalAmount.Text = "";
            txtTotalCartons.Text = "";
            txtDis.Text = "0";
            txtTAAD.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtTotalPrice1.Text == "")
                {
                    txtTotalPrice1.Text = "0";
                }
                if (txtTotalPrice2.Text == "")
                {
                    txtTotalPrice2.Text = "0";
                }
                if (txtTotalPrice3.Text == "")
                {
                    txtTotalPrice3.Text = "0";
                }
                if (txtTotalPrice4.Text == "")
                {
                    txtTotalPrice4.Text = "0";
                }
                if (txtTotalPrice5.Text == "")
                {
                    txtTotalPrice5.Text = "0";
                }
                if (txtTotalPrice6.Text == "")
                {
                    txtTotalPrice6.Text = "0";
                }
                if (txtTotalPrice7.Text == "")
                {
                    txtTotalPrice7.Text = "0";
                }
                if (txtTotalPrice8.Text == "")
                {
                    txtTotalPrice8.Text = "0";
                }
                if (txtTotalPrice9.Text == "")
                {
                    txtTotalPrice9.Text = "0";
                }
                if (txtTotalPrice10.Text == "")
                {
                    txtTotalPrice10.Text = "0";
                }
                if (txtTotalPrice11.Text == "")
                {
                    txtTotalPrice11.Text = "0";
                }
                if (txtTotalPrice12.Text == "")
                {
                    txtTotalPrice12.Text = "0";
                }
                if (txtTotalPrice13.Text == "")
                {
                    txtTotalPrice13.Text = "0";
                }
                if (txtTotalPrice14.Text == "")
                {
                    txtTotalPrice14.Text = "0";
                }
                if (txtTotalPrice15.Text == "")
                {
                    txtTotalPrice15.Text = "0";
                }
                if (txtTotalPrice16.Text == "")
                {
                    txtTotalPrice16.Text = "0";
                }
                if (txtDis.Text == "")
                {
                    txtDis.Text = "0";
                }
                txtTotalAmount.Text = (Convert.ToDouble(txtTotalPrice1.Text) + Convert.ToDouble(txtTotalPrice2.Text) + Convert.ToDouble(txtTotalPrice3.Text) + Convert.ToDouble(txtTotalPrice4.Text)
                    + Convert.ToDouble(txtTotalPrice5.Text) + Convert.ToDouble(txtTotalPrice6.Text) + Convert.ToDouble(txtTotalPrice7.Text) + Convert.ToDouble(txtTotalPrice8.Text)
                    + Convert.ToDouble(txtTotalPrice9.Text) + Convert.ToDouble(txtTotalPrice10.Text) + Convert.ToDouble(txtTotalPrice11.Text) + Convert.ToDouble(txtTotalPrice12.Text)
                    + Convert.ToDouble(txtTotalPrice13.Text) + Convert.ToDouble(txtTotalPrice14.Text) + Convert.ToDouble(txtTotalPrice15.Text) + Convert.ToDouble(txtTotalPrice16.Text)).ToString();

                
                 if (txtCartons1.Text == "")
                 {
                     txtCartons1.Text = "0";
                 }
                 if (txtCartons2.Text == "")
                 {
                     txtCartons2.Text = "0";
                 }
                 if (txtCartons3.Text == "")
                 {
                     txtCartons3.Text = "0";
                 }
                 if (txtCartons4.Text == "")
                 {
                     txtCartons4.Text = "0";
                 }
                 if (txtCartons5.Text == "")
                 {
                     txtCartons5.Text = "0";
                 }
                 if (txtCartons6.Text == "")
                 {
                     txtCartons6.Text = "0";
                 }
                 if (txtCartons7.Text == "")
                 {
                     txtCartons7.Text = "0";
                 }
                 if (txtCartons8.Text == "")
                 {
                     txtCartons8.Text = "0";
                 }
                 if (txtCartons9.Text == "")
                 {
                     txtCartons9.Text = "0";
                 }
                 if (txtCartons10.Text == "")
                 {
                     txtCartons10.Text = "0";
                 }
                 if (txtCartons11.Text == "")
                 {
                     txtCartons11.Text = "0";
                 }
                 if (txtCartons12.Text == "")
                 {
                     txtCartons12.Text = "0";
                 }
                 if (txtCartons13.Text == "")
                 {
                     txtCartons13.Text = "0";
                 }
                 if (txtCartons14.Text == "")
                 {
                     txtCartons14.Text = "0";
                 }
                 if (txtCartons15.Text == "")
                 {
                     txtCartons15.Text = "0";
                 }
                 if (txtCartons16.Text == "")
                 {
                     txtCartons16.Text = "0";
                 }
                 txtTotalCartons.Text = (Convert.ToDouble(txtCartons1.Text) + Convert.ToDouble(txtCartons2.Text) + Convert.ToDouble(txtCartons3.Text) + Convert.ToDouble(txtCartons4.Text) +
                     Convert.ToDouble(txtCartons5.Text) + Convert.ToDouble(txtCartons6.Text) + Convert.ToDouble(txtCartons7.Text) + Convert.ToDouble(txtCartons8.Text) + Convert.ToDouble(txtCartons9.Text) +
                     Convert.ToDouble(txtCartons10.Text) + Convert.ToDouble(txtCartons11.Text) + Convert.ToDouble(txtCartons12.Text) + Convert.ToDouble(txtCartons13.Text) + Convert.ToDouble(txtCartons14.Text)
                     + Convert.ToDouble(txtCartons15.Text) + Convert.ToDouble(txtCartons16.Text)).ToString();

                if (txtDis.Text != "" && txtDis.Text != "0")
                {
                    Double Dis = (Convert.ToDouble(txtTotalAmount.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    txtTAAD.Text = (Convert.ToDouble(txtTotalAmount.Text) - Dis).ToString();
                }
                else
                {
                    txtTAAD.Text = txtTotalAmount.Text;
                }
            }
            catch
            {
                MessageBox.Show("You have entered wrong value in quantity. Please check it.");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalPrice1.Text != "0" && txtTotalPrice1.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice1.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice1.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory1.SelectedValue + "," +
                                                                                                                                                       txtProductCode1.Text + "," +
                                                                                                                                                       txtPieces1.Text + "," +
                                                                                                                                                       txtCartons1.Text + "," +
                                                                                                                                                       txtDis.Text + "," +
                                                                                                                                                       totalAmount + ",'" +
                                                                                                                                                       TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces1.Text) + " where Product_ID = " + txtProductCode1.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice2.Text != "" && txtTotalPrice2.Text != "0")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice2.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice2.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons,  Discount, Total_Amount, Date) values (" + cmbCategory2.SelectedValue + "," +
                                                                                                                                                                          txtProductCode2.Text + "," +
                                                                                                                                                                          txtPieces2.Text + "," +
                                                                                                                                                                          txtCartons2.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces2.Text) + " where Product_ID = " + txtProductCode2.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }

                if (txtTotalPrice3.Text != "" && txtTotalPrice3.Text != "0")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice3.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice3.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory3.SelectedValue + "," +
                                                                                                                                                                          txtProductCode3.Text + "," +
                                                                                                                                                                          txtPieces3.Text + "," +
                                                                                                                                                                          txtCartons3.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces3.Text) + " where Product_ID = " + txtProductCode3.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                if (txtTotalPrice4.Text != "0" && txtTotalPrice4.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice4.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice4.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory4.SelectedValue + "," +
                                                                                                                                                                          txtProductCode4.Text + "," +
                                                                                                                                                                          txtPieces4.Text + "," +
                                                                                                                                                                          txtCartons4.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces4.Text) + " where Product_ID = " + txtProductCode4.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice5.Text != "0" && txtTotalPrice5.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice5.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice5.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory5.SelectedValue + "," +
                                                                                                                                                                          txtProductCode5.Text + "," +
                                                                                                                                                                          txtPieces5.Text + "," +
                                                                                                                                                                          txtCartons5.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces5.Text) + " where Product_ID = " + txtProductCode5.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice6.Text != "0" && txtTotalPrice6.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice6.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice6.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory6.SelectedValue + "," +
                                                                                                                                                                          txtProductCode6.Text + "," +
                                                                                                                                                                          txtPieces6.Text + "," +
                                                                                                                                                                          txtCartons6.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces6.Text) + " where Product_ID = " + txtProductCode6.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice7.Text != "0" && txtTotalPrice7.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice7.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice7.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory7.SelectedValue + "," +
                                                                                                                                                                          txtProductCode7.Text + "," +
                                                                                                                                                                          txtPieces7.Text + "," +
                                                                                                                                                                          txtCartons7.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces7.Text) + " where Product_ID = " + txtProductCode7.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice8.Text != "0" && txtTotalPrice8.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice8.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice8.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory8.SelectedValue + "," +
                                                                                                                                                                          txtProductCode8.Text + "," +
                                                                                                                                                                          txtPieces8.Text + "," +
                                                                                                                                                                          txtCartons8.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces8.Text) + " where Product_ID = " + txtProductCode8.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice9.Text != "0" && txtTotalPrice9.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice9.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice9.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory9.SelectedValue + "," +
                                                                                                                                                                          txtProductCode9.Text + "," +
                                                                                                                                                                          txtPieces9.Text + "," +
                                                                                                                                                                          txtCartons9.Text + "," +
                                                                                                                                                                          txtDis.Text + "," +
                                                                                                                                                                          totalAmount + ",'" +
                                                                                                                                                                          TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces9.Text) + " where Product_ID = " + txtProductCode9.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice10.Text != "0" && txtTotalPrice10.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice10.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice10.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory10.SelectedValue + "," +
                                                                                                                                                      txtProductCode10.Text + "," +
                                                                                                                                                      txtPieces10.Text + "," +
                                                                                                                                                      txtCartons10.Text + "," +
                                                                                                                                                      txtDis.Text + "," +
                                                                                                                                                      totalAmount + ",'" +
                                                                                                                                                      TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces10.Text) + " where Product_ID = " + txtProductCode10.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice11.Text != "0" && txtTotalPrice11.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice11.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice11.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases (Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory11.SelectedValue + "," +
                                                                                                                                                  txtProductCode11.Text + "," +
                                                                                                                                                  txtPieces11.Text + "," +
                                                                                                                                                  txtCartons11.Text + "," +
                                                                                                                                                  txtDis.Text + "," +
                                                                                                                                                  totalAmount + ",'" +
                                                                                                                                                  TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces11.Text) + " where Product_ID = " + txtProductCode11.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice12.Text != "0" && txtTotalPrice12.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice12.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice12.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory12.SelectedValue + "," +
                                                                                                                                                       txtProductCode12.Text + "," +
                                                                                                                                                       txtPieces12.Text + "," +
                                                                                                                                                       txtCartons12.Text + "," +
                                                                                                                                                       txtDis.Text + "," +
                                                                                                                                                       totalAmount + ",'" +
                                                                                                                                                       TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces12.Text) + " where Product_ID = " + txtProductCode12.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice13.Text != "0" && txtTotalPrice13.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice13.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice13.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory13.SelectedValue + "," +
                                                                                                                                                       txtProductCode13.Text + "," +
                                                                                                                                                       txtPieces13.Text + "," +
                                                                                                                                                       txtCartons13.Text + "," +
                                                                                                                                                       txtDis.Text + "," +
                                                                                                                                                       totalAmount + ",'" +
                                                                                                                                                       TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces13.Text) + " where Product_ID = " + txtProductCode13.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice14.Text != "0" && txtTotalPrice14.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice14.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice14.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory14.SelectedValue + "," +
                                                                                                                                                       txtProductCode14.Text + "," +
                                                                                                                                                       txtPieces14.Text + "," +
                                                                                                                                                       txtCartons14.Text + "," +
                                                                                                                                                       txtDis.Text + "," +
                                                                                                                                                       totalAmount + ",'" +
                                                                                                                                                       TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces14.Text) + " where Product_ID = " + txtProductCode14.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice15.Text != "0" && txtTotalPrice15.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice15.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice15.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory15.SelectedValue + "," +
                                                                                                                                                       txtProductCode15.Text + "," +
                                                                                                                                                       txtPieces15.Text + "," +
                                                                                                                                                       txtCartons15.Text + "," +
                                                                                                                                                       txtDis.Text + "," +
                                                                                                                                                       totalAmount + ",'" +
                                                                                                                                                       TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces15.Text) + " where Product_ID = " + txtProductCode15.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                if (txtTotalPrice16.Text != "0" && txtTotalPrice16.Text != "")
                {
                    Double Dis = (Convert.ToDouble(txtTotalPrice16.Text) * Convert.ToDouble(txtDis.Text) / 100);
                    string totalAmount = (Convert.ToDouble(txtTotalPrice16.Text) - Dis).ToString();
                    String InsertQuery = "Insert into Purchases ( Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + cmbCategory16.SelectedValue + "," +
                                                                                                                                                       txtProductCode16.Text + "," +
                                                                                                                                                       txtPieces16.Text + "," +
                                                                                                                                                       txtCartons16.Text + "," +
                                                                                                                                                       txtDis.Text + "," +
                                                                                                                                                       totalAmount + ",'" +
                                                                                                                                                       TodayDate.GUID() + "')";
                    String updateQuery = "update Inventory set Quantity = Quantity + " + Convert.ToInt32(txtPieces16.Text) + " where Product_ID = " + txtProductCode16.Text;
                    SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Purchases have successfully saved.");
                refresh();
                PurchaseView();
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        public void PurchaseView()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Purchase_ID, c.Category_Name as Category, p.Product_Name as Product, " +
                                                        " pu.Qty_Pcs, pu.Cartons, pu.Discount, pu.Total_Amount, pu.date" +
                                                        " from Purchases pu " +
                                                        " join Category c on c.Category_ID = pu.Category_ID" +
                                                        " join Products p on p.Product_ID = pu.Product_ID" +
                                                        " where pu.date = '" + TodayDate.GUID() + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gvPurchase.DataSource = dt;
        }
        String ID;
        private void gvPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = gvPurchase.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != null)
                {

                    String updateQuery = "update inventory " +
                                          "set Quantity = Quantity - (select Qty_Pcs from Purchases where Purchase_ID = " + ID + ")" +
                                          "where Product_ID = (select Product_ID from Purchases where Purchase_ID = " + ID + ")";

                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                    con.Open();
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();

                    String DeleteQuery = "Delete from Purchases where Purchase_ID = " + ID;
                    SqlCommand cmdDelete = new SqlCommand(DeleteQuery, con);
                    con.Open();
                    cmdDelete.ExecuteNonQuery();
                    con.Close();
                    PurchaseView();
                    MessageBox.Show("Purchase has successfully removed.");
                    ID = "";
                }
                else
                {
                    MessageBox.Show("Please select Sale_ID");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        

        private void stmSales_Click_1(object sender, EventArgs e)
        {
            frmSales s = new frmSales();
            s.Show();
            this.Close();
        }

        private void stmPurchaseReturn_Click(object sender, EventArgs e)
        {
            PurchaseReturn pr = new PurchaseReturn();
            pr.Show();
            this.Close();
        }

        private void stmSalesReturn_Click(object sender, EventArgs e)
        {
            frmSaleReturn sr = new frmSaleReturn();
            sr.Show();
            this.Close();
        }

        private void stmSalesReport_Click(object sender, EventArgs e)
        {
            frmSalesReport sr = new frmSalesReport();
            sr.Show();
            this.Close();
        }
    }
}
