using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shakeel_Brothers
{

    public partial class Cashier : Form
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmbdl;

        Class1 c = new Class1();

        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            //string q1 = "select Cashier as 'User',Password ,Role  from tblCashier";
            //dataGridView1.DataSource = c.GetData(q1);

            con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-76GEPIK; user id=sa;password=a123456;Initial Catalog=shakeel_brothers";
            con.Open();
            adap = new SqlDataAdapter("select Cashier as 'User',Password ,Role  from tblCashier",con);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Person_Details");
            dataGridView1.DataSource=ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

            cmbdl = new SqlCommandBuilder(adap);
            adap.Update(ds, "Person_Details");

        }
    }
}
