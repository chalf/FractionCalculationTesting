using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _74_Hieu_TinhToanPhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTong_Click(object sender, EventArgs e)
        {
            int tu1_74_Hieu, mau1_74_Hieu;
            tu1_74_Hieu = int.Parse(tuSo1_74_Hieu.Text);
            mau1_74_Hieu = int.Parse(mauSo1_74_Hieu.Text);
            PhanSo phanSo1_74 = new PhanSo(tu1_74_Hieu, mau1_74_Hieu);

            int tu2_74_Hieu, mau2_74_Hieu;
            tu2_74_Hieu = int.Parse(tuSo2_74_Hieu.Text);
            mau2_74_Hieu = int.Parse(mauSo2_74_Hieu.Text);
            PhanSo phanSo2_74 = new PhanSo(tu2_74_Hieu, mau2_74_Hieu);

            PhanSo kq_74_Hieu = phanSo1_74.cong(phanSo2_74);
            ketQua_74_Hieu.Text = kq_74_Hieu.toString();
        }
    }
}
