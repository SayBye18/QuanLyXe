using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
    public class LoaiXeRepo: RepoBase<LoaiXe,LoaiXeDTO>, ILoaiXeRepo
    {
        public LoaiXeRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}