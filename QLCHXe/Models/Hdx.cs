using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class Hdx
    {
        public Hdx()
        {
            CtHdx = new HashSet<CtHdx>();
        }

        public Guid MaHdx { get; set; }
        public Guid? MaNv { get; set; }
        public Guid? MaKh { get; set; }
        public DateTime? NgayXuat { get; set; }

        public virtual NhanVien MaNv1 { get; set; }
        public virtual KhachHang MaNvNavigation { get; set; }
        public virtual ICollection<CtHdx> CtHdx { get; set; }
    }
}
