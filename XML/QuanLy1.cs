using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML.ktx;
using XML.xuly;

namespace XML
{
    public partial class QuanLy1 : Form
    {
        public QuanLy1()
        {
            InitializeComponent();
        }
        QuanLy QuanLy = new QuanLy();
        QuanLyxuly QuanLyxuly = new QuanLyxuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {

                QuanLy.MaQL1 = txt1.Text;
                QuanLy.HoTen1 = txt2.Text;
                QuanLy.NgaySinh1 = DateTime.Parse(txt3.Text);
                QuanLy.DiaChi1 = txt4.Text; ;
                QuanLy.SDT1 = txt5.Text;
                QuanLyxuly.Them(QuanLy);
                QuanLyxuly.hienthi(dataGridView2);
            }
        }

        private void QuanLy1_Load(object sender, EventArgs e)
        {
            QuanLyxuly.hienthi(dataGridView2);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            QuanLy.MaQL1 = txt1.Text;
            QuanLyxuly.xoa(QuanLy);
            QuanLyxuly.hienthi(dataGridView2);

        }

        private void btnxua_Click(object sender, EventArgs e)
        {
            QuanLy.MaQL1 = txt1.Text;
            QuanLy.HoTen1 = txt2.Text;
            QuanLy.NgaySinh1 = DateTime.Parse(txt3.Text);
            QuanLy.DiaChi1 = txt4.Text; ;
            QuanLy.SDT1 = txt5.Text;
            QuanLyxuly.sua(QuanLy);
            QuanLyxuly.hienthi(dataGridView2);

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            QuanLy.MaQL1 = txt1.Text;
            QuanLyxuly.timkiem(QuanLy, dataGridView2);
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            QuanLyxuly.hienthi(dataGridView2);
        }
    }
}

