namespace WindowsFormsApp1
{
    partial class Form1
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
            this.hoten = new System.Windows.Forms.Label();
            this.dienthoai = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.dsmathang = new System.Windows.Forms.Label();
            this.hangdatmua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tindung = new System.Windows.Forms.RadioButton();
            this.sec = new System.Windows.Forms.RadioButton();
            this.tienmat = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.CheckBox();
            this.fax = new System.Windows.Forms.CheckBox();
            this.dthoat = new System.Windows.Forms.CheckBox();
            this.dongy = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(70, 27);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(49, 16);
            this.hoten.TabIndex = 0;
            this.hoten.Text = "Họ tên:";
            // 
            // dienthoai
            // 
            this.dienthoai.AutoSize = true;
            this.dienthoai.Location = new System.Drawing.Point(405, 27);
            this.dienthoai.Name = "dienthoai";
            this.dienthoai.Size = new System.Drawing.Size(69, 16);
            this.dienthoai.TabIndex = 1;
            this.dienthoai.Text = "Điện thoại:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 22);
            this.textBox2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(73, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 116);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(436, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(301, 116);
            this.listBox2.TabIndex = 5;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // dsmathang
            // 
            this.dsmathang.AutoSize = true;
            this.dsmathang.Location = new System.Drawing.Point(70, 78);
            this.dsmathang.Name = "dsmathang";
            this.dsmathang.Size = new System.Drawing.Size(154, 16);
            this.dsmathang.TabIndex = 6;
            this.dsmathang.Text = "Danh sách các mặt hàng";
            // 
            // hangdatmua
            // 
            this.hangdatmua.AutoSize = true;
            this.hangdatmua.Location = new System.Drawing.Point(433, 78);
            this.hangdatmua.Name = "hangdatmua";
            this.hangdatmua.Size = new System.Drawing.Size(91, 16);
            this.hangdatmua.TabIndex = 7;
            this.hangdatmua.Text = "Hàng đặt mua";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tindung);
            this.groupBox1.Controls.Add(this.sec);
            this.groupBox1.Controls.Add(this.tienmat);
            this.groupBox1.Location = new System.Drawing.Point(73, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // tindung
            // 
            this.tindung.AutoSize = true;
            this.tindung.Location = new System.Drawing.Point(37, 74);
            this.tindung.Name = "tindung";
            this.tindung.Size = new System.Drawing.Size(101, 20);
            this.tindung.TabIndex = 13;
            this.tindung.TabStop = true;
            this.tindung.Text = "Thẻ tín dụng";
            this.tindung.UseVisualStyleBackColor = true;
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Location = new System.Drawing.Point(37, 47);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(52, 20);
            this.sec.TabIndex = 12;
            this.sec.TabStop = true;
            this.sec.Text = "Sec";
            this.sec.UseVisualStyleBackColor = true;
            // 
            // tienmat
            // 
            this.tienmat.AutoSize = true;
            this.tienmat.Location = new System.Drawing.Point(37, 21);
            this.tienmat.Name = "tienmat";
            this.tienmat.Size = new System.Drawing.Size(80, 20);
            this.tienmat.TabIndex = 11;
            this.tienmat.TabStop = true;
            this.tienmat.Text = "Tiền mặt";
            this.tienmat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.email);
            this.groupBox2.Controls.Add(this.fax);
            this.groupBox2.Controls.Add(this.dthoat);
            this.groupBox2.Location = new System.Drawing.Point(436, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(41, 74);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(63, 20);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            this.email.UseVisualStyleBackColor = true;
            // 
            // fax
            // 
            this.fax.AutoSize = true;
            this.fax.Location = new System.Drawing.Point(41, 47);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(51, 20);
            this.fax.TabIndex = 1;
            this.fax.Text = "Fax";
            this.fax.UseVisualStyleBackColor = true;
            // 
            // dthoat
            // 
            this.dthoat.AutoSize = true;
            this.dthoat.Location = new System.Drawing.Point(41, 22);
            this.dthoat.Name = "dthoat";
            this.dthoat.Size = new System.Drawing.Size(88, 20);
            this.dthoat.TabIndex = 0;
            this.dthoat.Text = "Điện thoại";
            this.dthoat.UseVisualStyleBackColor = true;
            // 
            // dongy
            // 
            this.dongy.Location = new System.Drawing.Point(219, 397);
            this.dongy.Name = "dongy";
            this.dongy.Size = new System.Drawing.Size(75, 23);
            this.dongy.TabIndex = 0;
            this.dongy.Text = "Đồng ý";
            this.dongy.UseVisualStyleBackColor = true;
            this.dongy.Click += new System.EventHandler(this.dongy_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(408, 397);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 10;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.dongy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hangdatmua);
            this.Controls.Add(this.dsmathang);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dienthoai);
            this.Controls.Add(this.hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.Label dienthoai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label dsmathang;
        private System.Windows.Forms.Label hangdatmua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tindung;
        private System.Windows.Forms.RadioButton sec;
        private System.Windows.Forms.RadioButton tienmat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dongy;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.CheckBox email;
        private System.Windows.Forms.CheckBox fax;
        private System.Windows.Forms.CheckBox dthoat;
    }
}

