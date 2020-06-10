using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML.ktx
{
    public class HopDong
    {
        private string MaHopDong;
        private string MSSV;
        private string MaPhong;
        private DateTime NgayLap;
        private DateTime NgayBatDau;
        private DateTime NgayKetThuc;

        public string MaHopDong1 { get => MaHopDong; set => MaHopDong = value; }
        public string MSSV1 { get => MSSV; set => MSSV = value; }
        public string MaPhong1 { get => MaPhong; set => MaPhong = value; }
        public DateTime NgayLap1 { get => NgayLap; set => NgayLap = value; }
        public DateTime NgayBatDau1 { get => NgayBatDau; set => NgayBatDau = value; }
        public DateTime NgayKetThuc1 { get => NgayKetThuc; set => NgayKetThuc = value; }
    }
}
