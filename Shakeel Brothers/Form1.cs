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
    public partial class Startup : Form
    {
        Class1 c = new Class1();
        public void getCus()
        {
            SqlCommand cmd = new SqlCommand("select Supplier from tblSupplier", c.con);
            c.con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string customer = dr.GetString(0);
                coll.Add(customer);
                CustomerDropdown.Items.Add(customer);
            }
            CustomerDropdown.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CustomerDropdown.AutoCompleteMode = AutoCompleteMode.Append;
            CustomerDropdown.AutoCompleteCustomSource = coll;
            c.con.Close();
        }
        
        public void getitems()
        {
            SqlCommand cmd = new SqlCommand("select RawName from tblRawMaterial", c.con);
            c.con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string customer = dr.GetString(0);
                coll.Add(customer);
                ItemsDropdown.Items.Add(customer);
            }
            ItemsDropdown.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ItemsDropdown.AutoCompleteMode = AutoCompleteMode.Append;
            ItemsDropdown.AutoCompleteCustomSource = coll;
            c.con.Close();
        }
        
        public void getCities()
        {
            SqlCommand cmd = new SqlCommand("select City from tblCity", c.con);
            c.con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string customer = dr.GetString(0);
                coll.Add(customer);
                CityDropdown.Items.Add(customer);
            }
            CityDropdown.AutoCompleteSource = AutoCompleteSource.CustomSource;
            CityDropdown.AutoCompleteMode = AutoCompleteMode.Append;
            CityDropdown.AutoCompleteCustomSource = coll;
            c.con.Close();
        }
        public Startup()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DataTransfer.role != "admin")
            {
                users.Hide();
            }

            getitems();
            getCus();
            getCities();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BillByDate_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customer a = new Customer();
            a.Show();
        }

        private void Area_Click(object sender, EventArgs e)
        {
            Area a = new Area();
            a.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void users_Click(object sender, EventArgs e)
        {
            Cashier s = new Cashier();
            s.Show();
        }

        private void City_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.Show();
        }

        private void CusPrint_Click(object sender, EventArgs e)
        {

        }

        private void CreateBill_Click(object sender, EventArgs e)
        {
            crtBill c = new crtBill();
            c.Show();
        }

        private void Payments_Click(object sender, EventArgs e)
        {

        }

        private void DelEntryView_Click(object sender, EventArgs e)
        {

        }

        private void DelEntry_Click(object sender, EventArgs e)
        {

        }

        private void OldRate_Click(object sender, EventArgs e)
        {

        }

        private void BillByNo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transport_Click(object sender, EventArgs e)
        {
            Transport t = new Transport();
            t.Show();
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Item t = new Item();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login c = new Login();
            c.Close();
            this.Close();
        }
    }
}
