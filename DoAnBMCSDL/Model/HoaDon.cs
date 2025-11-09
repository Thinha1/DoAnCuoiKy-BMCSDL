using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL.Model
{
    internal class HoaDon
    {
        public string MaHD { get; set; }
        public string MaMay { get; set; }
        public string MaKH { get; set; }

        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public float TongTien { get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public Nullable<DateTime> NgaySua { get; set; }
    }
}
