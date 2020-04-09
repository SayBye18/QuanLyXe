using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
   
    public class NccRepo: RepoBase<Ncc,NccDTO>, INccRepo
    {
        public NccRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
