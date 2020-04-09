using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
    public class HdnRepo: RepoBase<Hdn,HdnDTO>, IHdnRepo
    {
        public HdnRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {
            
        }
    }
}