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
    public partial class SinhVien1 : Form
    {
        public SinhVien1()
        {
            InitializeComponent();
        }
        SinhVien SinhVienn = new SinhVien();
        SinhVienxuly SinhVienxyly = new SinhVienxuly();

        private void SinhVien_Load(object sender, EventArgs e)
        {
            SinhVienxyly.hienthi(dataGridView1);
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            SinhVienxyly.hienthi(dataGridView1);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txt1.Text.Trim() != "")
            {

                SinhVienn.MSSV1 = int.Parse(txt1.Text);
                SinhVienn.HoTen1 = txt2.Text;
                SinhVienn.NgaySinh1 = DateTime.Parse(txt3.Text);
                SinhVienn.GioiTinh1 = txt4.Text; 
                SinhVienn.CMND1 = int.Parse(txt5.Text);
                SinhVienn.SDT1 = int.Parse(txt6.Text);
                SinhVienn.Lop1 = txt7.Text;
                SinhVienn.DiaChi1 = txt8.Text;
                SinhVienxyly.Them(SinhVienn);
                SinhVienxyly.hienthi(dataGridView1);


            }
        }

        private void btnxua_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {

                SinhVienn.MSSV1 = int.Parse(txt1.Text);
                SinhVienn.HoTen1 = txt2.Text;
                SinhVienn.NgaySinh1 = DateTime.Parse(txt3.Text);
                SinhVienn.GioiTinh1 = txt4.Text; 
                SinhVienn.CMND1 = int.Parse(txt5.Text);
                SinhVienn.SDT1 = int.Parse(txt6.Text);
                SinhVienn.Lop1 = txt7.Text;
                SinhVienn.DiaChi1 = txt8.Text;
                SinhVienxyly.sua(SinhVienn);
                SinhVienxyly.hienthi(dataGridView1);


            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SinhVienn.MSSV1 = int.Parse(txt1.Text);
            SinhVienxyly.xoa(SinhVienn);
            SinhVienxyly.hienthi(dataGridView1);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            SinhVienn.MSSV1 = int.Parse(txt1.Text);
            SinhVienxyly.timkiem(SinhVienn,dataGridView1);
        }
    }
}
