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
    public partial class phong1 : Form
    {
        public phong1()
        {
            InitializeComponent();
        }
        Phong phong = new Phong();
        Phongxuly phongxyly = new Phongxuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {

                phong.MaPhong1 = int.Parse(txt1.Text);
                phong.TinhTrangPhong1 = txt2.Text.ToString();
                phong.SoLuongToiDa1 = int.Parse(txt3.Text);
                phong.MaKhu1 = txt4.Text.ToString();
                phongxyly.Them(phong);
                phongxyly.hienthi(dataGridView1);
            }
         }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            phong.MaPhong1 = int.Parse(txt1.Text);
            phongxyly.xoa(phong);
            phongxyly.hienthi(dataGridView1);
        }

        private void btnxua_Click(object sender, EventArgs e)
        {

            phong.MaPhong1 = int.Parse(txt1.Text);
            phong.TinhTrangPhong1 = txt2.Text.ToString();
            phong.SoLuongToiDa1 = int.Parse(txt3.Text);
            phong.MaKhu1 = txt4.Text.ToString();
            phongxyly.sua(phong);
            phongxyly.hienthi(dataGridView1);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            phong.MaPhong1 = int.Parse(txt1.Text);
            phongxyly.timkiem(phong, dataGridView1);

        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            phongxyly.hienthi(dataGridView1);
        }

        private void phong1_Load(object sender, EventArgs e)
        {
            phongxyly.hienthi(dataGridView1);
        }
    }
}
