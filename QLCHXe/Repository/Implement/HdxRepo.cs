using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
   public class HdxRepo: RepoBase<Hdn,HdnDTO>, IHdnRepo
    {
        public HdxRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {
            
        }
    }
}