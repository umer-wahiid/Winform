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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Manage
            // 
            this.Manage.BackColor = System.Drawing.Color.White;
            this.Manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage.Location = new System.Drawing.Point(41, 43);
            this.Manage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(107, 37);
            this.Manage.TabIndex = 0;
            this.Manage.Text = "Manage";
            this.Manage.UseVisualStyleBackColor = false;
            // 
            // users
            // 
            this.users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Location = new System.Drawing.Point(38, 100);
            this.users.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(112, 36);
            this.users.TabIndex = 1;
            this.users.Text = "users";
            this.users.UseVisualStyleBackColor = true;
            // 
            // Transport
            // 
            this.Transport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transport.Location = new System.Drawing.Point(38, 141);
            this.Transport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(112, 36);
            this.Transport.TabIndex = 2;
            this.Transport.Text = "Transport";
            this.Transport.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            this.Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.Location = new System.Drawing.Point(39, 182);
            this.Item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(112, 36);
            this.Item.TabIndex = 3;
            this.Item.Text = "Item";
            this.Item.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            this.Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.Location = new System.Drawing.Point(39, 223);
            this.Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(112, 36);
            this.Customer.TabIndex = 4;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Area.Location = new System.Drawing.Point(38, 264);
            this.Area.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(112, 36);
            this.Area.TabIndex = 5;
            this.Area.Text = "Area";
            this.Area.UseVisualStyleBackColor = true;
            this.Area.Click += new System.EventHandler(this.Area_Click);
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.Location = new System.Drawing.Point(38, 305);
            this.City.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(112, 36);
            this.City.TabIndex = 6;
            this.City.Text = "City";
            this.City.UseVisualStyleBackColor = true;
            // 
            // CusPrint
            // 
            this.CusPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusPrint.Location = new System.Drawing.Point(39, 346);
            this.CusPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CusPrint.Name = "CusPrint";
            this.CusPrint.Size = new System.Drawing.Size(112, 82);
            this.CusPrint.TabIndex = 7;
            this.CusPrint.Text = "Customer Print";
            this.CusPrint.UseVisualStyleBackColor = true;
            // 
            // CreateBill
            // 
            this.CreateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CreateBill.Location = new System.Drawing.Point(172, 78);
            this.CreateBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateBill.Name = "CreateBill";
            this.CreateBill.Size = new System.Drawing.Size(143, 146);
            this.CreateBill.TabIndex = 8;
            this.CreateBill.Text = "Create Bill";
            this.CreateBill.UseVisualStyleBackColor = true;
            // 
            // Payments
            // 
            this.Payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Payments.Location = new System.Drawing.Point(172, 245);
            this.Payments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(143, 74);
            this.Payments.TabIndex = 9;
            this.Payments.Text = "Payments";
            this.Payments.UseVisualStyleBackColor = true;
            // 
            // DelEntryView
            // 
            this.DelEntryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.DelEntryView.Location = new System.Drawing.Point(176, 335);
            this.DelEntryView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelEntryView.Name = "DelEntryView";
            this.DelEntryView.Size = new System.Drawing.Size(133, 30);
            this.DelEntryView.TabIndex = 10;
            this.DelEntryView.Text = "Delete Entry View";
            this.DelEntryView.UseVisualStyleBackColor = true;
            // 
            // DelEntry
            // 
            this.DelEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEntry.Location = new System.Drawing.Point(192, 377);
            this.DelEntry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelEntry.Name = "DelEntry";
            this.DelEntry.Size = new System.Drawing.Size(99, 30);
            this.DelEntry.TabIndex = 11;
            this.DelEntry.Text = "Delete Entry";
            this.DelEntry.UseVisualStyleBackColor = true;
            // 
            // OldRate
            // 
            this.OldRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldRate.Location = new System.Drawing.Point(192, 419);
            this.OldRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OldRate.Name = "OldRate";
            this.OldRate.Size = new System.Drawing.Size(99, 30);
            this.OldRate.TabIndex = 12;
            this.OldRate.Text = "Old Rates";
            this.OldRate.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(345, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(236, 331);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // BillByCust
            // 
            this.BillByCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillByCust.Location = new System.Drawing.Point(55, 237);
            this.BillByCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillByCust.Name = "BillByCust";
            this.BillByCust.Size = new System.Drawing.Size(119, 71);
            this.BillByCust.TabIndex = 8;
            this.BillByCust.Text = "Bill By Customer";
            this.BillByCust.UseVisualStyleBackColor = true;
            this.BillByCust.Click += new System.EventHandler(this.button2_Click);
            // 
            // BillByNo
            // 
            this.BillByNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillByNo.Location = new System.Drawing.Point(55, 190);
            this.BillByNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillByNo.Name = "BillByNo";
            this.BillByNo.Size = new System.Drawing.Size(119, 32);
            this.BillByNo.TabIndex = 7;
            this.BillByNo.Text = "Bill By OR.No";
            this.BillByNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Or.No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 151);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BillByDate
            // 
            this.BillByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillByDate.Location = new System.Drawing.Point(55, 104);
            this.BillByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BillByDate.Name = "BillByDate";
            this.BillByDate.Size = new System.Drawing.Size(119, 32);
            this.BillByDate.TabIndex = 4;
            this.BillByDate.Text = "Bill By Date";
            this.BillByDate.UseVisualStyleBackColor = true;
            this.BillByDate.Click += new System.EventHandler(this.BillByDate_Click);
            // 
            // DoO
            // 
            this.DoO.AutoSize = true;
            this.DoO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.DoO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DoO.Location = new System.Drawing.Point(33, 72);
            this.DoO.Name = "DoO";
            this.DoO.Size = new System.Drawing.Size(44, 20);
            this.DoO.TabIndex = 3;
            this.DoO.Text = "DoO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EditPurBill
            // 
            this.EditPurBill.BackColor = System.Drawing.Color.White;
            this.EditPurBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPurBill.Location = new System.Drawing.Point(19, 21);
            this.EditPurBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditPurBill.Name = "EditPurBill";
            this.EditPurBill.Size = new System.Drawing.Size(198, 42);
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
            this.groupBox2.Location = new System.Drawing.Point(617, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 342);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.White;
            this.Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactions.Location = new System.Drawing.Point(89, 21);
            this.Transactions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(198, 42);
            this.Transactions.TabIndex = 2;
            this.Transactions.Text = "Transactions";
            this.Transactions.UseVisualStyleBackColor = false;
            // 
            // TrailBalance
            // 
            this.TrailBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrailBalance.Location = new System.Drawing.Point(79, 79);
            this.TrailBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrailBalance.Name = "TrailBalance";
            this.TrailBalance.Size = new System.Drawing.Size(218, 41);
            this.TrailBalance.TabIndex = 5;
            this.TrailBalance.Text = "Trail Balance";
            this.TrailBalance.UseVisualStyleBackColor = true;
            // 
            // LedgerBtwDates
            // 
            this.LedgerBtwDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LedgerBtwDates.Location = new System.Drawing.Point(163, 138);
            this.LedgerBtwDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LedgerBtwDates.Name = "LedgerBtwDates";
            this.LedgerBtwDates.Size = new System.Drawing.Size(216, 41);
            this.LedgerBtwDates.TabIndex = 6;
            this.LedgerBtwDates.Text = "Ledger B/W Dates";
            this.LedgerBtwDates.UseVisualStyleBackColor = true;
            // 
            // CusLedger
            // 
            this.CusLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusLedger.Location = new System.Drawing.Point(6, 138);
            this.CusLedger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CusLedger.Name = "CusLedger";
            this.CusLedger.Size = new System.Drawing.Size(147, 41);
            this.CusLedger.TabIndex = 7;
            this.CusLedger.Text = "Customer\'s Ledger";
            this.CusLedger.UseVisualStyleBackColor = true;
            // 
            // PayByCus
            // 
            this.PayByCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayByCus.Location = new System.Drawing.Point(63, 193);
            this.PayByCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PayByCus.Name = "PayByCus";
            this.PayByCus.Size = new System.Drawing.Size(265, 46);
            this.PayByCus.TabIndex = 8;
            this.PayByCus.Text = "Payment Details By Customer/Date";
            this.PayByCus.UseVisualStyleBackColor = true;
            // 
            // CustomerDropdown
            // 
            this.CustomerDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerDropdown.FormattingEnabled = true;
            this.CustomerDropdown.IntegralHeight = false;
            this.CustomerDropdown.ItemHeight = 22;
            this.CustomerDropdown.Location = new System.Drawing.Point(63, 261);
            this.CustomerDropdown.Name = "CustomerDropdown";
            this.CustomerDropdown.Size = new System.Drawing.Size(265, 30);
            this.CustomerDropdown.TabIndex = 9;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1767, 750);
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
    }
}

