﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            SqlCommand cmd = new SqlCommand("Select * from tblCashier where Cashier=@c and Password=@p",c.con);
            cmd.Parameters.AddWithValue("@c",textBox1.Text);
            cmd.Parameters.AddWithValue("@p", textBox2.Text);
            c.con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Startup s = new Startup();
                s.Show();
                this.Hide();
            }
        }
    }
}
