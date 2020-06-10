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
    public class HoaDonDienNuocxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";
        public HoaDonDienNuocxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(HoaDonDienNuoc themHD)
        {

            XmlNode HoaDonDienNuoc = doc.CreateElement("HoaDonDienNuoc");

            XmlElement MaHD = doc.CreateElement("MaHD");
            MaHD.InnerText = themHD.MaHD1.ToString();
            HoaDonDienNuoc.AppendChild(MaHD);

            XmlElement MaQL = doc.CreateElement("MaQL");
            MaQL.InnerText = themHD.MaQL1.ToString();
            HoaDonDienNuoc.AppendChild(MaQL);

            XmlElement MaPhong = doc.CreateElement("MaPhong");
            MaPhong.InnerText = themHD.MaPhong1.ToString();
            HoaDonDienNuoc.AppendChild(MaPhong);

            XmlElement NgayLap = doc.CreateElement("NgayLap");
            NgayLap.InnerText = themHD.NgayLap1.ToString();
            HoaDonDienNuoc.AppendChild(NgayLap);

            XmlElement ChiSoDienDau = doc.CreateElement("ChiSoDienDau");
            ChiSoDienDau.InnerText = themHD.ChiSoDienDau1.ToString();
            HoaDonDienNuoc.AppendChild(ChiSoDienDau);

            XmlElement ChiSoDienCuoi = doc.CreateElement("ChiSoDienCuoi");
            ChiSoDienCuoi.InnerText = themHD.ChiSoDienCuoi1.ToString();
            HoaDonDienNuoc.AppendChild(ChiSoDienCuoi);

            XmlElement ChiSoNuocDau = doc.CreateElement("ChiSoNuocDau");
            ChiSoNuocDau.InnerText = themHD.ChiSoNuocDau1.ToString();
            HoaDonDienNuoc.AppendChild(ChiSoNuocDau);

            XmlElement ChiSoNuocCuoi = doc.CreateElement("ChiSoNuocCuoi");
            ChiSoNuocCuoi.InnerText = themHD.ChiSoNuocCuoi1.ToString();
            HoaDonDienNuoc.AppendChild(ChiSoNuocCuoi);

            XmlElement DonGiaDien = doc.CreateElement("DonGiaDien");
            DonGiaDien.InnerText = themHD.DonGiaDien1.ToString();
            HoaDonDienNuoc.AppendChild(DonGiaDien);

            XmlElement DonGiaNuoc = doc.CreateElement("DonGiaNuoc");
            DonGiaNuoc.InnerText = themHD.DonGiaNuoc1.ToString();
            HoaDonDienNuoc.AppendChild(DonGiaNuoc);

            root.AppendChild(HoaDonDienNuoc);
            doc.Save(fileName);
        }

        public void sua(HoaDonDienNuoc suaHD)
        {
            XmlNode suaHoaDonDienNuoc = root.SelectSingleNode("HoaDonDienNuoc[MaHD='" + suaHD.MaHD1 + "']");
            if (suaHD != null)
            {
                XmlElement MaHD = doc.CreateElement("MaHD");
                MaHD.InnerText = suaHD.MaHD1.ToString();
                suaHoaDonDienNuoc.AppendChild(MaHD);

                XmlElement MaQL = doc.CreateElement("MaQL");
                MaQL.InnerText = suaHD.MaQL1.ToString();
                suaHoaDonDienNuoc.AppendChild(MaQL);

                XmlElement MaPhong = doc.CreateElement("MaPhong");
                MaPhong.InnerText = suaHD.MaPhong1.ToString();
                suaHoaDonDienNuoc.AppendChild(MaPhong);

                XmlElement NgayLap = doc.CreateElement("NgayLap");
                NgayLap.InnerText = suaHD.NgayLap1.ToString();
                suaHoaDonDienNuoc.AppendChild(NgayLap);

                XmlElement ChiSoDienDau = doc.CreateElement("ChiSoDienDau");
                ChiSoDienDau.InnerText = suaHD.ChiSoDienDau1.ToString();
                suaHoaDonDienNuoc.AppendChild(ChiSoDienDau);

                XmlElement ChiSoDienCuoi = doc.CreateElement("ChiSoDienCuoi");
                ChiSoDienCuoi.InnerText = suaHD.ChiSoDienCuoi1.ToString();
                suaHoaDonDienNuoc.AppendChild(ChiSoDienCuoi);

                XmlElement ChiSoNuocDau = doc.CreateElement("ChiSoNuocDau");
                ChiSoNuocDau.InnerText = suaHD.ChiSoNuocDau1.ToString();
                suaHoaDonDienNuoc.AppendChild(ChiSoNuocDau);

                XmlElement ChiSoNuocCuoi = doc.CreateElement("ChiSoNuocCuoi");
                ChiSoNuocCuoi.InnerText = suaHD.ChiSoNuocCuoi1.ToString();
                suaHoaDonDienNuoc.AppendChild(ChiSoNuocCuoi);

                XmlElement DonGiaDien = doc.CreateElement("DonGiaDien");
                DonGiaDien.InnerText = suaHD.DonGiaDien1.ToString();
                suaHoaDonDienNuoc.AppendChild(DonGiaDien);

                XmlElement DonGiaNuoc = doc.CreateElement("DonGiaNuoc");
                DonGiaNuoc.InnerText = suaHD.DonGiaNuoc1.ToString();
                suaHoaDonDienNuoc.AppendChild(DonGiaNuoc);

                root.AppendChild(suaHoaDonDienNuoc);
                doc.Save(fileName);
            }
        }
        public void xoa(HoaDonDienNuoc suaHD)
        {
            XmlNode HoaDonDienNuoccanxoa = root.SelectSingleNode("HoaDonDienNuoc[MaHD='" + suaHD.MaHD1 + "']");
            if (HoaDonDienNuoccanxoa != null)
            {
                root.RemoveChild(HoaDonDienNuoccanxoa);
                doc.Save(fileName);
            }
        }

        public void timkiem(HoaDonDienNuoc timHoaDonDienNuoc, DataGridView dgv)
        {
            XmlNode HoaDonDienNuoccantim = root.SelectSingleNode("HoaDonDienNuoc[MaHD='" + timHoaDonDienNuoc.MaHD1 + "']");
            if (HoaDonDienNuoccantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 10;
                dgv.Rows.Add();

                XmlNode MaHD = HoaDonDienNuoccantim.SelectSingleNode("MaHD");
                dgv.Rows[0].Cells[0].Value = MaHD.InnerText;
                XmlNode MaQL = HoaDonDienNuoccantim.SelectSingleNode("MaQL");
                dgv.Rows[0].Cells[1].Value = MaQL.InnerText;
                XmlNode MaPhong = HoaDonDienNuoccantim.SelectSingleNode("MaPhong");
                dgv.Rows[0].Cells[2].Value = MaPhong.InnerText;
                XmlNode NgayLap = HoaDonDienNuoccantim.SelectSingleNode("NgayLap");
                dgv.Rows[0].Cells[3].Value = NgayLap.InnerText;
                XmlNode ChiSoDienDau = HoaDonDienNuoccantim.SelectSingleNode("ChiSoDienDau");
                dgv.Rows[0].Cells[4].Value = ChiSoDienDau.InnerText;
                XmlNode ChiSoDienCuoi = HoaDonDienNuoccantim.SelectSingleNode("ChiSoDienCuoi");
                dgv.Rows[0].Cells[5].Value = ChiSoDienCuoi.InnerText;
                XmlNode ChiSoNuocDau = HoaDonDienNuoccantim.SelectSingleNode("ChiSoNuocDau");
                dgv.Rows[0].Cells[6].Value = ChiSoNuocDau.InnerText;
                XmlNode ChiSoNuocCuoi = HoaDonDienNuoccantim.SelectSingleNode("ChiSoNuocCuoi");
                dgv.Rows[0].Cells[7].Value = ChiSoNuocCuoi.InnerText;
                XmlNode DonGiaDien = HoaDonDienNuoccantim.SelectSingleNode("DonGiaDien");
                dgv.Rows[0].Cells[8].Value = DonGiaDien.InnerText;
                XmlNode DonGiaNuoc = HoaDonDienNuoccantim.SelectSingleNode("DonGiaNuoc");
                dgv.Rows[0].Cells[9].Value = DonGiaNuoc.InnerText;

            }

        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 10;
            XmlNodeList ds = root.SelectNodes("HoaDonDienNuoc");
            int sd = 0;// luu tru so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaHD").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("MaQL").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("MaPhong").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("NgayLap").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("ChiSoDienDau").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("ChiSoDienCuoi").InnerText;
                dgv.Rows[sd].Cells[6].Value = item.SelectSingleNode("ChiSoNuocDau").InnerText;
                dgv.Rows[sd].Cells[7].Value = item.SelectSingleNode("ChiSoNuocCuoi").InnerText;
                dgv.Rows[sd].Cells[8].Value = item.SelectSingleNode("DonGiaDien").InnerText;
                dgv.Rows[sd].Cells[9].Value = item.SelectSingleNode("DonGiaNuoc").InnerText;
                sd++;
            }
        }
    }

}
