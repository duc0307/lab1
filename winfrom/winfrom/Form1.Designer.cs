namespace winfrom
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
            this.ttkh = new System.Windows.Forms.GroupBox();
            this.themmoi = new System.Windows.Forms.Button();
            this.themvao = new System.Windows.Forms.Button();
            this.loaitk = new System.Windows.Forms.GroupBox();
            this.phatloc = new System.Windows.Forms.RadioButton();
            this.thuong = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ngaygui = new System.Windows.Forms.DateTimePicker();
            this.tenkh = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.sotiengui = new System.Windows.Forms.TextBox();
            this.makh = new System.Windows.Forms.TextBox();
            this.tthoigiangui = new System.Windows.Forms.Label();
            this.ngayguii = new System.Windows.Forms.Label();
            this.stien = new System.Windows.Forms.Label();
            this.diac = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.ma = new System.Windows.Forms.Label();
            this.dskh = new System.Windows.Forms.GroupBox();
            this.listDS = new System.Windows.Forms.ListBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.ttkh.SuspendLayout();
            this.loaitk.SuspendLayout();
            this.dskh.SuspendLayout();
            this.SuspendLayout();
            // 
            // ttkh
            // 
            this.ttkh.Controls.Add(this.themmoi);
            this.ttkh.Controls.Add(this.themvao);
            this.ttkh.Controls.Add(this.loaitk);
            this.ttkh.Controls.Add(this.comboBox1);
            this.ttkh.Controls.Add(this.ngaygui);
            this.ttkh.Controls.Add(this.tenkh);
            this.ttkh.Controls.Add(this.diachi);
            this.ttkh.Controls.Add(this.sotiengui);
            this.ttkh.Controls.Add(this.makh);
            this.ttkh.Controls.Add(this.tthoigiangui);
            this.ttkh.Controls.Add(this.ngayguii);
            this.ttkh.Controls.Add(this.stien);
            this.ttkh.Controls.Add(this.diac);
            this.ttkh.Controls.Add(this.name);
            this.ttkh.Controls.Add(this.ma);
            this.ttkh.Location = new System.Drawing.Point(21, 12);
            this.ttkh.Name = "ttkh";
            this.ttkh.Size = new System.Drawing.Size(333, 373);
            this.ttkh.TabIndex = 0;
            this.ttkh.TabStop = false;
            this.ttkh.Text = "Nhâp thông tin khách hàng";
            // 
            // themmoi
            // 
            this.themmoi.Location = new System.Drawing.Point(171, 344);
            this.themmoi.Name = "themmoi";
            this.themmoi.Size = new System.Drawing.Size(84, 23);
            this.themmoi.TabIndex = 15;
            this.themmoi.Text = "Thêm mới";
            this.themmoi.UseVisualStyleBackColor = true;
            this.themmoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // themvao
            // 
            this.themvao.Location = new System.Drawing.Point(15, 344);
            this.themvao.Name = "themvao";
            this.themvao.Size = new System.Drawing.Size(81, 23);
            this.themvao.TabIndex = 14;
            this.themvao.Text = "Thêm vào";
            this.themvao.UseVisualStyleBackColor = true;
            this.themvao.Click += new System.EventHandler(this.button1_Click);
            // 
            // loaitk
            // 
            this.loaitk.Controls.Add(this.phatloc);
            this.loaitk.Controls.Add(this.thuong);
            this.loaitk.Location = new System.Drawing.Point(15, 267);
            this.loaitk.Name = "loaitk";
            this.loaitk.Size = new System.Drawing.Size(287, 57);
            this.loaitk.TabIndex = 13;
            this.loaitk.TabStop = false;
            this.loaitk.Text = "Loại tiết kiệm";
            // 
            // phatloc
            // 
            this.phatloc.AutoSize = true;
            this.phatloc.Location = new System.Drawing.Point(156, 18);
            this.phatloc.Name = "phatloc";
            this.phatloc.Size = new System.Drawing.Size(76, 20);
            this.phatloc.TabIndex = 1;
            this.phatloc.TabStop = true;
            this.phatloc.Text = "Phát lộc";
            this.phatloc.UseVisualStyleBackColor = true;
            // 
            // thuong
            // 
            this.thuong.AutoSize = true;
            this.thuong.Location = new System.Drawing.Point(3, 18);
            this.thuong.Name = "thuong";
            this.thuong.Size = new System.Drawing.Size(74, 20);
            this.thuong.TabIndex = 0;
            this.thuong.TabStop = true;
            this.thuong.Text = "Thưởng";
            this.thuong.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(107, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ngaygui
            // 
            this.ngaygui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaygui.Location = new System.Drawing.Point(107, 186);
            this.ngaygui.Name = "ngaygui";
            this.ngaygui.Size = new System.Drawing.Size(100, 22);
            this.ngaygui.TabIndex = 11;
            // 
            // tenkh
            // 
            this.tenkh.Location = new System.Drawing.Point(107, 53);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(100, 22);
            this.tenkh.TabIndex = 10;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(107, 90);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(100, 22);
            this.diachi.TabIndex = 9;
            // 
            // sotiengui
            // 
            this.sotiengui.Location = new System.Drawing.Point(107, 134);
            this.sotiengui.Name = "sotiengui";
            this.sotiengui.Size = new System.Drawing.Size(100, 22);
            this.sotiengui.TabIndex = 8;
            this.sotiengui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // makh
            // 
            this.makh.Location = new System.Drawing.Point(107, 15);
            this.makh.Name = "makh";
            this.makh.Size = new System.Drawing.Size(100, 22);
            this.makh.TabIndex = 6;
            this.makh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tthoigiangui
            // 
            this.tthoigiangui.AutoSize = true;
            this.tthoigiangui.Location = new System.Drawing.Point(12, 231);
            this.tthoigiangui.Name = "tthoigiangui";
            this.tthoigiangui.Size = new System.Drawing.Size(84, 16);
            this.tthoigiangui.TabIndex = 5;
            this.tthoigiangui.Text = "Thời gian gửi";
            // 
            // ngayguii
            // 
            this.ngayguii.AutoSize = true;
            this.ngayguii.Location = new System.Drawing.Point(12, 186);
            this.ngayguii.Name = "ngayguii";
            this.ngayguii.Size = new System.Drawing.Size(61, 16);
            this.ngayguii.TabIndex = 4;
            this.ngayguii.Text = "Ngày gửi";
            // 
            // stien
            // 
            this.stien.AutoSize = true;
            this.stien.Location = new System.Drawing.Point(12, 137);
            this.stien.Name = "stien";
            this.stien.Size = new System.Drawing.Size(69, 16);
            this.stien.TabIndex = 3;
            this.stien.Text = "Số tiền gửi";
            this.stien.Click += new System.EventHandler(this.stien_Click);
            // 
            // diac
            // 
            this.diac.AutoSize = true;
            this.diac.Location = new System.Drawing.Point(12, 90);
            this.diac.Name = "diac";
            this.diac.Size = new System.Drawing.Size(47, 16);
            this.diac.TabIndex = 2;
            this.diac.Text = "Địa chỉ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(12, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(52, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Tên KH";
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.Location = new System.Drawing.Point(12, 18);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(47, 16);
            this.ma.TabIndex = 0;
            this.ma.Text = "Mã KH";
            // 
            // dskh
            // 
            this.dskh.Controls.Add(this.listDS);
            this.dskh.Location = new System.Drawing.Point(417, 12);
            this.dskh.Name = "dskh";
            this.dskh.Size = new System.Drawing.Size(285, 312);
            this.dskh.TabIndex = 1;
            this.dskh.TabStop = false;
            this.dskh.Text = "Danh sách khách hàng";
            // 
            // listDS
            // 
            this.listDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDS.FormattingEnabled = true;
            this.listDS.ItemHeight = 16;
            this.listDS.Location = new System.Drawing.Point(3, 18);
            this.listDS.Name = "listDS";
            this.listDS.Size = new System.Drawing.Size(279, 291);
            this.listDS.TabIndex = 0;
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(431, 344);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(87, 23);
            this.timkiem.TabIndex = 2;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.button3_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(602, 344);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "Thoát";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.dskh);
            this.Controls.Add(this.ttkh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ttkh.ResumeLayout(false);
            this.ttkh.PerformLayout();
            this.loaitk.ResumeLayout(false);
            this.loaitk.PerformLayout();
            this.dskh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ttkh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker ngaygui;
        private System.Windows.Forms.TextBox tenkh;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox sotiengui;
        private System.Windows.Forms.TextBox makh;
        private System.Windows.Forms.Label tthoigiangui;
        private System.Windows.Forms.Label ngayguii;
        private System.Windows.Forms.Label stien;
        private System.Windows.Forms.Label diac;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.Button themmoi;
        private System.Windows.Forms.Button themvao;
        private System.Windows.Forms.GroupBox loaitk;
        private System.Windows.Forms.RadioButton phatloc;
        private System.Windows.Forms.RadioButton thuong;
        private System.Windows.Forms.GroupBox dskh;
        private System.Windows.Forms.ListBox listDS;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button xoa;
    }
}

