using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL.Model
{
    internal class ChiTietHoaDon
    {
        public string MaHD { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }

        public float ThanhTien { get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public Nullable<DateTime> NgaySua { get; set; }
    }
}
