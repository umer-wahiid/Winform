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
        DataSet rd;

        Class1 c = new Class1();

        public void showgrid()
        {
            dataGridView1.DataSource = c.GetData("select tblArea.ID, tblArea.Area ,tblArea.UArea as 'علاقہ' ,tblCity.City,tblCity.UCity as 'شہر' from tblArea INNER JOIN tblCity ON tblArea.CityId = tblCity.ID");
            //dataGridView1.DataSource = c.GetData("select tblArea.ID, tblArea.Area ,tblArea.UArea as 'علاقہ' ,tblCity.City,tblCity.UCity as 'شہر' from tblArea INNER JOIN tblCity ON tblArea.City = tblCity.ID");
        }
        public void getitems()
        {
            SqlCommand cmd = new SqlCommand("select * from tblCity", c.con);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string cities = dr.GetString(1);
                txtCity.Items.Add(cities);
            }
            c.con.Close();
        }
        public void clr()
        {
            txtId.Text = "";
            txtArea.Text = "";
            txtUarea.Text = "";
            txtCity.Text = "";
        }
        public Area()
        {
            InitializeComponent();
        }

        private void Area_Load(object sender, EventArgs e)
        {
            //adap = new SqlDataAdapter("select ID ,Area ,UArea as 'علاقہ' ,City , UCity as 'شہر' from tblArea", c.con);
            //adap = new SqlDataAdapter("select tblArea.ID, tblArea.Area ,tblArea.UArea,tblArea.CityId,tblCity.City from tblArea INNER JOIN tblCity ON tblArea.CityId = tblCity.ID", c.con);
            //dt = new DataTable();
            //adap.Fill(dt);
            //dataGridView1.DataSource = dt;
            showgrid();
            getitems();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtArea.Text != "" && txtUarea.Text != "" && txtCity.Text != "" && txtId.Text == "")
            {
                SqlCommand cmd = new SqlCommand("insert into tblArea(Area,UArea,CityId)values(@r,@p,@c)", c.con);
                //SqlCommand cm = new SqlCommand("select ID from tblCity where City = '" + txtCity + "'", c.con);
                //adap = new SqlDataAdapter("select ID from tblCity where City = '" + txtCity + "'", c.con);
                //dt = new DataTable();
                //adap.Fill(dt);
                //dataGridView1.DataSource = dt;
                //int id = Convert.ToInt32(rd);

                cmd.Parameters.AddWithValue("@r", txtArea.Text);
                cmd.Parameters.AddWithValue("@p", txtUarea.Text);
                cmd.Parameters.AddWithValue("@c", Convert.ToInt32(DataTransfer.c));
                c.IUD(cmd);
                clr();
                showgrid();
                txtArea.Focus();
            }
            else
            {
                MessageBox.Show("Please Insert Data to Save !!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtArea.Text != "" && txtUarea.Text != "" && txtCity.Text != "" && txtId.Text == "" && txtId.Text!="")
            {
                SqlCommand cmd = new SqlCommand("update tblArea set Area=@r ,UArea=@p,CityId=@c where ID=@i", c.con);
                SqlCommand cm = new SqlCommand("select ID from tblCity where City = '"+txtCity+"'", c.con);
                cmd.Parameters.AddWithValue("@i", txtId.Text);
                cmd.Parameters.AddWithValue("@r", txtArea.Text);
                cmd.Parameters.AddWithValue("@p", txtUarea.Text);
                cmd.Parameters.AddWithValue("@c", DataTransfer.c);
                c.IUD(cmd);
                clr();
                showgrid();
                txtArea.Focus();
            }
            else
            {
                MessageBox.Show("Please Insert Data to Update !!");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.GetData("select * from tblArea Where Area like '" + txtSearch.Text + "'+'%'");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("select ID from tblCity where City = '" + txtCity + "'", c.con);
            DataTransfer.c = cm.ToString();
        }

        private void Area_FormClosing(object sender, FormClosingEventArgs e)
        {
            //SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            //adap.Update(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommandBuilder cmbdl = new SqlCommandBuilder(adap);
            //adap.Update(dt);
            //this.Close();
        }

    }
}
