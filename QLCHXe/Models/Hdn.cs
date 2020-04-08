using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class Hdn
    {
        public Hdn()
        {
            CtHdn = new HashSet<CtHdn>();
        }

        public Guid MaHdn { get; set; }
        public Guid? MaNcc { get; set; }
        public Guid? MaNv { get; set; }
        public DateTime? NgayNhap { get; set; }

        public virtual Ncc MaNccNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<CtHdn> CtHdn { get; set; }
    }
}
