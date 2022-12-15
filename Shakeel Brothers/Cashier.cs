using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shakeel_Brothers
{

    public partial class Cashier : Form
    {
        Class1 c = new Class1();

        public Cashier()
        {
            InitializeComponent();
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            string q1 = "select Cashier as 'User',Password ,Role  from tblCashier";
            dataGridView1.DataSource = c.GetData(q1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
