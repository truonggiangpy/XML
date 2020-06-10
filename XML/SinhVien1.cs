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
                try {
                    SinhVienn.NgaySinh1 = DateTime.Parse(txt3.Text);
                    SinhVienn.CMND1 = int.Parse(txt5.Text);
                    SinhVienn.SDT1 = int.Parse(txt6.Text);
                }
                catch { }
                SinhVienn.MSSV1 = int.Parse(txt1.Text);
                SinhVienn.HoTen1 = txt2.Text;
                
                SinhVienn.GioiTinh1 = txt4.Text;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
