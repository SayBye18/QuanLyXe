using System;

namespace QLCHXe.ViewModels
{
    public class KhachHangDTO
    {
         public Guid MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public bool? GioiTinh { get; set; }
        public string Cmnd { get; set; }
        public string Sdt { get; set; }
        public DateTime? NgaySinh { get; set; }
    }
}