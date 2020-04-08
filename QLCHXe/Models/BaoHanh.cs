using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class BaoHanh
    {
        public Guid MaBh { get; set; }
        public Guid? MaNv { get; set; }
        public Guid? MaKh { get; set; }
        public Guid? MaXe { get; set; }
        public string ThoiGianBh { get; set; }
        public DateTime? NgayMua { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual Xe MaXeNavigation { get; set; }
    }
}
