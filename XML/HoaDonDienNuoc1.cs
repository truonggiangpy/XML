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
    public partial class HoaDonDienNuoc1 : Form
    {
        public HoaDonDienNuoc1()
        {
            InitializeComponent();
        }
        HoaDonDienNuoc hd =new HoaDonDienNuoc();
        HoaDonDienNuocxuly hdxl = new HoaDonDienNuocxuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {


                hd.MaHD1 = txt1.Text.ToString();
                hd.MaQL1 = txt2.Text.ToString();
                hd.MaPhong1 = txt3.Text.ToString();
                hd.NgayLap1 = DateTime.Parse(txt4.Text);
                hd.ChiSoDienDau1 = txt5.Text.ToString();
                hd.ChiSoDienCuoi1 = txt6.Text.ToString();
                hd.ChiSoNuocDau1 = txt7.Text.ToString();
                hd.ChiSoNuocCuoi1 = txt8.Text.ToString();
                hd.DonGiaDien1 = txt9.Text.ToString();
                hd.DonGiaNuoc1 = txt10.Text.ToString();
                hdxl.Them(hd);
                hdxl.hienthi(dataGridView1);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            hd.MaHD1 = txt1.Text.ToString();
            hdxl.xoa(hd);
            hdxl.hienthi(dataGridView1);
        }

        private void btnxua_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {
                hd.MaHD1 = txt1.Text.ToString();
                hd.MaQL1 = txt2.Text.ToString();
                hd.MaPhong1 = txt3.Text.ToString();
                hd.NgayLap1 = DateTime.Parse(txt4.Text);
                hd.ChiSoDienDau1 = txt5.Text.ToString();
                hd.ChiSoDienCuoi1 = txt6.Text.ToString();
                hd.ChiSoNuocDau1 = txt7.Text.ToString();
                hd.ChiSoNuocCuoi1 = txt8.Text.ToString();
                hd.DonGiaDien1 = txt9.Text.ToString();
                hd.DonGiaNuoc1 = txt10.Text.ToString();
                hdxl.sua(hd);
                hdxl.hienthi(dataGridView1);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hd.MaHD1 = txt1.Text.ToString();
            hdxl.timkiem(hd, dataGridView1);
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            hdxl.hienthi(dataGridView1);
        }

        private void HoaDonDienNuoc1_Load(object sender, EventArgs e)
        {
            hdxl.hienthi(dataGridView1);
        }
    }
}
