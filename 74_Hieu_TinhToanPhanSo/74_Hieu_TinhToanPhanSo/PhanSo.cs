using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74_Hieu_TinhToanPhanSo
{
    public class PhanSo
    {
        private int tu_74_Hieu, mau_74_Hieu;
        public PhanSo()
        {
            tu_74_Hieu = 0;
            mau_74_Hieu = 1;
        }
        public PhanSo(int t, int m)
        {
            tu_74_Hieu = t;
            mau_74_Hieu = m;
        }

        public int getTu()
        {
            return tu_74_Hieu;
        }

        public void setTu(int tu)
        {
            this.tu_74_Hieu = tu;
        }

        public int getMau()
        {
            return mau_74_Hieu;
        }

        public void setMau(int mau)
        {
            this.mau_74_Hieu = mau;
        }
    
        private int UCLN(int a, int b)
        {
            while (a != b)
                if (a > b) a = a - b;
                else b = b - a;
            return a;
        }
        public void rutGon()
        {
            if (tu_74_Hieu * mau_74_Hieu != 0)
            {
                int uoc = UCLN(Math.Abs(tu_74_Hieu), Math.Abs(mau_74_Hieu));
                tu_74_Hieu /= uoc;
                mau_74_Hieu /= uoc;
            }
        }
        public PhanSo cong(PhanSo b)
        {
            PhanSo c = new PhanSo();
            int kiemTraChiaCho0 = this.tu_74_Hieu / this.mau_74_Hieu;
            kiemTraChiaCho0 = b.tu_74_Hieu / b.mau_74_Hieu;
            //mục đích để kiểm tra có xuất hiện DivideByZeroException hay ko
            c.tu_74_Hieu = this.tu_74_Hieu * b.mau_74_Hieu + this.mau_74_Hieu * b.tu_74_Hieu;
            c.mau_74_Hieu = this.mau_74_Hieu * b.mau_74_Hieu;
            c.rutGon();
            return c;
        }
        public String toString()
        {
            if(this.tu_74_Hieu == 0)
            {
                return "0";
            }
            if(this.mau_74_Hieu == 1)
            {
                return this.tu_74_Hieu.ToString();
            }
            return this.tu_74_Hieu + "/" + this.mau_74_Hieu;
        }
    }
}
