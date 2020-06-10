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
    public class Phongxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";
        public Phongxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(Phong themp)
        {

            XmlNode Phong = doc.CreateElement("Phong");

            XmlElement MaPhong = doc.CreateElement("MaPhong");
            MaPhong.InnerText = themp.MaPhong1.ToString();
            Phong.AppendChild(MaPhong);
            XmlElement TinhTrangPhong = doc.CreateElement("TinhTrangPhong");
            TinhTrangPhong.InnerText = themp.TinhTrangPhong1.ToString();
            Phong.AppendChild(TinhTrangPhong);
            XmlElement SoLuongToiDa = doc.CreateElement("SoLuongToiDa");
            SoLuongToiDa.InnerText = themp.SoLuongToiDa1.ToString();
            Phong.AppendChild(SoLuongToiDa);
            XmlElement MaKhu = doc.CreateElement("MaKhu");
            MaKhu.InnerText = themp.MaKhu1.ToString();
            Phong.AppendChild(MaKhu);

           
            root.AppendChild(Phong);
            doc.Save(fileName);
        }

        public void sua(Phong suap)
        {
            XmlNode suaphong = root.SelectSingleNode("Phong[MaPhong='" + suap.MaPhong1 + "']");
            if (suaphong != null)
            {
                XmlNode suaphongmoi = doc.CreateElement("Phong");

                XmlElement MaPhong = doc.CreateElement("MaPhong");
                MaPhong.InnerText = suap.MaPhong1.ToString();
                suaphongmoi.AppendChild(MaPhong);
                XmlElement SoLuongToiDa = doc.CreateElement("SoLuongToiDa");
                SoLuongToiDa.InnerText = suap.SoLuongToiDa1.ToString();
                suaphongmoi.AppendChild(SoLuongToiDa);
                XmlElement TinhTrangPhong = doc.CreateElement("TinhTrangPhong");
                TinhTrangPhong.InnerText = suap.TinhTrangPhong1.ToString();
                suaphongmoi.AppendChild(TinhTrangPhong);
                XmlElement MaKhu = doc.CreateElement("MaKhu");
                MaKhu.InnerText = suap.MaKhu1.ToString();
                suaphongmoi.AppendChild(MaKhu);
                // thay thế sinh vien củ bằng sinh viene mới

                root.ReplaceChild(suaphongmoi, suaphong);
                doc.Save(fileName);
            }
        }
        public void xoa(Phong xoap)
        {
            XmlNode suaphong = root.SelectSingleNode("Phong[MaPhong='" + xoap.MaPhong1 + "']");
            if (suaphong != null)
            {
                root.RemoveChild(suaphong);
                doc.Save(fileName);
            }
        }

        public void timkiem(Phong timp, DataGridView dgv)
        {
            XmlNode timphong = root.SelectSingleNode("Phong[MaPhong='" + timp.MaPhong1 + "']");
            if (timphong != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 4;
                dgv.Rows.Add();

                XmlNode MaPhong = timphong.SelectSingleNode("MaPhong");
                dgv.Rows[0].Cells[0].Value = MaPhong.InnerText;
                XmlNode SoLuongToiDa = timphong.SelectSingleNode("SoLuongToiDa");
                dgv.Rows[0].Cells[1].Value = SoLuongToiDa.InnerText;
                XmlNode TinhTrangPhong = timphong.SelectSingleNode("TinhTrangPhong");
                dgv.Rows[0].Cells[2].Value = TinhTrangPhong.InnerText;
                XmlNode MaKhu = timphong.SelectSingleNode("MaKhu");
                dgv.Rows[0].Cells[3].Value = MaKhu.InnerText;


            }

        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;
            XmlNodeList ds = root.SelectNodes("Phong");
            int sd = 0;// luu tru so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaPhong").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("TinhTrangPhong").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("SoLuongToiDa").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("MaKhu").InnerText;
                sd++;
            }
        }

    }
}
