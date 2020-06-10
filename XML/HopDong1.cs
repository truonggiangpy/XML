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
    public partial class HopDong1 : Form
    {
        public HopDong1()
        {
            InitializeComponent();
        }
        HopDong HopDongg = new HopDong();
        HopDongxuly HopDongxulyg = new HopDongxuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {

                HopDongg.MaHopDong1 = txt1.Text;
                HopDongg.MSSV1 = txt2.Text;
                HopDongg.MaPhong1 = txt3.Text;
                HopDongg.NgayLap1 = DateTime.Parse(txt4.Text);
                HopDongg.NgayBatDau1 = DateTime.Parse(txt5.Text);
                HopDongg.NgayKetThuc1 = DateTime.Parse(txt6.Text);
                HopDongxulyg.Them(HopDongg);
                HopDongxulyg.hienthi(dataGridView1);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            HopDongg.MSSV1 = txt1.Text;
            HopDongxulyg.xoa(HopDongg);
            HopDongxulyg.hienthi(dataGridView1);
        }

        private void btnxua_Click(object sender, EventArgs e)
        {
                if (txt1.Text.Trim() != "")
                {

                    HopDongg.MaHopDong1 = txt1.Text;
                    HopDongg.MSSV1 = txt2.Text;
                    HopDongg.MaPhong1 = txt3.Text;
                    HopDongg.NgayLap1 = DateTime.Parse(txt4.Text);
                     HopDongg.NgayBatDau1 = DateTime.Parse(txt5.Text);
                    HopDongg.NgayKetThuc1 = DateTime.Parse(txt6.Text);
                    HopDongxulyg.sua(HopDongg);
                    HopDongxulyg.hienthi(dataGridView1);


                }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            HopDongg.MSSV1 = txt1.Text;
            HopDongxulyg.timkiem(HopDongg, dataGridView1);
        }

        private void HopDong1_Load(object sender, EventArgs e)
        {
            HopDongxulyg.hienthi(dataGridView1);

        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            HopDongxulyg.hienthi(dataGridView1);
        }
    }
}
