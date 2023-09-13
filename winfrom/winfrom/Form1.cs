using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winfrom
{
    public partial class Form1 : Form
    {
        List<KhachHang> ds =new List<KhachHang> ();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban muon thoat", "thoat", MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes) this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("12");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))

            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            makh.Text = "";
            tenkh.Text = "";
            sotiengui.Text = "";
            diachi.Text = "";
            thuong.Checked = false;
            phatloc.Checked = false;
            comboBox1.SelectedIndex = -1;
            ngaygui.Value = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtra() == true)
            {
                string ma = makh.Text;
                string ten = tenkh.Text;
                string dc = diachi.Text;
                double tien = double.Parse(sotiengui.Text);
                int tgg = int.Parse(comboBox1.SelectedIndex.ToString());
                DateTime ngayguitien = ngaygui.Value;
                bool hinhthuc = true;
                if (phatloc.Checked == true)
                {
                    hinhthuc = false;
                }
                if (thuong.Checked == true)
                {
                    hinhthuc = true;
                }

                KhachHang x = new KhachHang(ma, ten, dc, tien, tgg, hinhthuc, ngayguitien);
                listDS.Items.Add(x.ToString());
                ds.Add(x);
            }
            else MessageBox.Show("Nhập đủ đi");
            
        }
        public bool kiemtra()
        {
            if (makh.Text.Trim().Length != 6 
                || tenkh.Text.Trim() == ""
                || diachi.Text.Trim() == ""
                || sotiengui.Text.Trim() == ""
                || ngaygui.Value.ToString() == ""
                || (phatloc.Checked == false
                && thuong.Checked == false)
                )
                return false;
            return true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void stien_Click(object sender, EventArgs e)
        {

        }
    }
}


