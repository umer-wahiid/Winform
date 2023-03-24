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
    public partial class Payments : Form
    {

        Class1 c = new Class1();

        public void txtid()
        {
            SqlCommand cmd = new SqlCommand("select Top 1 TID from tblTransactions ORDER BY TID DESC", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                int ids = dr.GetInt32(0);
                c.con.Close();
                txtID.Text += ids + 1;
            }
            else
            {
                int ids = 0;
                c.con.Close();
                txtID.Text += ids + 1;
            }
        }

        public void clr()
        {
            txtID.Text = "";
            txtid();
            txtDate.Text = "";
            txtAmount.Text = "";
            txtAcc.Text = "";
        }


        public void getAcc()
        {
            SqlCommand cmd = new SqlCommand("select Description from tblTransactions", c.con);
            c.con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string acc = dr.GetString(0);
                coll.Add(acc);
                txtAcc.Items.Add(acc);
            }
            txtAcc.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtAcc.AutoCompleteMode = AutoCompleteMode.Append;
            txtAcc.AutoCompleteCustomSource = coll;
            c.con.Close();
        }


        public void showgrid()
        {
            dataGridView1.DataSource = c.GetData("select tblTransactions.TID as 'ID',tblTransactions.TDate as 'Date',tblSupplier.Supplier,tblTransactions.Debit,tblTransactions.Description from tblTransactions  INNER JOIN tblSupplier ON tblTransactions.Supplier = tblSupplier.Id where tblTransactions.Supplier = " + DataTransfer.cusId + "  AND tblTransactions.Debit != '' ");
        }















        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            showgrid();
            txtid();
            getAcc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDate.Text != "" && txtAmount.Text != "" && txtAcc.Text != "")
            {
                SqlCommand cmd = new SqlCommand("insert into tblTransactions(TID,TDate,Supplier,Debit,Description)values(@tid,@d," + DataTransfer.cusId + ",@db,@ds)", c.con);
                cmd.Parameters.AddWithValue("@tid", txtID.Text);
                cmd.Parameters.AddWithValue("@d", txtDate.Text);
                cmd.Parameters.AddWithValue("@db", txtAmount.Text);
                cmd.Parameters.AddWithValue("@ds", txtAcc.Text);
                c.IUD(cmd);
                clr();
                showgrid();
                getAcc();
                txtDate.Focus();
            }
            else
            {
                MessageBox.Show("Please Insert Data to Save !!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
