using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class CtKho
    {
        public Guid? MaXe { get; set; }
        public int? Soluong { get; set; }
        public Guid? MaKho { get; set; }
        public Guid Id { get; set; }

        public virtual Kho MaKhoNavigation { get; set; }
        public virtual Xe MaXeNavigation { get; set; }
    }
}
