using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;
using System;

namespace QLCHXe.Repository.Implement
{
    public class BaoHanhRepo : RepoBase<BaoHanh, BaoHanhDTO>, IBaoHanhRepo
    {
        public BaoHanhRepo(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}