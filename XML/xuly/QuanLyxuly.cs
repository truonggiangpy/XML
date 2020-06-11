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
    public class QuanLyxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";
        public QuanLyxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void Them(QuanLy themql)
        {

            XmlNode QuanLy = doc.CreateElement("QuanLy");

            XmlElement MaQL = doc.CreateElement("MaQL");
            MaQL.InnerText = themql.MaQL1.ToString();
            QuanLy.AppendChild(MaQL);
            
            XmlElement HoTen = doc.CreateElement("HoTen");
            HoTen.InnerText = themql.HoTen1.ToString();
            QuanLy.AppendChild(HoTen);
            
            XmlElement NgaySinh = doc.CreateElement("NgaySinh");
            NgaySinh.InnerText = themql.NgaySinh1.ToShortDateString();
            QuanLy.AppendChild(NgaySinh);
            
            XmlElement DiaChi = doc.CreateElement("DiaChi");
            DiaChi.InnerText = themql.DiaChi1.ToString();
            QuanLy.AppendChild(DiaChi);
            
            XmlElement SDT = doc.CreateElement("SDT");
            SDT.InnerText = themql.SDT1.ToString();
            QuanLy.AppendChild(SDT);

            root.AppendChild(QuanLy);
            doc.Save(fileName);
        }

        public void sua(QuanLy suaql)
        {
            XmlNode suaquanly = root.SelectSingleNode("QuanLy[MaQL='" + suaql.MaQL1 + "']");
            if (suaql != null)
            {
                XmlNode suaquanlymoi = doc.CreateElement("QuanLy");

                XmlElement MaQL = doc.CreateElement("MaQL");
                MaQL.InnerText = suaql.MaQL1.ToString();
                suaquanlymoi.AppendChild(MaQL);
                
                XmlElement HoTen = doc.CreateElement("HoTen");
                HoTen.InnerText = suaql.HoTen1.ToString();
                suaquanlymoi.AppendChild(HoTen);
                
                XmlElement NgaySinh = doc.CreateElement("NgaySinh");
                NgaySinh.InnerText = suaql.NgaySinh1.ToString();
                suaquanlymoi.AppendChild(NgaySinh);
                
                XmlElement DiaChi = doc.CreateElement("DiaChi");
                DiaChi.InnerText = suaql.DiaChi1.ToString();
                suaquanlymoi.AppendChild(DiaChi);
                
                XmlElement SDT = doc.CreateElement("SDT");
                SDT.InnerText = suaql.SDT1.ToString();
                suaquanlymoi.AppendChild(SDT);

               
                // thay thế sinh vien củ bằng sinh viene mới

                root.ReplaceChild(suaquanlymoi, suaquanly);
                doc.Save(fileName);
            }
        }
        public void xoa(QuanLy xoaql)
        {
            XmlNode quanlycanxoa = root.SelectSingleNode("QuanLy[MaQL='" + xoaql.MaQL1 + "']");
            if (quanlycanxoa != null)
            {
                root.RemoveChild(quanlycanxoa);
                doc.Save(fileName);
            }
        }

        public void timkiem(QuanLy timql, DataGridView dgv)
        {
            XmlNode quanlycantim = root.SelectSingleNode("QuanLy[MaQL='" + timql.MaQL1 + "']");
            if (quanlycantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 5;
                dgv.Rows.Add();

                XmlNode MaQL = quanlycantim.SelectSingleNode("MaQL");
                dgv.Rows[0].Cells[0].Value = MaQL.InnerText;
                
                XmlNode HoTen = quanlycantim.SelectSingleNode("HoTen");
                dgv.Rows[0].Cells[1].Value = HoTen.InnerText;
                
                XmlNode NgaySinh = quanlycantim.SelectSingleNode("NgaySinh");
                dgv.Rows[0].Cells[2].Value = NgaySinh.InnerText;
                
                XmlNode DiaChi = quanlycantim.SelectSingleNode("DiaChi");
                dgv.Rows[0].Cells[3].Value = DiaChi.InnerText;
                
                XmlNode SDT = quanlycantim.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[4].Value = SDT.InnerText;
            }

        }

        public void hienthi(DataGridView dgv1)
        {
            dgv1.Rows.Clear();
            dgv1.ColumnCount = 5;
            XmlNodeList ds = root.SelectNodes("QuanLy");
            int sd = 0;// luu tru so dong

                foreach (XmlNode item in ds)
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaQL").InnerText;
                    dgv1.Rows[sd].Cells[1].Value = item.SelectSingleNode("HoTen").InnerText;
                    dgv1.Rows[sd].Cells[2].Value = item.SelectSingleNode("NgaySinh").InnerText;
                    dgv1.Rows[sd].Cells[3].Value = item.SelectSingleNode("DiaChi").InnerText;
                    dgv1.Rows[sd].Cells[4].Value = item.SelectSingleNode("SDT").InnerText;
                    sd++;
                }


        }
    }
}
