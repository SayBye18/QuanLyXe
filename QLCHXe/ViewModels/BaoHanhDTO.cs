using System;

namespace QLCHXe.ViewModels
{
    public class BaoHanhDTO
    {
         public Guid MaBh { get; set; }
        public Guid? MaNv { get; set; }
        public Guid? MaKh { get; set; }
        public Guid? MaXe { get; set; }
        public string ThoiGianBh { get; set; }
        public DateTime? NgayMua { get; set; }


    }
}