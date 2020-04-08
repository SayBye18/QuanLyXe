using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class LoaiXe
    {
        public LoaiXe()
        {
            Xe = new HashSet<Xe>();
        }

        public Guid MaLoaiXe { get; set; }
        public string TenLoaiXe { get; set; }

        public virtual ICollection<Xe> Xe { get; set; }
    }
}
