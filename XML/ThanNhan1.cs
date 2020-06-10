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
    public partial class ThanNhan1 : Form
    {
        public ThanNhan1()
        {
            InitializeComponent();
        }
        ThanNhan thannhan = new ThanNhan();
        ThanNhanxuly thannhanxuly = new ThanNhanxuly();

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt1.Text.Trim() != "")
            {
                    thannhan.MSSV1 = txt1.Text;
                thannhan.HoTen1 = txt2.Text;
                thannhan.MoiQuanHe1 = txt3.Text;
                thannhan.DiaChi1 = txt4.Text; ;
                thannhan.SDT1 = txt5.Text;
                thannhanxuly.Them(thannhan);
                thannhanxuly.hienthi(dataGridView2);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            thannhan.MSSV1 = txt1.Text;
            thannhanxuly.xoa(thannhan);
            thannhanxuly.hienthi(dataGridView2);
        }

        private void btnxua_Click(object sender, EventArgs e)
        {
            thannhan.MSSV1 = txt1.Text;
            thannhan.HoTen1 = txt2.Text;
            thannhan.MoiQuanHe1 = txt3.Text;
            thannhan.DiaChi1 = txt4.Text; ;
            thannhan.SDT1 = txt5.Text;
            thannhanxuly.sua(thannhan);
            thannhanxuly.hienthi(dataGridView2);
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            thannhan.MSSV1 = txt1.Text;
            thannhanxuly.timkiem(thannhan, dataGridView2);
        }

        private void btncapnhap_Click(object sender, EventArgs e)
        {
            thannhanxuly.hienthi(dataGridView2);
        }

        private void ThanNhan1_Load(object sender, EventArgs e)
        {
            thannhanxuly.hienthi(dataGridView2);

        }
    }
}
