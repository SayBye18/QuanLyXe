using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class Kho
    {
        public Kho()
        {
            CtHdn = new HashSet<CtHdn>();
            CtHdx = new HashSet<CtHdx>();
            CtKho = new HashSet<CtKho>();
        }

        public Guid MaKho { get; set; }
        public string TenKho { get; set; }

        public virtual ICollection<CtHdn> CtHdn { get; set; }
        public virtual ICollection<CtHdx> CtHdx { get; set; }
        public virtual ICollection<CtKho> CtKho { get; set; }
    }
}
