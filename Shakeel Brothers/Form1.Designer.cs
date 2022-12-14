namespace Shakeel_Brothers
{
    partial class Startup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Manage = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Button();
            this.Transport = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Area = new System.Windows.Forms.Button();
            this.City = new System.Windows.Forms.Button();
            this.CusPrint = new System.Windows.Forms.Button();
            this.CreateBill = new System.Windows.Forms.Button();
            this.Payments = new System.Windows.Forms.Button();
            this.DelEntryView = new System.Windows.Forms.Button();
            this.DelEntry = new System.Windows.Forms.Button();
            this.OldRate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BillByCust = new System.Windows.Forms.Button();
            this.BillByNo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BillByDate = new System.Windows.Forms.Button();
            this.DoO = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EditPurBill = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Transactions = new System.Windows.Forms.Button();
            this.TrailBalance = new System.Windows.Forms.Button();
            this.LedgerBtwDates = new System.Windows.Forms.Button();
            this.CusLedger = new System.Windows.Forms.Button();
            this.PayByCus = new System.Windows.Forms.Button();
            this.CustomerDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaleDet = new System.Windows.Forms.Button();
            this.CompLedger = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DetOfItem = new System.Windows.Forms.Button();
            this.SaleSummary = new System.Windows.Forms.Button();
            this.SaleBtwDates = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Manage
            // 
            this.Manage.BackColor = System.Drawing.Color.White;
            this.Manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.Location = new System.Drawing.Point(41, 43);
            this.Manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(117, 37);
            this.Manage.TabIndex = 0;
            this.Manage.Text = "Manage";
            this.Manage.UseVisualStyleBackColor = false;
            // 
            // users
            // 
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.users.Location = new System.Drawing.Point(29, 91);
            this.users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(143, 43);
            this.users.TabIndex = 1;
            this.users.Text = "users";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // Transport
            // 
            this.Transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.Transport.Location = new System.Drawing.Point(29, 141);
            this.Transport.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(143, 43);
            this.Transport.TabIndex = 2;
            this.Transport.Text = "Transport";
            this.Transport.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.Item.Location = new System.Drawing.Point(29, 190);
            this.Item.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(143, 43);
            this.Item.TabIndex = 3;
            this.Item.Text = "Item";
            this.Item.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.Customer.Location = new System.Drawing.Point(29, 240);
            this.Customer.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(143, 43);
            this.Customer.TabIndex = 4;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.Area.Location = new System.Drawing.Point(29, 290);
            this.Area.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(143, 43);
            this.Area.TabIndex = 5;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.City.Location = new System.Drawing.Point(29, 340);
            this.City.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(143, 43);
            this.City.TabIndex = 6;
            this.City.Text = "City";
            this.City.UseVisualStyleBackColor = true;
            this.City.Click += new System.EventHandler(this.City_Click);
            // 
            // CusPrint
            // 
            this.CusPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F);
            this.CusPrint.Location = new System.Drawing.Point(29, 390);
            this.CusPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CusPrint.Name = "CusPrint";
            this.CusPrint.Size = new System.Drawing.Size(143, 82);
            this.CusPrint.TabIndex = 7;
            this.CusPrint.Text = "Customer Print";
            this.CusPrint.UseVisualStyleBackColor = true;
            this.CusPrint.Click += new System.EventHandler(this.CusPrint_Click);
            // 
            // CreateBill
            // 
            this.CreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateBill.Location = new System.Drawing.Point(203, 78);
            this.CreateBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBill.Name = "CreateBill";
            this.CreateBill.Size = new System.Drawing.Size(199, 168);
            this.CreateBill.TabIndex = 8;
            this.CreateBill.Text = "Create Bill";
            this.CreateBill.UseVisualStyleBackColor = true;
            this.CreateBill.Click += new System.EventHandler(this.CreateBill_Click);
            // 
            // Payments
            // 
            this.Payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Payments.Location = new System.Drawing.Point(203, 264);
            this.Payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(199, 99);
            this.Payments.TabIndex = 9;
            this.Payments.Text = "Payments";
            this.Payments.UseVisualStyleBackColor = true;
            this.Payments.Click += new System.EventHandler(this.Payments_Click);
            // 
            // DelEntryView
            // 
            this.DelEntryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DelEntryView.Location = new System.Drawing.Point(215, 380);
            this.DelEntryView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelEntryView.Name = "DelEntryView";
            this.DelEntryView.Size = new System.Drawing.Size(175, 49);
            this.DelEntryView.TabIndex = 10;
            this.DelEntryView.Text = "Delete Entry View";
            this.DelEntryView.UseVisualStyleBackColor = true;
            this.DelEntryView.Click += new System.EventHandler(this.DelEntryView_Click);
            // 
            // DelEntry
            // 
            this.DelEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DelEntry.Location = new System.Drawing.Point(225, 437);
            this.DelEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelEntry.Name = "DelEntry";
            this.DelEntry.Size = new System.Drawing.Size(155, 47);
            this.DelEntry.TabIndex = 11;
            this.DelEntry.Text = "Delete Entry";
            this.DelEntry.UseVisualStyleBackColor = true;
            this.DelEntry.Click += new System.EventHandler(this.DelEntry_Click);
            // 
            // OldRate
            // 
            this.OldRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OldRate.Location = new System.Drawing.Point(225, 501);
            this.OldRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldRate.Name = "OldRate";
            this.OldRate.Size = new System.Drawing.Size(155, 47);
            this.OldRate.TabIndex = 12;
            this.OldRate.Text = "Old Rates";
            this.OldRate.UseVisualStyleBackColor = true;
            this.OldRate.Click += new System.EventHandler(this.OldRate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BillByCust);
            this.groupBox1.Controls.Add(this.BillByNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.BillByDate);
            this.groupBox1.Controls.Add(this.DoO);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.EditPurBill);
            this.groupBox1.Location = new System.Drawing.Point(445, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(269, 371);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // BillByCust
            // 
            this.BillByCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BillByCust.Location = new System.Drawing.Point(54, 273);
            this.BillByCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillByCust.Name = "BillByCust";
            this.BillByCust.Size = new System.Drawing.Size(153, 85);
            this.BillByCust.TabIndex = 8;
            this.BillByCust.Text = "Bill By Customer";
            this.BillByCust.UseVisualStyleBackColor = true;
            this.BillByCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // BillByNo
            // 
            this.BillByNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BillByNo.Location = new System.Drawing.Point(55, 206);
            this.BillByNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillByNo.Name = "BillByNo";
            this.BillByNo.Size = new System.Drawing.Size(151, 44);
            this.BillByNo.TabIndex = 7;
            this.BillByNo.Text = "Bill By OR.No";
            this.BillByNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(22, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ord. No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 178);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BillByDate
            // 
            this.BillByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BillByDate.Location = new System.Drawing.Point(55, 114);
            this.BillByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillByDate.Name = "BillByDate";
            this.BillByDate.Size = new System.Drawing.Size(151, 44);
            this.BillByDate.TabIndex = 4;
            this.BillByDate.Text = "Bill By Date";
            this.BillByDate.UseVisualStyleBackColor = true;
            this.BillByDate.Click += new System.EventHandler(this.BillByDate_Click);
            // 
            // DoO
            // 
            this.DoO.AutoSize = true;
            this.DoO.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.DoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoO.Location = new System.Drawing.Point(22, 86);
            this.DoO.Name = "DoO";
            this.DoO.Size = new System.Drawing.Size(44, 20);
            this.DoO.TabIndex = 3;
            this.DoO.Text = "DoO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditPurBill
            // 
            this.EditPurBill.BackColor = System.Drawing.Color.White;
            this.EditPurBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditPurBill.Location = new System.Drawing.Point(19, 21);
            this.EditPurBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditPurBill.Name = "EditPurBill";
            this.EditPurBill.Size = new System.Drawing.Size(230, 54);
            this.EditPurBill.TabIndex = 1;
            this.EditPurBill.Text = "Edit Purchase Bill";
            this.EditPurBill.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomerDropdown);
            this.groupBox2.Controls.Add(this.PayByCus);
            this.groupBox2.Controls.Add(this.CusLedger);
            this.groupBox2.Controls.Add(this.LedgerBtwDates);
            this.groupBox2.Controls.Add(this.TrailBalance);
            this.groupBox2.Controls.Add(this.Transactions);
            this.groupBox2.Location = new System.Drawing.Point(750, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 357);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.White;
            this.Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Transactions.Location = new System.Drawing.Point(130, 20);
            this.Transactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(206, 44);
            this.Transactions.TabIndex = 2;
            this.Transactions.Text = "Transactions";
            this.Transactions.UseVisualStyleBackColor = false;
            // 
            // TrailBalance
            // 
            this.TrailBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TrailBalance.Location = new System.Drawing.Point(112, 80);
            this.TrailBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrailBalance.Name = "TrailBalance";
            this.TrailBalance.Size = new System.Drawing.Size(239, 48);
            this.TrailBalance.TabIndex = 5;
            this.TrailBalance.Text = "Trail Balance";
            this.TrailBalance.UseVisualStyleBackColor = true;
            // 
            // LedgerBtwDates
            // 
            this.LedgerBtwDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LedgerBtwDates.Location = new System.Drawing.Point(196, 147);
            this.LedgerBtwDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LedgerBtwDates.Name = "LedgerBtwDates";
            this.LedgerBtwDates.Size = new System.Drawing.Size(244, 48);
            this.LedgerBtwDates.TabIndex = 6;
            this.LedgerBtwDates.Text = "Ledger B/W Dates";
            this.LedgerBtwDates.UseVisualStyleBackColor = true;
            // 
            // CusLedger
            // 
            this.CusLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CusLedger.Location = new System.Drawing.Point(9, 147);
            this.CusLedger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CusLedger.Name = "CusLedger";
            this.CusLedger.Size = new System.Drawing.Size(181, 48);
            this.CusLedger.TabIndex = 7;
            this.CusLedger.Text = "Customer\'s Ledger";
            this.CusLedger.UseVisualStyleBackColor = true;
            // 
            // PayByCus
            // 
            this.PayByCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PayByCus.Location = new System.Drawing.Point(88, 215);
            this.PayByCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PayByCus.Name = "PayByCus";
            this.PayByCus.Size = new System.Drawing.Size(286, 53);
            this.PayByCus.TabIndex = 8;
            this.PayByCus.Text = "Payment Details By Customer/Date";
            this.PayByCus.UseVisualStyleBackColor = true;
            // 
            // CustomerDropdown
            // 
            this.CustomerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDropdown.FormattingEnabled = true;
            this.CustomerDropdown.IntegralHeight = false;
            this.CustomerDropdown.ItemHeight = 25;
            this.CustomerDropdown.Items.AddRange(new object[] {
            "Yousuf Ayub",
            "Faizullah",
            "Asim Pan Masala",
            "Noor & Co.",
            "Zahoor & Co."});
            this.CustomerDropdown.Location = new System.Drawing.Point(98, 294);
            this.CustomerDropdown.Name = "CustomerDropdown";
            this.CustomerDropdown.Size = new System.Drawing.Size(265, 33);
            this.CustomerDropdown.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaleBtwDates);
            this.groupBox3.Controls.Add(this.SaleSummary);
            this.groupBox3.Controls.Add(this.DetOfItem);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.CompLedger);
            this.groupBox3.Controls.Add(this.SaleDet);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(595, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 333);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(319, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 89);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(134, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 27);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "11/11/2022";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ledger From";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(134, 51);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 27);
            this.textBox4.TabIndex = 2;
            this.textBox4.Text = "12/12/2022";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ledger Till";
            // 
            // SaleDet
            // 
            this.SaleDet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaleDet.Location = new System.Drawing.Point(365, 121);
            this.SaleDet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaleDet.Name = "SaleDet";
            this.SaleDet.Size = new System.Drawing.Size(208, 78);
            this.SaleDet.TabIndex = 10;
            this.SaleDet.Text = "Sale Detail Of Customer";
            this.SaleDet.UseVisualStyleBackColor = true;
            // 
            // CompLedger
            // 
            this.CompLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CompLedger.Location = new System.Drawing.Point(394, 218);
            this.CompLedger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompLedger.Name = "CompLedger";
            this.CompLedger.Size = new System.Drawing.Size(136, 49);
            this.CompLedger.TabIndex = 11;
            this.CompLedger.Text = "Complete Ledger";
            this.CompLedger.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 20;
            this.comboBox1.Location = new System.Drawing.Point(117, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 28);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.3F);
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label4.Size = new System.Drawing.Size(95, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item Name";
            // 
            // DetOfItem
            // 
            this.DetOfItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DetOfItem.Location = new System.Drawing.Point(58, 85);
            this.DetOfItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetOfItem.Name = "DetOfItem";
            this.DetOfItem.Size = new System.Drawing.Size(208, 71);
            this.DetOfItem.TabIndex = 14;
            this.DetOfItem.Text = "Sale Detail Of Item/Date";
            this.DetOfItem.UseVisualStyleBackColor = true;
            // 
            // SaleSummary
            // 
            this.SaleSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaleSummary.Location = new System.Drawing.Point(58, 161);
            this.SaleSummary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaleSummary.Name = "SaleSummary";
            this.SaleSummary.Size = new System.Drawing.Size(208, 73);
            this.SaleSummary.TabIndex = 15;
            this.SaleSummary.Text = "Sale Summary B/W Dates";
            this.SaleSummary.UseVisualStyleBackColor = true;
            // 
            // SaleBtwDates
            // 
            this.SaleBtwDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SaleBtwDates.Location = new System.Drawing.Point(58, 238);
            this.SaleBtwDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaleBtwDates.Name = "SaleBtwDates";
            this.SaleBtwDates.Size = new System.Drawing.Size(208, 72);
            this.SaleBtwDates.TabIndex = 16;
            this.SaleBtwDates.Text = "Sale B/W Dates";
            this.SaleBtwDates.UseVisualStyleBackColor = true;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 752);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OldRate);
            this.Controls.Add(this.DelEntry);
            this.Controls.Add(this.DelEntryView);
            this.Controls.Add(this.Payments);
            this.Controls.Add(this.CreateBill);
            this.Controls.Add(this.CusPrint);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.users);
            this.Controls.Add(this.Manage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Manage;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button Transport;
        private System.Windows.Forms.Button Item;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Area;
        private System.Windows.Forms.Button City;
        private System.Windows.Forms.Button CusPrint;
        private System.Windows.Forms.Button CreateBill;
        private System.Windows.Forms.Button Payments;
        private System.Windows.Forms.Button DelEntryView;
        private System.Windows.Forms.Button DelEntry;
        private System.Windows.Forms.Button OldRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BillByDate;
        private System.Windows.Forms.Label DoO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button EditPurBill;
        private System.Windows.Forms.Button BillByCust;
        private System.Windows.Forms.Button BillByNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CusLedger;
        private System.Windows.Forms.Button LedgerBtwDates;
        private System.Windows.Forms.Button TrailBalance;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button PayByCus;
        private System.Windows.Forms.ComboBox CustomerDropdown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CompLedger;
        private System.Windows.Forms.Button SaleDet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaleBtwDates;
        private System.Windows.Forms.Button SaleSummary;
        private System.Windows.Forms.Button DetOfItem;
    }
}

