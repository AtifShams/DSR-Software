using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkberAli
{
    public partial class frmlogin : Form
    {
       //  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
       // SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True; MultipleActiveResultSets=True");
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True; MultipleActiveResultSets=True");

        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

                if (cmbUserTypes.Text == "Distributor")
            {

                frmSales kpo = new frmSales();
                kpo.Show();
            }
            else if (cmbUserTypes.Text == "AkberAli")
            {
                frmDashboard dd = new frmDashboard();
                dd.Show();
            }
            DateTime d = DateTime.Now;
             
            String DateQuery = "select max(date) as date from Report ";
            SqlCommand cmd = new SqlCommand(DateQuery, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                string date = dr["date"].ToString();
                
                if (date != "")
                {
                    String OnlyDate = date.Remove(9);
                    String TodayDatetime = d.Date.ToString();
                    String DateToday = TodayDatetime.Remove(9);
                    String YesterdayDate = d.Date.AddDays(-1).ToString().Remove(9);

                    if (DateToday != OnlyDate)
                    {
                        String InsertQuery = "insert into report (Opening_Inventory, date) " +
                            " values ( (select Sum(i.Quantity * p.Rate_Box) as Inventory from Inventory i " +
                            "join Products p on p.Product_ID = i.Product_ID),'" + TodayDate.GUID() + "')";

                        

                        SqlCommand cmdInsert = new SqlCommand(InsertQuery , con);

                        con.Open();
                        cmdInsert.ExecuteNonQuery();
                        con.Close();

                        String updateQuery = "update report set " +
                                             " sales = (select sum(s.Qty_Pcs*p.Rate_Box) from sales s "+ 
                                             " join products p on p.product_ID = s.product_ID "+
                                             " where date = '" + YesterdayDate + "'), " +
                                             " Sales_Return = (select sum(sr.Qty_Pcs*p.Rate_Box) from salesReturn sr " +
                                             " join products p on p.product_ID = sr.product_ID " +
                                             " where date = '" + YesterdayDate + "'), " +
                                             " Purchases = (select sum(total_amount) from Purchases where date = '" + YesterdayDate + "'), " +
                                             " Purchases_Return = (select sum(total_amount) from PurchaseReturn where date = '" + YesterdayDate + "'), " +
                                             " Closing_Inventory = (select Sum(i.Quantity * p.Rate_Box) as Inventory from Inventory i " +
                                             " join Products p on p.Product_ID = i.Product_ID ) " +
                                             " Where date = '" + YesterdayDate + "'";

                        SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);

                        con.Open();
                        cmdUpdate.ExecuteNonQuery();
                        con.Close();


                    }
                }
                else if(date == "")
                {
                    String InsertQuery = "insert into report (Opening_Inventory, date) " +
                            " values ( (select Sum(i.Quantity * p.Rate_Box) as Inventory from Inventory i " +
                            "join Products p on p.Product_ID = i.Product_ID),'" + TodayDate.GUID() + "')";

                    SqlCommand cmdInsert = new SqlCommand(InsertQuery, con);

                    con.Open();
                    cmdInsert.ExecuteNonQuery();
                    con.Close();
                }
                
                
            }
            conn.Close();

        }

        
    }
}
