using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkberAli
{
    class DataAdaptionCategory
    {
        public static void BindCombo(ComboBox cmbCtr1,
                                       String TableName,
                                       String DisplayMember,
                                       String ValueMember,
                                       String WhereFilter)

        {
            string query = "Select * from " + TableName;

            if (WhereFilter != "")
            {
                query += " Where " + ValueMember + " = " + WhereFilter;
            }

            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9N1O4RV\SQLEXPRESS;Initial Catalog=dbAkber;Integrated Security=True");
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=dbAkber;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataRow row = dt.NewRow();
            row[DisplayMember] = "Please Select";
            row[ValueMember] = 0;
            dt.Rows.InsertAt(row, 0);
            cmbCtr1.DisplayMember = DisplayMember;
            cmbCtr1.ValueMember = ValueMember;
            cmbCtr1.DataSource = dt;


        }
    }
}
