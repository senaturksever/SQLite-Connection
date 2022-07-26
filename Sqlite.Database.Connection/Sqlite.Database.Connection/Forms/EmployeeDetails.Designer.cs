namespace Sqlite.Database.Connection.Forms
{
    partial class EmployeeDetails
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_birth = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_state = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_postalcode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hdate);
            this.groupBox1.Controls.Add(this.txt_birth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_lastname);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.txt_firstname);
            this.groupBox1.Controls.Add(this.lblUnvan);
            this.groupBox1.Location = new System.Drawing.Point(-4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdCustomers);
            this.groupBox2.Location = new System.Drawing.Point(364, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(827, 662);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteriler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_address);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_state);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_city);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_country);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(-4, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adres Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_update);
            this.groupBox4.Controls.Add(this.txt_email);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_fax);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txt_phone);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txt_postalcode);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(-4, 435);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 220);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İletişim Bilgileri";
            // 
            // grdCustomers
            // 
            this.grdCustomers.AllowUserToAddRows = false;
            this.grdCustomers.AllowUserToDeleteRows = false;
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCustomers.Location = new System.Drawing.Point(3, 18);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.ReadOnly = true;
            this.grdCustomers.RowHeadersWidth = 51;
            this.grdCustomers.RowTemplate.Height = 24;
            this.grdCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCustomers.Size = new System.Drawing.Size(821, 641);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCustomers_CellDoubleClick);
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(6, 36);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(46, 16);
            this.lblUnvan.TabIndex = 1;
            this.lblUnvan.Text = "Ünvan";
            this.lblUnvan.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(94, 61);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(262, 22);
            this.txt_firstname.TabIndex = 2;
            this.txt_firstname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(94, 89);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(262, 22);
            this.txt_lastname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim";
            this.label2.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_birth
            // 
            this.txt_birth.Location = new System.Drawing.Point(94, 117);
            this.txt_birth.Name = "txt_birth";
            this.txt_birth.Size = new System.Drawing.Size(262, 22);
            this.txt_birth.TabIndex = 2;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(94, 33);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(262, 22);
            this.txt_title.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyisim";
            this.label3.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Doğum Günü";
            this.label4.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "İşe Alım ";
            this.label5.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_hdate
            // 
            this.txt_hdate.Location = new System.Drawing.Point(94, 145);
            this.txt_hdate.Name = "txt_hdate";
            this.txt_hdate.Size = new System.Drawing.Size(262, 22);
            this.txt_hdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ülke";
            this.label1.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_country
            // 
            this.txt_country.Location = new System.Drawing.Point(93, 21);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(262, 22);
            this.txt_country.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şehir";
            this.label6.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(93, 49);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(262, 22);
            this.txt_city.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Eyalet";
            this.label7.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_state
            // 
            this.txt_state.Location = new System.Drawing.Point(93, 77);
            this.txt_state.Name = "txt_state";
            this.txt_state.Size = new System.Drawing.Size(262, 22);
            this.txt_state.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Adres";
            this.label8.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(93, 108);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(262, 72);
            this.txt_address.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Posta Kodu";
            this.label9.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_postalcode
            // 
            this.txt_postalcode.Location = new System.Drawing.Point(93, 30);
            this.txt_postalcode.Name = "txt_postalcode";
            this.txt_postalcode.Size = new System.Drawing.Size(262, 22);
            this.txt_postalcode.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Telefon";
            this.label10.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(93, 58);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(262, 22);
            this.txt_phone.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Fax";
            this.label11.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(93, 86);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(262, 22);
            this.txt_fax.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Email";
            this.label12.Click += new System.EventHandler(this.lblUnvan_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(93, 114);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(262, 22);
            this.txt_email.TabIndex = 2;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(93, 157);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(268, 39);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 665);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Detay Bilgisi";
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdCustomers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox txt_hdate;
        private System.Windows.Forms.TextBox txt_birth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_postalcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_update;
    }
}