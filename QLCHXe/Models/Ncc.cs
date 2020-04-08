using System;
using System.Collections.Generic;

namespace QLCHXe.Models
{
    public partial class Ncc
    {
        public Ncc()
        {
            Hdn = new HashSet<Hdn>();
            Xe = new HashSet<Xe>();
        }

        public Guid MaNcc { get; set; }
        public string TenNcc { get; set; }
        public string DiaChi { get; set; }
        public int? Sdt { get; set; }

        public virtual ICollection<Hdn> Hdn { get; set; }
        public virtual ICollection<Xe> Xe { get; set; }
    }
}
