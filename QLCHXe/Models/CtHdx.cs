using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class CtHdx
    {
        public Guid Id { get; set; }
        public Guid? MaHdx { get; set; }
        public Guid? MaXe { get; set; }
        public string SoKhung { get; set; }
        public string SoMay { get; set; }
        public int? SoLuong { get; set; }
        public int? ThueVat { get; set; }
        public int? Gia { get; set; }
        public Guid? MaKho { get; set; }

        public virtual Hdx MaHdxNavigation { get; set; }
        public virtual Kho MaKhoNavigation { get; set; }
        public virtual Xe MaXeNavigation { get; set; }
    }
}
