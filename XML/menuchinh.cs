using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML
{
    public partial class menuchinh : Form
    {
        public menuchinh()
        {
            InitializeComponent();
        }

        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            SinhVien1 sv = new SinhVien1();
            sv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLy1 ql = new QuanLy1();
            ql.Show();
        }

        private void menuchinh_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Khu1 k = new Khu1();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HopDong1 hd = new HopDong1();
            hd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThanNhan1 tn = new ThanNhan1();
            tn.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PhiKTX1 phiktx = new PhiKTX1();
            phiktx.Show();
        }
    }
}
