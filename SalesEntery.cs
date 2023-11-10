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
    public partial class frmSalesEntery : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");

        public frmSalesEntery()
        {
            InitializeComponent();
        }

        private void frmsellEntery_Load(object sender, EventArgs e)
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

            DataAdaptionCategory.BindCombo(cmbBooker,
                                    SearchFilter.tblBooker,
                                    SearchFilter.BookerName,
                                    SearchFilter.BookerID,
                                    String.Empty);
        }

        private void cmbCategory1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName1,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory1.SelectedValue.ToString());
        }

        private void cmbCategory2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName2,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory2.SelectedValue.ToString());
        }

        private void cmbCategory3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName3,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory3.SelectedValue.ToString());
        }

        private void cmbCategory4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName4,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory4.SelectedValue.ToString());
        }

        private void cmbCategory5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName5,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory5.SelectedValue.ToString());
        }

        private void cmbCategory6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName6,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory6.SelectedValue.ToString());
        }

        private void cmbCategory7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName7,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory7.SelectedValue.ToString());
        }

        private void cmbCategory8_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName8,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory8.SelectedValue.ToString());
        }

        private void cmbCategory9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName9,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory9.SelectedValue.ToString());
        }

        private void cmbCategory10_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName10,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory10.SelectedValue.ToString());
        }

        private void cmbCategory11_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbProductName11,
                                    SearchFilter.tblProducts,
                                    SearchFilter.ProductName,
                                    SearchFilter.CategoryID,
                                    cmbCategory11.SelectedValue.ToString());
        }

        private void cmbCategory12_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    txtCostPrice1.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice2.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice3.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice4.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice5.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice6.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice7.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice8.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice9.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice10.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice11.Text = dr["TP_PCS"].ToString();

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
                    txtCostPrice12.Text = dr["TP_PCS"].ToString();

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
                    txtQtyInCN13.Text = dr["Box_CTN"].ToString();
                    txtCostPrice13.Text = dr["TP_PCS"].ToString();

                }
                con.Close();

                if (cmbProductName13.Text == "Please Select")
                {
                    txtProductCode13.Text = "";
                    txtQuantity13.Text = "";
                    txtQtyInCN13.Text = "";
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
        private void txtQuantity1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory1.Text == "Please Select" && txtPieces1.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory1.Focus();
                    txtPieces1.Text = "";
                }
                if (cmbProductName1.Text == "Please Select" && cmbCategory1.Text != "Please Select" && txtPieces1.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName1.Focus();
                    txtPieces1.Text = "";
                }
                if (txtPieces1.Text != "" && cmbProductName1.Text != "Please Select" && cmbCategory1.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode1.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces1.Text) && txtPieces1.Text != "0")
                        {
                            MessageBox.Show(cmbProductName1.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons1.Text = "";
                            txtTotalPrice1.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces1.Text) && txtPieces1.Text != "0")
                        {
                            txtCartons1.Text = (Convert.ToDouble(txtPieces1.Text) / Convert.ToDouble(txtPcsInCN1.Text)).ToString();
                            txtTotalPrice1.Text = (Convert.ToDouble(txtPieces1.Text) * Convert.ToDouble(txtCostPrice1.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces1.Text == "" || txtPieces1.Text == "0")
                {
                    txtCartons1.Text = "";
                    txtTotalPrice1.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }




        }

        private void txtQuantity2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory2.Text == "Please Select" && txtPieces2.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory2.Focus();
                    txtPieces2.Text = "";
                }
                if (cmbProductName2.Text == "Please Select" && cmbCategory2.Text != "Please Select" && txtPieces2.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName2.Focus();
                    txtPieces2.Text = "";
                }
                if (txtPieces2.Text != "" && cmbProductName2.Text != "Please Select" && cmbCategory2.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode2.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces2.Text) && txtPieces2.Text != "0")
                        {
                            MessageBox.Show(cmbProductName2.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons2.Text = "";
                            txtTotalPrice2.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces2.Text) && txtPieces2.Text != "0")
                        {
                            txtCartons2.Text = (Convert.ToDouble(txtPieces2.Text) / Convert.ToDouble(txtPcsInCN2.Text)).ToString();
                            txtTotalPrice2.Text = (Convert.ToDouble(txtPieces2.Text) * Convert.ToDouble(txtCostPrice2.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces2.Text == "" || txtPieces2.Text == "0")
                {
                    txtCartons2.Text = "";
                    txtTotalPrice2.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory3.Text == "Please Select" && txtPieces3.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory3.Focus();
                    txtPieces3.Text = "";
                }
                if (cmbProductName3.Text == "Please Select" && cmbCategory3.Text != "Please Select" && txtPieces3.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName3.Focus();
                    txtPieces3.Text = "";
                }
                if (txtPieces3.Text != "" && cmbProductName3.Text != "Please Select" && cmbCategory3.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode3.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces3.Text) && txtPieces3.Text != "0")
                        {
                            MessageBox.Show(cmbProductName3.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons3.Text = "";
                            txtTotalPrice3.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces3.Text) && txtPieces3.Text != "0")
                        {
                            txtCartons3.Text = (Convert.ToDouble(txtPieces3.Text) / Convert.ToDouble(txtPcsInCN3.Text)).ToString();
                            txtTotalPrice3.Text = (Convert.ToDouble(txtPieces3.Text) * Convert.ToDouble(txtCostPrice3.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces3.Text == "" || txtPieces3.Text == "0")
                {
                    txtCartons3.Text = "";
                    txtTotalPrice3.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory4.Text == "Please Select" && txtPieces4.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory4.Focus();
                    txtPieces4.Text = "";
                }
                if (cmbProductName4.Text == "Please Select" && cmbCategory4.Text != "Please Select" && txtPieces4.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName4.Focus();
                    txtPieces4.Text = "";
                }
                if (txtPieces4.Text != "" && cmbProductName4.Text != "Please Select" && cmbCategory4.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode4.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces4.Text) && txtPieces4.Text != "0")
                        {
                            MessageBox.Show(cmbProductName4.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons4.Text = "";
                            txtTotalPrice4.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces4.Text) && txtPieces4.Text != "0")
                        {
                            txtCartons4.Text = (Convert.ToDouble(txtPieces4.Text) / Convert.ToDouble(txtPcsInCN4.Text)).ToString();
                            txtTotalPrice4.Text = (Convert.ToDouble(txtPieces4.Text) * Convert.ToDouble(txtCostPrice4.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces4.Text == "" || txtPieces4.Text == "0")
                {
                    txtCartons4.Text = "";
                    txtTotalPrice4.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory5.Text == "Please Select" && txtPieces5.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory5.Focus();
                    txtPieces5.Text = "";
                }
                if (cmbProductName5.Text == "Please Select" && cmbCategory5.Text != "Please Select" && txtPieces5.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName5.Focus();
                    txtPieces5.Text = "";
                }
                if (txtPieces5.Text != "" && cmbProductName5.Text != "Please Select" && cmbCategory5.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode5.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces5.Text) && txtPieces5.Text != "0")
                        {
                            MessageBox.Show(cmbProductName5.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons5.Text = "";
                            txtTotalPrice5.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces5.Text) && txtPieces5.Text != "0")
                        {
                            txtCartons5.Text = (Convert.ToDouble(txtPieces5.Text) / Convert.ToDouble(txtPcsInCN5.Text)).ToString();
                            txtTotalPrice5.Text = (Convert.ToDouble(txtPieces5.Text) * Convert.ToDouble(txtCostPrice5.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces5.Text == "" || txtPieces5.Text == "0")
                {
                    txtCartons5.Text = "";
                    txtTotalPrice5.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory6.Text == "Please Select" && txtPieces6.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory6.Focus();
                    txtPieces6.Text = "";
                }
                if (cmbProductName6.Text == "Please Select" && cmbCategory6.Text != "Please Select" && txtPieces6.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName6.Focus();
                    txtPieces6.Text = "";
                }
                if (txtPieces6.Text != "" && cmbProductName6.Text != "Please Select" && cmbCategory6.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode6.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces6.Text) && txtPieces6.Text != "0")
                        {
                            MessageBox.Show(cmbProductName6.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons6.Text = "";
                            txtTotalPrice6.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces6.Text) && txtPieces6.Text != "0")
                        {
                            txtCartons6.Text = (Convert.ToDouble(txtPieces6.Text) / Convert.ToDouble(txtPcsInCN6.Text)).ToString();
                            txtTotalPrice6.Text = (Convert.ToDouble(txtPieces6.Text) * Convert.ToDouble(txtCostPrice6.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces6.Text == "" || txtPieces6.Text == "0")
                {
                    txtCartons6.Text = "";
                    txtTotalPrice6.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory7.Text == "Please Select" && txtPieces7.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory7.Focus();
                    txtPieces7.Text = "";
                }
                if (cmbProductName7.Text == "Please Select" && cmbCategory7.Text != "Please Select" && txtPieces7.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName7.Focus();
                    txtPieces7.Text = "";
                }
                if (txtPieces7.Text != "" && cmbProductName7.Text != "Please Select" && cmbCategory7.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode7.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces7.Text) && txtPieces7.Text != "0")
                        {
                            MessageBox.Show(cmbProductName7.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons7.Text = "";
                            txtTotalPrice7.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces7.Text) && txtPieces7.Text != "0")
                        {
                            txtCartons7.Text = (Convert.ToDouble(txtPieces7.Text) / Convert.ToDouble(txtPcsInCN7.Text)).ToString();
                            txtTotalPrice7.Text = (Convert.ToDouble(txtPieces7.Text) * Convert.ToDouble(txtCostPrice7.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces7.Text == "" || txtPieces7.Text == "0")
                {
                    txtCartons7.Text = "";
                    txtTotalPrice7.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory8.Text == "Please Select" && txtPieces8.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory8.Focus();
                    txtPieces8.Text = "";
                }
                if (cmbProductName8.Text == "Please Select" && cmbCategory8.Text != "Please Select" && txtPieces8.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName8.Focus();
                    txtPieces8.Text = "";
                }
                if (txtPieces8.Text != "" && cmbProductName8.Text != "Please Select" && cmbCategory8.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode8.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces8.Text) && txtPieces8.Text != "0")
                        {
                            MessageBox.Show(cmbProductName8.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons8.Text = "";
                            txtTotalPrice8.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces8.Text) && txtPieces8.Text != "0")
                        {
                            txtCartons8.Text = (Convert.ToDouble(txtPieces8.Text) / Convert.ToDouble(txtPcsInCN8.Text)).ToString();
                            txtTotalPrice8.Text = (Convert.ToDouble(txtPieces8.Text) * Convert.ToDouble(txtCostPrice8.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces8.Text == "" || txtPieces8.Text == "0")
                {
                    txtCartons8.Text = "";
                    txtTotalPrice8.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity9_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory9.Text == "Please Select" && txtPieces9.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory9.Focus();
                    txtPieces9.Text = "";
                }
                if (cmbProductName9.Text == "Please Select" && cmbCategory9.Text != "Please Select" && txtPieces9.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName9.Focus();
                    txtPieces9.Text = "";
                }
                if (txtPieces9.Text != "" && cmbProductName9.Text != "Please Select" && cmbCategory9.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode9.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces9.Text) && txtPieces9.Text != "0")
                        {
                            MessageBox.Show(cmbProductName9.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons9.Text = "";
                            txtTotalPrice9.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces9.Text) && txtPieces9.Text != "0")
                        {
                            txtCartons9.Text = (Convert.ToDouble(txtPieces9.Text) / Convert.ToDouble(txtPcsInCN9.Text)).ToString();
                            txtTotalPrice9.Text = (Convert.ToDouble(txtPieces9.Text) * Convert.ToDouble(txtCostPrice9.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces9.Text == "" || txtPieces9.Text == "0")
                {
                    txtCartons9.Text = "";
                    txtTotalPrice9.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory10.Text == "Please Select" && txtPieces10.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory10.Focus();
                    txtPieces10.Text = "";
                }
                if (cmbProductName10.Text == "Please Select" && cmbCategory10.Text != "Please Select" && txtPieces10.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName10.Focus();
                    txtPieces10.Text = "";
                }
                if (txtPieces10.Text != "" && cmbProductName10.Text != "Please Select" && cmbCategory10.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode10.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces10.Text) && txtPieces10.Text != "0")
                        {
                            MessageBox.Show(cmbProductName10.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons10.Text = "";
                            txtTotalPrice10.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces10.Text) && txtPieces10.Text != "0")
                        {
                            txtCartons10.Text = (Convert.ToDouble(txtPieces10.Text) / Convert.ToDouble(txtPcsInCN10.Text)).ToString();
                            txtTotalPrice10.Text = (Convert.ToDouble(txtPieces10.Text) * Convert.ToDouble(txtCostPrice10.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces10.Text == "" || txtPieces10.Text == "0")
                {
                    txtCartons10.Text = "";
                    txtTotalPrice10.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory11.Text == "Please Select" && txtPieces11.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory11.Focus();
                    txtPieces11.Text = "";
                }
                if (cmbProductName11.Text == "Please Select" && cmbCategory11.Text != "Please Select" && txtPieces11.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName11.Focus();
                    txtPieces11.Text = "";
                }
                if (txtPieces11.Text != "" && cmbProductName11.Text != "Please Select" && cmbCategory11.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode11.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces11.Text) && txtPieces11.Text != "0")
                        {
                            MessageBox.Show(cmbProductName11.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons11.Text = "";
                            txtTotalPrice11.Text = "";
                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces11.Text) && txtPieces12.Text != "0")
                        {
                            txtCartons11.Text = (Convert.ToDouble(txtPieces11.Text) / Convert.ToDouble(txtPcsInCN11.Text)).ToString();
                            txtTotalPrice11.Text = (Convert.ToDouble(txtPieces11.Text) * Convert.ToDouble(txtCostPrice11.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces11.Text == "" || txtPieces11.Text == "0")
                {
                    txtCartons11.Text = "";
                    txtTotalPrice11.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please Restart software");
            }

        }

        private void txtQuantity12_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbCategory12.Text == "Please Select" && txtPieces12.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory12.Focus();
                    txtPieces12.Text = "";
                }
                if (cmbProductName12.Text == "Please Select" && cmbCategory12.Text != "Please Select" && txtPieces12.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName12.Focus();
                    txtPieces12.Text = "";
                }
                if (txtPieces12.Text != "" && cmbProductName12.Text != "Please Select" && cmbCategory12.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode12.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtPieces12.Text) && txtPieces12.Text != "0")
                        {
                            MessageBox.Show(cmbProductName12.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons12.Text = "";
                            txtTotalPrice12.Text = "";
                             //txtQuantity12.Text = (Convert.ToInt32(qty) -1).ToString();

                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtPieces12.Text) && txtPieces12.Text != "0")
                        {
                            txtCartons12.Text = (Convert.ToDouble(txtPieces12.Text) / Convert.ToDouble(txtPcsInCN12.Text)).ToString();
                            txtTotalPrice12.Text = (Convert.ToDouble(txtPieces12.Text) * Convert.ToDouble(txtCostPrice12.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtPieces12.Text == "" || txtPieces12.Text == "0")
                {
                    txtCartons12.Text = "";
                    txtTotalPrice12.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart.");
            }

        }
        private void txtQuantity13_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory13.Text == "Please Select" && txtQuantity13.Text != "")
                {
                    MessageBox.Show("Please select category.");
                    cmbCategory13.Focus();
                    txtQuantity13.Text = "";
                }
                if (cmbProductName13.Text == "Please Select" && cmbCategory13.Text != "Please Select" && txtQuantity13.Text != "")
                {
                    MessageBox.Show("Please select product.");
                    cmbProductName13.Focus();
                    txtQuantity13.Text = "";
                }
                if (txtQuantity13.Text != "" && cmbProductName13.Text != "Please Select" && cmbCategory13.Text != "Please Select")
                {
                    String query = "select * from Inventory where Product_ID = " + txtProductCode13.Text;
                    SqlCommand cmd = new SqlCommand(query, con);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        string qty = dr["Quantity"].ToString();
                        if (Convert.ToInt32(qty) <= Convert.ToInt32(txtQuantity13.Text) && txtQuantity13.Text != "0")
                        {
                            MessageBox.Show(cmbProductName13.Text + " is out of stock becasue you have just " + qty + " Pieces.");
                            txtCartons13.Text = "";
                            txtTotalPrice13.Text = "";
                            //txtQuantity12.Text = (Convert.ToInt32(qty) -1).ToString();

                        }
                        if (Convert.ToInt32(qty) >= Convert.ToInt32(txtQuantity13.Text) && txtQuantity13.Text != "0")
                        {
                            txtCartons13.Text = (Convert.ToDouble(txtQuantity13.Text) / Convert.ToDouble(txtQtyInCN13.Text)).ToString();
                            txtTotalPrice13.Text = (Convert.ToDouble(txtQuantity13.Text) * Convert.ToDouble(txtCostPrice13.Text)).ToString();
                        }
                    }
                    con.Close();
                }
                if (txtQuantity13.Text == "" || txtQuantity13.Text == "0")
                {
                    txtCartons13.Text = "";
                    txtTotalPrice13.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please restart.");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();

            cmbBooker.SelectedValue = 0;
            txtBookerID.Text = "";
            cmbArea.SelectedValue = 0;
            txtAreaID.Text = "";

            
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                if(txtTotalPrice1.Text == "")
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
                if (txtDis.Text == "")
                {
                    txtDis.Text = "0";
                }
                txtTotalAmount.Text = (Convert.ToDouble(txtTotalPrice1.Text) + Convert.ToDouble(txtTotalPrice2.Text) + Convert.ToDouble(txtTotalPrice3.Text) + Convert.ToDouble(txtTotalPrice4.Text)
                    + Convert.ToDouble(txtTotalPrice5.Text) + Convert.ToDouble(txtTotalPrice6.Text) + Convert.ToDouble(txtTotalPrice7.Text) + Convert.ToDouble(txtTotalPrice8.Text)
                    + Convert.ToDouble(txtTotalPrice9.Text) + Convert.ToDouble(txtTotalPrice10.Text) + Convert.ToDouble(txtTotalPrice11.Text) + Convert.ToDouble(txtTotalPrice12.Text)).ToString();

            }
            catch
            {
                MessageBox.Show("You have entered wrong value in quantity. Please check it.");
            }

            try {
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
                txtTotalCartons.Text = (Convert.ToDouble(txtCartons1.Text) + Convert.ToDouble(txtCartons2.Text) + Convert.ToDouble(txtCartons3.Text) + Convert.ToDouble(txtCartons4.Text) +
                    Convert.ToDouble(txtCartons5.Text) + Convert.ToDouble(txtCartons6.Text) + Convert.ToDouble(txtCartons7.Text) + Convert.ToDouble(txtCartons8.Text) + Convert.ToDouble(txtCartons9.Text) +
                    Convert.ToDouble(txtCartons10.Text) + Convert.ToDouble(txtCartons11.Text) + Convert.ToDouble(txtCartons12.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("You have entered wrong value in quantity. Please check it.");
            }
            try
            {
                if (txtDis.Text != "")
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
                MessageBox.Show("You have entered wrong value in discount. Please check it.");
            }
        }
        

        private void cmbBooker_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAdaptionCategory.BindCombo(cmbArea,
                                    SearchFilter.tblArea,
                                    SearchFilter.AreaName,
                                    SearchFilter.BookerID,
                                    cmbBooker.SelectedValue.ToString());


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
        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "select * from Area where Booker_ID = " + cmbArea.SelectedValue + " and Area_Name = '" +cmbArea.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAreaID.Text = dr["Area_ID"].ToString();
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBookerID.Text != "" && txtAreaID.Text != "")
                {
                    if (txtTotalPrice1.Text != "0" && txtTotalPrice1.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice1.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice1.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory1.SelectedValue + "," +
                                                                                                                                                                              txtProductCode1.Text + "," +
                                                                                                                                                                              txtPieces1.Text + "," +
                                                                                                                                                                              txtCartons1.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" + 
                                                                                                                                                                              TodayDate.GUID() +"')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces1.Text) + " where Product_ID = " + txtProductCode1.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery+ updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice2.Text != "" && txtTotalPrice2.Text != "0")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice2.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice2.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory2.SelectedValue + "," +
                                                                                                                                                                              txtProductCode2.Text + "," +
                                                                                                                                                                              txtPieces2.Text + "," +
                                                                                                                                                                              txtCartons2.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces2.Text) + " where Product_ID = " + txtProductCode2.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }

                    if (txtTotalPrice3.Text != "" && txtTotalPrice3.Text != "0")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice3.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice3.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory3.SelectedValue + "," +
                                                                                                                                                                              txtProductCode3.Text + "," +
                                                                                                                                                                              txtPieces3.Text + "," +
                                                                                                                                                                              txtCartons3.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces3.Text) + " where Product_ID = " + txtProductCode3.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                    if (txtTotalPrice4.Text != "0" && txtTotalPrice4.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice4.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice4.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory4.SelectedValue + "," +
                                                                                                                                                                              txtProductCode4.Text + "," +
                                                                                                                                                                              txtPieces4.Text + "," +
                                                                                                                                                                              txtCartons4.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces4.Text) + " where Product_ID = " + txtProductCode4.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice5.Text != "0" && txtTotalPrice5.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice5.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice5.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory5.SelectedValue + "," +
                                                                                                                                                                              txtProductCode5.Text + "," +
                                                                                                                                                                              txtPieces5.Text + "," +
                                                                                                                                                                              txtCartons5.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces5.Text) + " where Product_ID = " + txtProductCode5.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice6.Text != "0" && txtTotalPrice6.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice6.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice6.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory6.SelectedValue + "," +
                                                                                                                                                                              txtProductCode6.Text + "," +
                                                                                                                                                                              txtPieces6.Text + "," +
                                                                                                                                                                              txtCartons6.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces6.Text) + " where Product_ID = " + txtProductCode6.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice7.Text != "0" && txtTotalPrice7.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice7.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice7.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory7.SelectedValue + "," +
                                                                                                                                                                              txtProductCode7.Text + "," +
                                                                                                                                                                              txtPieces7.Text + "," +
                                                                                                                                                                              txtCartons7.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces7.Text) + " where Product_ID = " + txtProductCode7.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice8.Text != "0" && txtTotalPrice8.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice8.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice8.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory8.SelectedValue + "," +
                                                                                                                                                                              txtProductCode8.Text + "," +
                                                                                                                                                                              txtPieces8.Text + "," +
                                                                                                                                                                              txtCartons8.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces8.Text) + " where Product_ID = " + txtProductCode8.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice9.Text != "0" && txtTotalPrice9.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice9.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice9.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory9.SelectedValue + "," +
                                                                                                                                                                              txtProductCode9.Text + "," +
                                                                                                                                                                              txtPieces9.Text + "," +
                                                                                                                                                                              txtCartons9.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces9.Text) + " where Product_ID = " + txtProductCode9.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice10.Text != "0" && txtTotalPrice10.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice10.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice10.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory10.SelectedValue + "," +
                                                                                                                                                                              txtProductCode10.Text + "," +
                                                                                                                                                                              txtPieces10.Text + "," +
                                                                                                                                                                              txtCartons10.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces10.Text) + " where Product_ID = " + txtProductCode10.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice11.Text != "0" && txtTotalPrice11.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice11.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice11.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory11.SelectedValue + "," +
                                                                                                                                                                              txtProductCode11.Text + "," +
                                                                                                                                                                              txtPieces11.Text + "," +
                                                                                                                                                                              txtCartons11.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces11.Text) + " where Product_ID = " + txtProductCode11.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    if (txtTotalPrice12.Text != "0" && txtTotalPrice12.Text != "")
                    {
                        Double Dis = (Convert.ToDouble(txtTotalPrice12.Text) * Convert.ToDouble(txtDis.Text) / 100);
                        string totalAmount = (Convert.ToDouble(txtTotalPrice12.Text) - Dis).ToString();
                        String InsertQuery = "Insert into Sales (Booker_ID, Area_ID, Shop_ID, Category_ID, Product_ID, Qty_Pcs, Cartons, Discount, Total_Amount, Date) values (" + txtBookerID.Text + "," +
                                                                                                                                                                              txtAreaID.Text + "," +
                                                                                                                                                                              txtShopID.Text + "," +
                                                                                                                                                                              cmbCategory12.SelectedValue + "," +
                                                                                                                                                                              txtProductCode12.Text + "," +
                                                                                                                                                                              txtPieces12.Text + "," +
                                                                                                                                                                              txtCartons12.Text + "," +
                                                                                                                                                                              txtDis.Text + "," +
                                                                                                                                                                              totalAmount + ",'" +
                                                                                                                                                                              TodayDate.GUID() + "')";
                        String updateQuery = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtPieces12.Text) + " where Product_ID = " + txtProductCode12.Text;
                        SqlCommand cmd = new SqlCommand(InsertQuery + updateQuery, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Sales successfuly inserted.");
                    refresh();
                    SalesView();
                }
                else
                {
                    MessageBox.Show("Please select Booker or Area.");


                }
                
                
            }
            catch
            {
                MessageBox.Show("Please restart.");
            }
        }
        public void SalesView()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Sale_ID, b.Name as Booker, a.Area_Name as Area, s.Name as Shop, c.Category_Name as Category, "+
                                                    "p.Product_Name as Product, Qty_PCS, Cartons, Discount, Total_Amount, Date "+
                                                    "from sales sa " +
                                                    "join Booker b on b.Booker_ID = sa.Booker_ID " +
                                                    "join Area a on a.Area_ID = sa.Area_ID " +
                                                    "join Shops s on s.Shop_ID = sa.Shop_ID " +
                                                    "join Category c on c.Category_ID = sa.Category_ID " +
                                                    "join Products p on p.Product_ID = sa.Product_ID " +
                                                    "where b.Booker_ID = " + txtBookerID.Text + " and date = '" + TodayDate.GUID() + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gvSales.DataSource = dt;
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

            txtTotalAmount.Text = "";
            txtTotalCartons.Text = "";
            txtDis.Text = "0";
            txtTAAD.Text = "";
        }


        private void txtQuantity12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity11_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtQuantity13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        String ID;
        string discount;
        String Product;
        private void gvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = gvSales.Rows[e.RowIndex].Cells[0].Value.ToString();
            String Category = gvSales.Rows[e.RowIndex].Cells[4].Value.ToString();
            Product = gvSales.Rows[e.RowIndex].Cells[5].Value.ToString();
           // String ProductCode  = gvSales.Rows[e.RowIndex].Cells[6].Value.ToString();
            String Quantity = gvSales.Rows[e.RowIndex].Cells[6].Value.ToString();
          //  String QtyINCN = gvSales.Rows[e.RowIndex].Cells[7].Value.ToString();
            String Carton = gvSales.Rows[e.RowIndex].Cells[7].Value.ToString();
           // String CostPrice = gvSales.Rows[e.RowIndex].Cells[9].Value.ToString();
            discount = gvSales.Rows[e.RowIndex].Cells[8].Value.ToString();
            String TotalAmount = gvSales.Rows[e.RowIndex].Cells[9].Value.ToString();


            cmbCategory13.Text = Category;
            cmbProductName13.Text = Product;
            txtQuantity13.Text = Quantity;
            //txtQtyPCS.Text = qtyInPiece;
            //txtTotal.Text = totalPrice;
            //txtCostPrice.Text = costPrice;
            //   txtDiscount.Text = discount;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (ID != null)
                {

                    String updateQuery = "update inventory " +
                                          "set Quantity = Quantity + (select Qty_Pcs from Sales where Sale_ID = " + ID + ")" +
                                          "where Product_ID = (select Product_ID from Sales where Sale_ID = " + ID + ")";

                    SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                    con.Open();
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();

                    String DeleteQuery = "Delete from Sales where Sale_ID = " + ID;
                    SqlCommand cmdDelete = new SqlCommand(DeleteQuery, con);
                    con.Open();
                    cmdDelete.ExecuteNonQuery();
                    con.Close();
                    SalesView();
                    MessageBox.Show("Sale has successfully removed.");

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalPrice13.Text != "" && txtTotalPrice13.Text != "" && ID != null)
                {
                    if (Product == txtProductCode13.Text)
                    {
                        String updateQuery = "update inventory " +
                                              "set Quantity = Quantity + (select Qty_Pcs from Sales where Sale_ID = " + ID + ") - " + Convert.ToInt32(txtQuantity13.Text) +
                                              " where Product_ID = (select Product_ID from Sales where Sale_ID = " + ID + ")";

                        String updateSaleQuery = "update sales " +
                                                   "set Category_ID = " + cmbCategory13.SelectedValue + ", Product_ID =  " + txtProductCode13.Text + ", Qty_Pcs =  " + txtQuantity13.Text + ", Cartons = "
                                                   + txtCartons13.Text + " , Total_Amount = " + Convert.ToDouble(txtTotalPrice13.Text) + " - " + (Convert.ToDouble(txtTotalPrice13.Text) * Convert.ToDouble(discount) / 100)
                                                   + " where Sale_ID = " + ID;
                        SqlCommand cmdUpdate = new SqlCommand(updateQuery + updateSaleQuery, con);
                        con.Open();
                        cmdUpdate.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sale has successfully updated.");
                        SalesView();
                        cmbCategory13.SelectedValue = 0;
                        cmbProductName13.SelectedValue = 0;
                        txtProductCode13.Text = "";
                        txtQuantity13.Text = "";
                        txtCartons13.Text = "";
                        txtCostPrice13.Text = "";
                        txtQtyInCN13.Text = "";
                        txtTotalPrice13.Text = "";
                    }
                    else if (Product != txtProductCode13.Text)
                    {
                        String updateQuery1 = "update inventory " +
                                              "set Quantity = Quantity + (select Qty_Pcs from Sales where Sale_ID = " + ID + ")" +
                                              " where Product_ID = (select Product_ID from Sales where Sale_ID = " + ID + ")";
                        String updateQuery2 = "update Inventory set Quantity = Quantity - " + Convert.ToInt32(txtQuantity13.Text) + " where Product_ID = " + txtProductCode13.Text;
                        String updateSaleQuery = "update sales " +
                                                   "set Category_ID = " + cmbCategory13.SelectedValue + ", Product_ID =  " + txtProductCode13.Text + ", Qty_Pcs =  " + txtQuantity13.Text + ", Cartons = "
                                                   + txtCartons13.Text + " , Total_Amount = " + Convert.ToDouble(txtTotalPrice13.Text) + " - " + (Convert.ToDouble(txtTotalPrice13.Text) * Convert.ToDouble(discount) / 100)
                                                   + " where Sale_ID = " + ID;
                        SqlCommand cmdUpdate = new SqlCommand(updateQuery1 + updateQuery2 + updateSaleQuery, con);
                        con.Open();
                        cmdUpdate.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sale has successfully updated.");
                        SalesView();
                        cmbCategory13.SelectedValue = 0;
                        cmbProductName13.SelectedValue = 0;
                        txtProductCode13.Text = "";
                        txtQuantity13.Text = "";
                        txtCartons13.Text = "";
                        txtCostPrice13.Text = "";
                        txtQtyInCN13.Text = "";
                        txtTotalPrice13.Text = "";
                    }
                }
                else if(ID == null)
                {
                    MessageBox.Show("Please select Sale_ID");
                }
            }
            catch
            {
                MessageBox.Show("Please restart software.");
            }
        }

        private void stmPurchase_Click(object sender, EventArgs e)
        {
            frmPurchase p = new frmPurchase();
            p.Show();
            this.Close();
        }

        private void stmSaleReturn_Click(object sender, EventArgs e)
        {
            frmSaleReturn sr = new frmSaleReturn();
            sr.Show();
            this.Close();
        }
    }
}
