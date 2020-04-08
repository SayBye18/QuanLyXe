using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class CtHdn
    {
        public Guid Id { get; set; }
        public Guid? MaHdn { get; set; }
        public Guid? MaXe { get; set; }
        public int? DonGia { get; set; }
        public int? SoLuong { get; set; }
        public int? ThueVat { get; set; }
        public Guid? MaKho { get; set; }

        public virtual Hdn MaHdnNavigation { get; set; }
        public virtual Kho MaKhoNavigation { get; set; }
        public virtual Xe MaXeNavigation { get; set; }
    }
}
