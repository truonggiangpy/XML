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
    public partial class PhiKTX1 : Form
    {
        public PhiKTX1()
        {
            InitializeComponent();
        }
        PhiKTX phiktx = new PhiKTX();

        PhiKTXxuly phiktxxyly = new PhiKTXxuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {

                phiktx.MaBienLai1 = txt1.Text;
                phiktx.MSSV1 = txt2.Text;
                phiktx.MaPhong1 = txt3.Text;
                phiktx.NamHoc1 = txt4.Text; ;
                phiktx.NgayThu1 = DateTime.Parse(txt5.Text);
                phiktxxyly.Them(phiktx);
                phiktxxyly.hienthi(dataGridView2);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            phiktx.MaBienLai1 = txt1.Text;
            phiktxxyly.xoa(phiktx);
            phiktxxyly.hienthi(dataGridView2);
        }

        private void btnxua_Click(object sender, EventArgs e)
        {

            phiktx.MaBienLai1 = txt1.Text;
            phiktx.MSSV1 = txt2.Text;
            phiktx.MaPhong1 = txt3.Text;
            phiktx.NamHoc1 = txt4.Text; ;
            phiktx.NgayThu1 = DateTime.Parse(txt5.Text);
            phiktxxyly.sua(phiktx);
            phiktxxyly.hienthi(dataGridView2);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            phiktx.MaBienLai1 = txt1.Text;
            phiktxxyly.timkiem(phiktx, dataGridView2);
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            phiktxxyly.hienthi(dataGridView2);
        }

        private void PhiKTX1_Load(object sender, EventArgs e)
        {
            phiktxxyly.hienthi(dataGridView2);

        }
    }
}
