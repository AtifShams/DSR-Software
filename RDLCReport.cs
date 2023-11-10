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
    public partial class frmRDLCReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");

        public frmRDLCReport()
        {
            InitializeComponent();
        }

        private void RDLCReport_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dbAkberDataSet.Booker' table. You can move, or remove it, as needed.
            this.bookerTableAdapter.Fill(this.dbAkberDataSet.Booker);
            // TODO: This line of code loads data into the 'dbAkberDataSet.Booker' table. You can move, or remove it, as needed.
            this.bookerTableAdapter.Fill(this.dbAkberDataSet.Booker);

            


            //this.rvSales.RefreshReport();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
            this.dbAkberDataSet.EnforceConstraints = false;
             this.DataTable1TableAdapter.Fill(this.dbAkberDataSet.DataTable1, Convert.ToInt16(cmbBooker.SelectedValue), datetime.Text);
            this.rvSales.RefreshReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
