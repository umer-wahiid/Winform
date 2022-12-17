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

namespace Shakeel_Brothers
{
    public partial class Transport : Form
    {
        Class1 c = new Class1();

        SqlDataAdapter adap;
        DataTable dt;
        public Transport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Transport_Load(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("select ID ,Transport,UTransport as 'اردو',TportPh as 'Phone No.'  from tblTransport", c.con);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            adap.Update(dt);
            this.Close();
        }

    }
}
