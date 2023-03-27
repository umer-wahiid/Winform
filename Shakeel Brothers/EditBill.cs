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
    public partial class EditBill : Form
    {
        Class1 c = new Class1();
        public void showgrid()
        {
            dataGridView1.DataSource = c.GetData("select tblTransDetails.TID as 'ID',tblTransDetails.DDate as 'Date',tblTransDetails.RawMaterial as 'آٰیٹم کانام'," +
                "tblTransDetails.Nag,tblRawMaterial.Packing as 'پیکنگ',tblTransDetails.Qty as 'مقدار',tblTransDetails.Rate as 'ریٹ',tblTransDetails.Bilty," +
                "tblTransDetails.Transport as 'ٹرانسپورٹ',tblTransDetails.Labour as 'مزدوری',tblTransDetails.Bardan as 'باردان',tblTransDetails.Total as 'رقم'" +
                " from tblTransDetails  INNER JOIN tblSupplier ON tblTransactions.Supplier = tblSupplier.Id where tblTransactions.Supplier = " + DataTransfer.cusId + "  AND tblTransactions.Debit != '' ");
        }

        public EditBill()
        {
            InitializeComponent();
        }

        private void EditBill_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

=======
>>>>>>> parent of c5cc5c9 (Edit Bill In Progress)
        }
    }
}
