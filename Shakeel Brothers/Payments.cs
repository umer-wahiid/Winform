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
    public partial class Payments : Form
    {

        Class1 c = new Class1();
        public void showgrid()
        {
            dataGridView1.DataSource = c.GetData("select tblTransactions.TID as 'ID',tblTransactions.TDate as 'Date',tblSupplier.Supplier,tblTransactions.Debit,tblTransactions.Description from tblTransactions where tblTransactions.Supplier = 2 INNER JOIN tblSupplier ON tblTransactions.TID = tblSupplier.Id");
        }
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            showgrid();
        }
    }
}
