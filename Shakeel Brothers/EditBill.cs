﻿using System;
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
    public partial class EditBill : Form
    {
        Class1 c = new Class1();

        public void getitems()
        {
            SqlCommand cmd = new SqlCommand("select RawName from tblRawMaterial", c.con);
            c.con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string items = dr.GetString(0);
                coll.Add(items);
                txtItem.Items.Add(items);
            }
            txtItem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtItem.AutoCompleteMode = AutoCompleteMode.Append;
            txtItem.AutoCompleteCustomSource = coll;
            c.con.Close();
        }
        public void gettrans()
        {
            SqlCommand cmd = new SqlCommand("select Transport from tblTransport", c.con);
            c.con.Open();
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string items = dr.GetString(0);
                coll.Add(items);
                txtTransport.Items.Add(items);
            }
            txtTransport.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTransport.AutoCompleteMode = AutoCompleteMode.Append;
            txtTransport.AutoCompleteCustomSource = coll;
            c.con.Close();
        }


        public void showgrid()
        {
            dataGridView1.DataSource = c.GetData("select tblTransDetails.ID as 'ID',tblTransDetails.DDate as 'Date',tblRawMaterial.RawName as 'آٰیٹم کانام', tblTransDetails.Nag, tblRawMaterial.Packing as 'پیکنگ', tblTransDetails.Qty as 'مقدار', tblTransDetails.Rate as 'ریٹ', tblTransDetails.Bilty, tblTransDetails.Transport as 'ٹرانسپورٹ', tblTransDetails.Labour as 'مزدوری', tblTransDetails.Bardan as 'باردان', tblTransDetails.Total as 'رقم' from tblTransDetails INNER JOIN tblRawMaterial ON tblTransDetails.RawMaterial = tblRawMaterial.Id where tblTransDetails.TID = " + DataTransfer.BillId + " ");
        }

        public EditBill()
        {
            InitializeComponent();
        }

        private void EditBill_Load(object sender, EventArgs e)
        {
            txtID.Text = DataTransfer.BillId;
            showgrid();
            getitems();
            gettrans();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
