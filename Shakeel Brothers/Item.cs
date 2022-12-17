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
    public partial class Item : Form
    {
        SqlDataAdapter adap;
        DataTable dt;

        Class1 c = new Class1();
        public Item()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Item_Load(object sender, EventArgs e)
        {
            

            adap = new SqlDataAdapter("select ID ,RawName as 'Items',Packing,URawName as 'آئٹم کا نام',UPacking as 'پیکنگ',PQty as 'پیک مقدار',Measure as 'پیمانہ', PRate as 'پیک ریٹ'  from tblRawMaterial", c.con);
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
