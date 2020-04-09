using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
    public class KhachHangRepo: RepoBase<KhachHang,KhachHangDTO>, IKhachHangRepo
    {
        public KhachHangRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}