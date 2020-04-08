using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            BaoHanh = new HashSet<BaoHanh>();
            Hdn = new HashSet<Hdn>();
            Hdx = new HashSet<Hdx>();
        }

        public Guid MaNv { get; set; }
        public string TenNv { get; set; }
        public bool? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public string ChucVu { get; set; }
        public DateTime? NgaySinh { get; set; }

        public virtual ICollection<BaoHanh> BaoHanh { get; set; }
        public virtual ICollection<Hdn> Hdn { get; set; }
        public virtual ICollection<Hdx> Hdx { get; set; }
    }
}
