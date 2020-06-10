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
    public class ThanNhanxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";
        public ThanNhanxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Them(ThanNhan themtn)
        {

            XmlNode ThanNhan = doc.CreateElement("ThanNhan");

            XmlElement MSSV = doc.CreateElement("MSSV");
            MSSV.InnerText = themtn.MSSV1.ToString();
            ThanNhan.AppendChild(MSSV);
            
            XmlElement HoTen = doc.CreateElement("HoTen");
            HoTen.InnerText = themtn.HoTen1.ToString();
            ThanNhan.AppendChild(HoTen);
            
            XmlElement MoiQuanHe = doc.CreateElement("MoiQuanHe");
            MoiQuanHe.InnerText = themtn.MoiQuanHe1.ToString();
            ThanNhan.AppendChild(MoiQuanHe);
            
            XmlElement DiaChi = doc.CreateElement("DiaChi");
            DiaChi.InnerText = themtn.DiaChi1.ToString();
            ThanNhan.AppendChild(DiaChi);
            
            XmlElement SDT = doc.CreateElement("SDT");
            SDT.InnerText = themtn.SDT1.ToString();
            ThanNhan.AppendChild(SDT);

            

            root.AppendChild(ThanNhan);
            doc.Save(fileName);
        }

        public void sua(ThanNhan suatn)
        {
            XmlNode suaThanNhan = root.SelectSingleNode("ThanNhan[MSSV='" + suatn.MSSV1 + "']");
            if (suatn != null)
            {
                XmlNode suaThanNhanmoi = doc.CreateElement("ThanNhan");

                XmlElement MSSV = doc.CreateElement("MSSV");
                MSSV.InnerText = suatn.MSSV1.ToString();
                suaThanNhanmoi.AppendChild(MSSV);
                
                XmlElement HoTen = doc.CreateElement("HoTen");
                HoTen.InnerText = suatn.HoTen1.ToString();
                suaThanNhanmoi.AppendChild(HoTen);
                
                XmlElement MoiQuanHe = doc.CreateElement("MoiQuanHe");
                MoiQuanHe.InnerText = suatn.MoiQuanHe1.ToString();
                suaThanNhanmoi.AppendChild(MoiQuanHe);
                
                XmlElement DiaChi = doc.CreateElement("DiaChi");
                DiaChi.InnerText = suatn.DiaChi1.ToString();
                suaThanNhanmoi.AppendChild(DiaChi);
                
                XmlElement SDT = doc.CreateElement("SDT");
                SDT.InnerText = suatn.SDT1.ToString();
                suaThanNhanmoi.AppendChild(SDT);
                
                // thay thế sinh vien củ bằng sinh viene mới

                root.ReplaceChild(suaThanNhanmoi, suaThanNhan);
                doc.Save(fileName);
            }
        }
        public void xoa(ThanNhan xoatn)
        {
            XmlNode xoaThanNhan = root.SelectSingleNode("ThanNhan[MSSV='" + xoatn.MSSV1 + "']");
            if (xoaThanNhan != null)
            {
                root.RemoveChild(xoaThanNhan);
                doc.Save(fileName);
            }
        }

        public void timkiem(ThanNhan timtn, DataGridView dgv)
        {
            XmlNode thannhancantim = root.SelectSingleNode("ThanNhan[MSSV='" + timtn.MSSV1 + "']");
            if (thannhancantim != null)
            {
                
                dgv.Rows.Clear();
                dgv.ColumnCount = 5;
                dgv.Rows.Add();

                XmlNode MSSV = thannhancantim.SelectSingleNode("MSSV");
                dgv.Rows[0].Cells[0].Value = MSSV.InnerText;

                XmlNode HoTen = thannhancantim.SelectSingleNode("HoTen");
                dgv.Rows[0].Cells[1].Value = HoTen.InnerText;

                XmlNode MoiQuanHe = thannhancantim.SelectSingleNode("MoiQuanHe");
                dgv.Rows[0].Cells[2].Value = MoiQuanHe.InnerText;

                XmlNode DiaChi = thannhancantim.SelectSingleNode("DiaChi");
                dgv.Rows[0].Cells[3].Value = DiaChi.InnerText;

                XmlNode SDT = thannhancantim.SelectSingleNode("SDT");
                dgv.Rows[0].Cells[4].Value = SDT.InnerText;


            }

        }

        public void hienthi(DataGridView dgv1)
        {
            dgv1.Rows.Clear();
            dgv1.ColumnCount = 5;
            XmlNodeList ds = root.SelectNodes("ThanNhan");
            int sd = 0;// luu tru so dong
            try
            {
                foreach (XmlNode item in ds)
                {
                    dgv1.Rows.Add();
                    dgv1.Rows[sd].Cells[0].Value = item.SelectSingleNode("MSSV").InnerText;
                    dgv1.Rows[sd].Cells[1].Value = item.SelectSingleNode("HoTen").InnerText;
                    dgv1.Rows[sd].Cells[2].Value = item.SelectSingleNode("MoiQuanHe").InnerText;
                    dgv1.Rows[sd].Cells[3].Value = item.SelectSingleNode("DiaChi").InnerText;
                    dgv1.Rows[sd].Cells[4].Value = item.SelectSingleNode("SDT").InnerText;
                    sd++;
                }

            }
            catch { }

        }
    }
}
