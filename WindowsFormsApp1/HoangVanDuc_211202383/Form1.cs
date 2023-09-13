using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addData();
        }
        private void addData()
        {
            listBox1.Items.Add("Kĩ thuật lập trình C#");
            listBox1.Items.Add("Tự học Visual C# trong 21 ngày");
            listBox1.Items.Add("Bài tập C#");
            listBox1.Items.Add(".NET toàn tập - tập 1");
            listBox1.Items.Add(".NET toàn tập - tập 2");
            listBox1.Items.Add(".NET toàn tập - tập 3");
            listBox1.Items.Add(".NET toàn tập - tập 4");
            listBox1.Items.Add("Tin học cơ bản");
            listBox1.Items.Add("SQL server");
            listBox1.Items.Add("Cơ bản về XML");
            listBox1.Items.Add("Phân tích thiết kế hệ thống");
            listBox1.Items.Add("Sử dụng Word");
            listBox1.Items.Add("Đến với Word 2003");

        }

     
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           String curItems = listBox1.SelectedItem.ToString();
            int index = listBox2.FindString(curItems);
            if(index == -1)
            {
                listBox2.Items.Add(curItems);
            }
            else
            {
                MessageBox.Show("Hàng đã mua rồi");
            }    
              
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox2.SelectedIndex;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                listBox2.Items.RemoveAt(index);
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thoát", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void dongy_Click(object sender, EventArgs e)
        {
            string sb = "";
            if (hoten.Text.Equals("") || dienthoai.Text.Equals(""))
            {
                MessageBox.Show("Nhập đủ thông tin","Thông báo");
                hoten.Focus();
            }
            else
            {
                
                foreach(object item in listBox2.Items) { 
                    sb+= item.ToString();
                    sb += ("\n");
                }
                sb += hoten.Text + " " + dienthoai.Text + " " + hthucll() + " " + pthuctt();

            }
            MessageBox.Show(sb);
            
        }
        private String hthucll()
        {
            string a = "";
            if (dthoat.Checked == true)
            {
                a += dthoat.Text;
            }
            if(fax.Checked == true)
            {
                a += fax.Text;
            }
            if(email.Checked == true)
            {
                a+=email.Text;
            }
            return a;
        }
        private String pthuctt()
        {
            string b = "";
            if(tienmat.Checked == true)
            {
                b += tienmat.Text;
            }
            if(sec.Checked == true) { 
            b += sec.Text;
            }
            if(tindung.Checked == true)
            {
                b+=tindung.Text;
            }
            return b;
        }
    }
      
    
}
