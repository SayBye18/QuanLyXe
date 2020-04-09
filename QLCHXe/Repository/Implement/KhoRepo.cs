using System;
using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;

namespace QLCHXe.Repository.Implement
{
    public class KhoRepo: RepoBase<Kho,KhoDTO>, IKhoRepo
    {
        public KhoRepo (IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}