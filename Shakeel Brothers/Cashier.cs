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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-76GEPIK; user id=sa;password=a123456;Initial Catalog=shakeel_brothers");
        SqlDataAdapter adap;
        DataTable dt;

        //Class1 c = new Class1();

        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            //string q1 = "select Cashier as 'User',Password ,Role  from tblCashier";
            //dataGridView1.DataSource = c.GetData(q1);

            adap = new SqlDataAdapter("select ID ,Cashier as 'User',Password ,Role  from tblCashier",con);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            adap.Update(dt);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
