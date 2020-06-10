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
    public partial class Khu1 : Form
    {
        public Khu1()
        {
            InitializeComponent();
        }
        Khu Khu = new Khu();
        Khuxuly Khuxuly = new Khuxuly();
        private void btnthem_Click(object sender, EventArgs e)
        {
            Khu.MaKhu1 = txt1.Text;
            Khu.DoiTuong1 = txt2.Text;
            Khu.MaQL1 = txt3.Text;
            Khu.TienPhong1 = int.Parse(txt4.Text);

            Khuxuly.Them(Khu);
            Khuxuly.hienthi(dataGridView1);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            Khu.MaKhu1 = txt1.Text;
            Khuxuly.xoa(Khu);
            Khuxuly.hienthi(dataGridView1);
        }

        private void btnxua_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {

                Khu.MaKhu1 = txt1.Text;
                Khu.DoiTuong1 = txt2.Text;
                Khu.MaQL1 = txt3.Text;
                Khu.TienPhong1 = int.Parse(txt4.Text);
                Khuxuly.sua(Khu);
                Khuxuly.hienthi(dataGridView1);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Khu.MaKhu1 = txt1.Text;
            Khuxuly.timkiem(Khu, dataGridView1);

        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            Khuxuly.hienthi(dataGridView1);
        }

        private void Khu1_Load(object sender, EventArgs e)
        {
            Khuxuly.hienthi(dataGridView1);
        }
    }
}
