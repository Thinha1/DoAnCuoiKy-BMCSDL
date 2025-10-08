using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL.Model
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string SoDienThoai { get; set; }

        public string CCCD { get; set; }
        public float SoDu {  get; set; }

        public string MatKhau {  get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public Nullable<DateTime> NgaySua { get; set; }
    }
}
