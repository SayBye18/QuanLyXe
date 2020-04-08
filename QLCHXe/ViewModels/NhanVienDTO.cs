using System;

namespace QLCHXe.ViewModels
{
    public class NhanVienDTO
    {
        public Guid MaNv { get; set; }
        public string TenNv { get; set; }
        public bool? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public string ChucVu { get; set; }
        public DateTime? NgaySinh { get; set; }
    }
}
