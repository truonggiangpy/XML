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
    public class SinhVienxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = @"E:\XML\XML\XML\XMLFile1.xml";
        public SinhVienxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        
        public void Them(SinhVien themsv)
        {
            
            XmlNode SinhVien = doc.CreateElement("SinhVien");

            XmlElement MSSV = doc.CreateElement("MSSV");
            MSSV.InnerText = themsv.MSSV1.ToString();
            SinhVien.AppendChild(MSSV);

            XmlElement HoTen = doc.CreateElement("HoTen");
            HoTen.InnerText = themsv.HoTen1;
            SinhVien.AppendChild(HoTen);

            XmlElement NgaySinh = doc.CreateElement("NgaySinh");
            NgaySinh.InnerText = themsv.NgaySinh1.ToString();
            SinhVien.AppendChild(NgaySinh);

            XmlElement GioiTinh = doc.CreateElement("GioiTinh");
            GioiTinh.InnerText = themsv.GioiTinh1.ToString();
            SinhVien.AppendChild(GioiTinh);

            XmlElement CMND = doc.CreateElement("CMND");
            CMND.InnerText = themsv.CMND1.ToString();
            SinhVien.AppendChild(CMND);

            XmlElement SDT = doc.CreateElement("SDT");
            SDT.InnerText = themsv.SDT1.ToString();
            SinhVien.AppendChild(SDT);

            XmlElement Lop = doc.CreateElement("Lop");
            Lop.InnerText = themsv.Lop1.ToString();
            SinhVien.AppendChild(Lop);

            XmlElement DiaChi = doc.CreateElement("DiaChi");
            DiaChi.InnerText = themsv.DiaChi1.ToString();
            SinhVien.AppendChild(DiaChi);

            root.AppendChild(SinhVien);
            doc.Save(fileName);
        }

        public void sua(SinhVien suasv)
        {
            XmlNode suasinhvien = root.SelectSingleNode("SinhVien[MSSV='" + suasv.MSSV1 + "']");
            if(suasv != null)
            {
                XmlNode suasinhvienmoi = doc.CreateElement("SinhVien");

                XmlElement MSSV = doc.CreateElement("MSSV");
                MSSV.InnerText = suasv.MSSV1.ToString();
                suasinhvienmoi.AppendChild(MSSV);

                XmlElement HoTen = doc.CreateElement("HoTen");
                HoTen.InnerText = suasv.HoTen1;
                suasinhvienmoi.AppendChild(HoTen);

                XmlElement NgaySinh = doc.CreateElement("NgaySinh");
                NgaySinh.InnerText = suasv.NgaySinh1.ToString();
                suasinhvienmoi.AppendChild(NgaySinh);

                XmlElement GioiTinh = doc.CreateElement("GioiTinh");
                GioiTinh.InnerText = suasv.GioiTinh1.ToString();
                suasinhvienmoi.AppendChild(GioiTinh);

                XmlElement CMND = doc.CreateElement("CMND");
                CMND.InnerText = suasv.CMND1.ToString();
                suasinhvienmoi.AppendChild(CMND);

                XmlElement SDT = doc.CreateElement("SDT");
                SDT.InnerText = suasv.SDT1.ToString();
                suasinhvienmoi.AppendChild(SDT);

                XmlElement Lop = doc.CreateElement("Lop");
                Lop.InnerText = suasv.Lop1.ToString();
                suasinhvienmoi.AppendChild(Lop);

                XmlElement DiaChi = doc.CreateElement("DiaChi");
                DiaChi.InnerText = suasv.DiaChi1.ToString();
                suasinhvienmoi.AppendChild(DiaChi);
                // thay thế sinh vien củ bằng sinh viene mới

                root.ReplaceChild(suasinhvienmoi, suasinhvien);
                doc.Save(fileName);
            }
        }
        public void xoa(SinhVien xoasv)
        {
            XmlNode sinhviencanxoa = root.SelectSingleNode("SinhVien[MSSV='" + xoasv.MSSV1 + "']");
            if(sinhviencanxoa != null)
            {
                root.RemoveChild(sinhviencanxoa);
                doc.Save(fileName);
            }
        }

        public void timkiem(SinhVien timsv, DataGridView dgv)
        {
            XmlNode sinhviencantim = root.SelectSingleNode("SinhVien[MSSV='" + timsv.MSSV1 + "']");
            if (sinhviencantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 8;
                dgv.Rows.Add();

                XmlNode MSSV = sinhviencantim.SelectSingleNode("MSSV");
                dgv.Rows[0].Cells[0].Value = MSSV.InnerText;
                     XmlNode HoTen = sinhviencantim.SelectSingleNode("HoTen");
                dgv.Rows[0].Cells[1].Value = HoTen.InnerText;
                     XmlNode NgaySinh = sinhviencantim.SelectSingleNode("NgaySinh");
                dgv.Rows[0].Cells[2].Value = NgaySinh.InnerText;
                     XmlNode GioiTinh = sinhviencantim.SelectSingleNode("GioiTinh");
                dgv.Rows[0].Cells[3].Value = GioiTinh.InnerText;
                     XmlNode CMND = sinhviencantim.SelectSingleNode("CMND");
                dgv.Rows[0].Cells[4].Value = CMND.InnerText;
                     XmlNode SDT = sinhviencantim.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[5].Value = SDT.InnerText;
                     XmlNode Lop = sinhviencantim.SelectSingleNode("Lop");
                dgv.Rows[0].Cells[6].Value = Lop.InnerText;
                     XmlNode DiaChi = sinhviencantim.SelectSingleNode("DiaChi");
                dgv.Rows[0].Cells[7].Value = DiaChi.InnerText;

            }

        }

        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 8;
            XmlNodeList ds = root.SelectNodes("SinhVien");
            int sd = 0;// luu tru so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("MSSV").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("HoTen").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("NgaySinh").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("GioiTinh").InnerText;
                dgv.Rows[sd].Cells[4].Value = item.SelectSingleNode("CMND").InnerText;
                dgv.Rows[sd].Cells[5].Value = item.SelectSingleNode("SDT").InnerText;
                dgv.Rows[sd].Cells[6].Value = item.SelectSingleNode("Lop").InnerText;
                dgv.Rows[sd].Cells[7].Value = item.SelectSingleNode("DiaChi").InnerText;
                sd++;
            }
        }

       

    }
}
