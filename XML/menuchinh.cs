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
            QuanLy ql = new QuanLy();
            ql.Show();
        }

        private void menuchinh_Load(object sender, EventArgs e)
        {

        }
    }
}
