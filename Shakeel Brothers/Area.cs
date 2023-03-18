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
            //adap = new SqlDataAdapter("select ID ,Area ,UArea as 'علاقہ' ,City , UCity as 'شہر' from tblArea", c.con);
            adap = new SqlDataAdapter("select tblArea.ID, tblArea.Area ,tblArea.UArea,tblArea.CityId,tblCity.City from tblArea INNER JOIN tblCity ON tblArea.CityId = tblCity.ID", c.con);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            adap = new SqlDataAdapter("select tblArea.ID,tblArea.Area ,tblArea.UArea,tblCity.City from tblArea INNER JOIN tblCity ON tblArea.City = tblCity.ID Where tblArea.Area like '" + txtSearch.Text + "'+'%'", c.con);
            dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Area_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            //adap.Update(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            adap.Update(dt);
            this.Close();
        }
    }
}
