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

        public void showgrid()
        {
            dataGridView1.DataSource = c.GetData("select ID ,Transport,UTransport as 'اردو',[Tport Ph] as 'Phone No.'  from tblTransport");
        }
        public void clr()
        {
            txtId.Text = "";
            txtCashier.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }


        public Transport()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Transport_Load(object sender, EventArgs e)
        {
            showgrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
