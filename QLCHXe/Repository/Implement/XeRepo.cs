using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
    public class XeRepo: RepoBase<Xe,XeDTO>, IXeRepo
    {
        public XeRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}