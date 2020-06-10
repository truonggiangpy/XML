using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using XML.ktx;

namespace XML.xuly
{
    public class PhiKTXxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";
        public PhiKTXxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(PhiKTX themphi)
        {

            XmlNode PhiKTX = doc.CreateElement("QuanLy");

            XmlElement MaBienLai = doc.CreateElement("MaBienLai");
            MaBienLai.InnerText = themphi.MaBienLai1.ToString();
            PhiKTX.AppendChild(MaBienLai);
            
            XmlElement MSSV = doc.CreateElement("MSSV");
            MSSV.InnerText = themphi.MSSV1.ToString();
            PhiKTX.AppendChild(MSSV);
            
            XmlElement MaPhong = doc.CreateElement("MaPhong");
            MaPhong.InnerText = themphi.MaPhong1.ToString();
            PhiKTX.AppendChild(MaPhong);
            
            XmlElement NamHoc = doc.CreateElement("NamHoc");
            NamHoc.InnerText = themphi.NamHoc1.ToString();
            PhiKTX.AppendChild(NamHoc);
            
            XmlElement NgayThu = doc.CreateElement("NgayThu");
            NgayThu.InnerText = themphi.NgayThu1.ToString();
            PhiKTX.AppendChild(NgayThu);

            

            root.AppendChild(PhiKTX);
            doc.Save(fileName);
        }

        public void sua(PhiKTX suaphi)
        {
            XmlNode suaphiktx = root.SelectSingleNode("PhiKTX[MaBienLai='" + suaphi.MaBienLai1 + "']");
            if (suaphi != null)
            {
                XmlNode suaphiktxmoi = doc.CreateElement("PhiKTX");

                XmlElement MaBienLai = doc.CreateElement("MaBienLai");
                MaBienLai.InnerText = suaphi.MaBienLai1.ToString();
                suaphiktxmoi.AppendChild(MaBienLai);
                XmlElement MSSV = doc.CreateElement("MSSV");
                MSSV.InnerText = suaphi.MSSV1.ToString();
                suaphiktxmoi.AppendChild(MSSV);
                XmlElement MaPhong = doc.CreateElement("MaPhong");
                MaPhong.InnerText = suaphi.MaPhong1.ToString();
                suaphiktxmoi.AppendChild(MaPhong);
                XmlElement NamHoc = doc.CreateElement("NamHoc");
                NamHoc.InnerText = suaphi.NamHoc1.ToString();
                suaphiktxmoi.AppendChild(NamHoc);
                XmlElement NgayThu = doc.CreateElement("NgayThu");
                NgayThu.InnerText = suaphi.NgayThu1.ToString();
                suaphiktxmoi.AppendChild(NgayThu);

                // thay thế sinh vien củ bằng sinh viene mới

                root.ReplaceChild(suaphiktxmoi, suaphiktx);
                doc.Save(fileName);
            }
        }
        public void xoa(PhiKTX xoaphi)
        {
            XmlNode xoaphiktx = root.SelectSingleNode("PhiKTX[MaBienLai='" + xoaphi.MaBienLai1 + "']");
            if (xoaphiktx != null)
            {
                root.RemoveChild(xoaphiktx);
                doc.Save(fileName);
            }
        }

        public void timkiem(PhiKTX timphi, DataGridView dgv)
        {
            XmlNode phiktx = root.SelectSingleNode("PhiKTX[MaBienLai='" + timphi.MaBienLai1 + "']");
            if (phiktx != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 5;
                dgv.Rows.Add();

                XmlNode MaBienLai = phiktx.SelectSingleNode("MaBienLai");
                dgv.Rows[0].Cells[0].Value = MaBienLai.InnerText;

                XmlNode MSSV = phiktx.SelectSingleNode("MSSV");
                dgv.Rows[0].Cells[1].Value = MSSV.InnerText;

                XmlNode MaPhong = phiktx.SelectSingleNode("MaPhong");
                dgv.Rows[0].Cells[2].Value = MaPhong.InnerText;

                XmlNode NamHoc = phiktx.SelectSingleNode("NamHoc");
                dgv.Rows[0].Cells[3].Value = NamHoc.InnerText;

                XmlNode NgayThu = phiktx.SelectSingleNode("NgayThu");
                dgv.Rows[0].Cells[4].Value = NgayThu.InnerText;
            }

        }

        public void hienthi(DataGridView dgv1)
        {
            dgv1.Rows.Clear();
            dgv1.ColumnCount = 5;
            XmlNodeList ds = root.SelectNodes("PhiKTX");
            int sd = 0;// luu tru so dong
            try
            {
                foreach (XmlNode item in ds)
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaBienLai").InnerText;
                    dgv1.Rows[sd].Cells[1].Value = item.SelectSingleNode("MSSV").InnerText;
                    dgv1.Rows[sd].Cells[2].Value = item.SelectSingleNode("MaPhong").InnerText;
                    dgv1.Rows[sd].Cells[3].Value = item.SelectSingleNode("NamHoc").InnerText;
                    dgv1.Rows[sd].Cells[4].Value = item.SelectSingleNode("NgayThu").InnerText;
                    sd++;
                }

            }
            catch { }

        }
    }
}
