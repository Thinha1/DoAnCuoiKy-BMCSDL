using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL.Model
{
    internal class DichVu
    {
        public string MaDV { get; set; }

        public string TenDV { get; set; }

        public float DonGia { get; set; }

        public string NguoiTao { get; set; }

        public DateTime NgayTao { get; set; }

        public string NguoiSua { get; set; }

        public DateTime? NgaySua { get; set; }
    }
}
