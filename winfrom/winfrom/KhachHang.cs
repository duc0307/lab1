using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winfrom
{
    internal class KhachHang
    {
        string ma, ten, dc;
        double tien;
        int tgg;
        bool hinhthuc;
        DateTime ngaygui;

        public KhachHang()
        {
            hinhthuc = true;
        }
        public String Ten { get => ten; }
        public String Ma { get => ma; }
        public double Tinhtien()
        {
            double tl=0, s = 0;
            if (tgg == 1)
            {
                tl = 0.06;
            }
            if (tgg == 3)
            {
                tl = 0.07;
            }
            if (tgg == 6)
            {
                tl = 0.08;
            }
            if (tgg == 12)
            {
                tl = 0.09;
            }
            if (hinhthuc == false)
            { 
                tl += 0.01;
                s = tien * (1 + tien * tl * tgg / 12);

            }
            
               
                return s;
             
                
        }
        public void Timkiem()
        {
            string s="";
            if(s == ma)
            {

            }
        }
        public override string ToString()
        {
           string s= ma+ " "+ten+" "+dc+" "+ " "+tien.ToString()+" "+tgg.ToString()+"Thang";
            if (hinhthuc == true)
            {
                s += "loai thuong";
            }
            if(hinhthuc == false)
            {
                s += "loaiphatloc";
            }
            return s + ngaygui.ToString()+ "tong tien"+ Tinhtien().ToString();
        }
        public KhachHang(string ma, string ten, string dc, double tien, int tgg, bool hinhthuc, DateTime ngaygui)
        {
            this.ma = ma;
            this.ten = ten;
            this.dc = dc;
            this.tien = tien;
            this.tgg = tgg;
            this.hinhthuc = hinhthuc;
            this.ngaygui = ngaygui;
        }
    }

}
