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
    public class Khuxuly
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        string fileName = "xmlsinhvien.xml";

        public Khuxuly()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void Them(Khu themk)
        {

            XmlNode Khu = doc.CreateElement("Khu");

            XmlElement MaKhu = doc.CreateElement("MaKhu");
            MaKhu.InnerText = themk.MaKhu1.ToString();
            Khu.AppendChild(MaKhu);
            XmlElement DoiTuong = doc.CreateElement("DoiTuong");
            DoiTuong.InnerText = themk.DoiTuong1.ToString();
            Khu.AppendChild(DoiTuong);
            XmlElement MaQL = doc.CreateElement("MaQL");
            MaQL.InnerText = themk.MaQL1.ToString();
            Khu.AppendChild(MaQL);
            XmlElement TienPhong = doc.CreateElement("TienPhong");
            TienPhong.InnerText = themk.TienPhong1.ToString();
            Khu.AppendChild(TienPhong);

            root.AppendChild(Khu);
            doc.Save(fileName);
        }

        public void sua(Khu suak)
        {
            XmlNode suakhu = root.SelectSingleNode("Khu[MaKhu='" + suak.MaKhu1 + "']");
            if (suak != null)
            {
                XmlNode suakhumoi = doc.CreateElement("Khu");

                XmlElement MaKhu = doc.CreateElement("MaKhu");
                MaKhu.InnerText = suak.MaKhu1.ToString();
                suakhumoi.AppendChild(MaKhu);
                XmlElement DoiTuong = doc.CreateElement("DoiTuong");
                DoiTuong.InnerText = suak.DoiTuong1.ToString();
                suakhumoi.AppendChild(DoiTuong);
                XmlElement MaQL = doc.CreateElement("MaQL");
                MaQL.InnerText = suak.MaQL1.ToString();
                suakhumoi.AppendChild(MaQL);
                XmlElement TienPhong = doc.CreateElement("TienPhong");
                TienPhong.InnerText = suak.TienPhong1.ToString();
                suakhumoi.AppendChild(TienPhong);
                root.ReplaceChild(suakhumoi, suakhu);
                doc.Save(fileName);

            }


        }

        public void xoa(Khu xoak)
        {
            XmlNode khucanxoa = root.SelectSingleNode("Khu[MaKhu='" + xoak.MaKhu1 + "']");
            if (khucanxoa != null)
            {
                root.RemoveChild(khucanxoa);
                doc.Save(fileName);
            }
        }


        public void timkiem(Khu timk, DataGridView dgv)
        {
            XmlNode khucantim = root.SelectSingleNode("Khu[MaKhu='" + timk.MaKhu1 + "']");
            if (khucantim != null)
            {
                dgv.Rows.Clear();
                dgv.ColumnCount = 4;
                dgv.Rows.Add();

                XmlNode MaKhu = khucantim.SelectSingleNode("MaKhu");
                dgv.Rows[0].Cells[0].Value = MaKhu.InnerText;

                XmlNode DoiTuong = khucantim.SelectSingleNode("DoiTuong");
                dgv.Rows[0].Cells[1].Value = DoiTuong.InnerText;

                XmlNode MaQL = khucantim.SelectSingleNode("MaQL");
                dgv.Rows[0].Cells[1].Value = MaQL.InnerText;

                XmlNode TienPhong = khucantim.SelectSingleNode("TienPhong");
                dgv.Rows[0].Cells[3].Value = TienPhong.InnerText;

            }
        }
        public void hienthi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;
            XmlNodeList ds = root.SelectNodes("Khu");
            int sd = 0;// luu tru so dong
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaKhu").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("DoiTuong").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("MaQL").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("TienPhong").InnerText;
                sd++;
            }
        }
    }
}
