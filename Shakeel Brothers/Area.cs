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
    public partial class Area : Form
    {

        SqlDataAdapter adap;
        DataTable dt;

        Class1 c = new Class1();
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("select ID ,Area ,UArea as 'علاقہ' ,City , UCity as 'شہر' from tblArea", c.con);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Saveexit_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            adap.Update(dt);
            this.Close();
        }
    }
}
