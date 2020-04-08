using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;
using System;

namespace QLCHXe.Repository.Implement
{
    public class NhanVienRepo : RepoBase<NhanVien, NhanVienDTO>, INhanVienRepo
    {
        public NhanVienRepo(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
