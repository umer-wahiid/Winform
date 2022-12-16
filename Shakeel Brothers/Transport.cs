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
        SqlConnection con = new SqlConnection("Data Source=IMRAN; user id=sa;password=a123456;Initial Catalog=shakeel_brothers");
        SqlDataAdapter adap;
        DataTable dt;
        public Transport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            adap.Update(dt);
            this.Close();
        }

        private void Transport_Load(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("select ID ,Transport,UTransport as 'اردو',TportPh as 'Phone No.'  from tblTransport", con);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
