using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class Xe
    {
        public Xe()
        {
            BaoHanh = new HashSet<BaoHanh>();
            CtHdn = new HashSet<CtHdn>();
            CtHdx = new HashSet<CtHdx>();
            CtKho = new HashSet<CtKho>();
        }

        public Guid MaXe { get; set; }
        public string TenXe { get; set; }
        public Guid? MaLoaiXe { get; set; }
        public string Mau { get; set; }
        public int? Gia { get; set; }
        public Guid? MaNcc { get; set; }

        public virtual LoaiXe MaLoaiXeNavigation { get; set; }
        public virtual Ncc MaNccNavigation { get; set; }
        public virtual ICollection<BaoHanh> BaoHanh { get; set; }
        public virtual ICollection<CtHdn> CtHdn { get; set; }
        public virtual ICollection<CtHdx> CtHdx { get; set; }
        public virtual ICollection<CtKho> CtKho { get; set; }
    }
}
