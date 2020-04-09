using System;

namespace QLCHXe.ViewModels
{
    public class XeDTO
    {
        public Guid MaXe { get; set; }
        public string TenXe { get; set; }
        public Guid? MaLoaiXe { get; set; }
        public string Mau { get; set; }
        public int? Gia { get; set; }
        public Guid? MaNcc { get; set; }
    }
}