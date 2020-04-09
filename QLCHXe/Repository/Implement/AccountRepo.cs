using QLCHXe.Models;
using QLCHXe.Repository.Interface;
using QLCHXe.ViewModels;
using System;

namespace QLCHXe.Repository.Implement
{
    public class AccountRepo : RepoBase<Acccount, AccountDTO>, IAccountRepo
    {
        public AccountRepo(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}