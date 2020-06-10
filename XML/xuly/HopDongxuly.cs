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
    public class HopDongxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";
        public HopDongxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(HopDong themhd)
        {

            XmlNode HopDong = doc.CreateElement("HopDong");

            XmlElement MaHopDong = doc.CreateElement("MaHopDong");
            MaHopDong.InnerText = themhd.MaHopDong1.ToString();
            HopDong.AppendChild(MaHopDong);
            XmlElement MSSV = doc.CreateElement("MSSV");
            MSSV.InnerText = themhd.MSSV1.ToString();
            HopDong.AppendChild(MSSV);
            XmlElement MaPhong = doc.CreateElement("MaPhong");
            MaPhong.InnerText = themhd.MaPhong1.ToString();
            HopDong.AppendChild(MaPhong);
            XmlElement NgayLap = doc.CreateElement("NgayLap");
            NgayLap.InnerText = themhd.NgayLap1.ToString();
            HopDong.AppendChild(NgayLap);
            XmlElement NgayBatDau = doc.CreateElement("NgayBatDau");
            NgayBatDau.InnerText = themhd.NgayBatDau1.ToString();
            HopDong.AppendChild(NgayBatDau);
            XmlElement NgayKetThuc = doc.CreateElement("NgayKetThuc");
            NgayKetThuc.InnerText = themhd.NgayKetThuc1.ToString();
            HopDong.AppendChild(NgayKetThuc);

            root.AppendChild(HopDong);
            doc.Save(fileName);
        }

        public void sua(HopDong suahd)
        {
            XmlNode suahopdong = root.SelectSingleNode("HopDong[MaHopDong='" + suahd.MaHopDong1 + "']");
            if (suahd != null)
            {
                XmlNode suahopdongmoi = doc.CreateElement("suahopdongmoi");

                XmlElement MaHopDong = doc.CreateElement("MaHopDong");
                MaHopDong.InnerText = suahd.MaHopDong1.ToString();
                suahopdongmoi.AppendChild(MaHopDong);
                XmlElement MSSV = doc.CreateElement("MSSV");
                MSSV.InnerText = suahd.MSSV1.ToString();
                suahopdongmoi.AppendChild(MSSV);
                XmlElement MaPhong = doc.CreateElement("MaPhong");
                MaPhong.InnerText = suahd.MaPhong1.ToString();
                suahopdongmoi.AppendChild(MaPhong);
                XmlElement NgayLap = doc.CreateElement("NgayLap");
                NgayLap.InnerText = suahd.NgayLap1.ToString();
                suahopdongmoi.AppendChild(NgayLap);
                XmlElement NgayBatDau = doc.CreateElement("NgayBatDau");
                NgayBatDau.InnerText = suahd.NgayBatDau1.ToString();
                suahopdongmoi.AppendChild(NgayBatDau);
                XmlElement NgayKetThuc = doc.CreateElement("NgayKetThuc");
                NgayKetThuc.InnerText = suahd.NgayKetThuc1.ToString();
                suahopdongmoi.AppendChild(NgayKetThuc);

                root.ReplaceChild(suahopdongmoi, suahopdong);
                doc.Save(fileName);
            }
        }

        public void xoa(HopDong xoahd)
        {
            XmlNode xoahopdong = root.SelectSingleNode("HopDong[MaHopDong='" + xoahd.MaHopDong1 + "']");
            if (xoahopdong != null)
            {
                root.RemoveChild(xoahopdong);
                doc.Save(fileName);
            }
        }
        public void timkiem(HopDong timhd, DataGridView dgv)
        {
            XmlNode hopdongcantim = root.SelectSingleNode("HopDong[MaHopDong='" + timhd.MaHopDong1 + "']");
            if (hopdongcantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 6;
                dgv.Rows.Add();

                XmlNode MaHopDong = hopdongcantim.SelectSingleNode("MaHopDong");
                dgv.Rows[0].Cells[0].Value = MaHopDong.InnerText;
                XmlNode MSSV = hopdongcantim.SelectSingleNode("MSSV");
                dgv.Rows[0].Cells[1].Value = MSSV.InnerText;
                XmlNode MaPhong = hopdongcantim.SelectSingleNode("MaPhong");
                dgv.Rows[0].Cells[2].Value = MaPhong.InnerText;
                XmlNode NgayLap = hopdongcantim.SelectSingleNode("NgayLap");
                dgv.Rows[0].Cells[3].Value = NgayLap.InnerText;
                XmlNode NgayBatDau = hopdongcantim.SelectSingleNode("NgayBatDau");
                dgv.Rows[0].Cells[4].Value = NgayBatDau.InnerText;
                XmlNode NgayKetThuc = hopdongcantim.SelectSingleNode("NgayKetThuc");
                dgv.Rows[0].Cells[5].Value = NgayKetThuc.InnerText;


            }
        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 6;
            XmlNodeList ds = root.SelectNodes("HopDong");
            int sd = 0;// luu tru so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaHopDong").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("MSSV").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("MaPhong").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("NgayLap").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("NgayBatDau").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("NgayKetThuc").InnerText;
                sd++;
            }
        }

    }
}
