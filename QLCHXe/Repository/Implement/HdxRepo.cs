using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
   public class HdxRepo: RepoBase<Hdx,HdxDTO>, IHdxRepo
    {
        public HdxRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {
            
        }
    }
}