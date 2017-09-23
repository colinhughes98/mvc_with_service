using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC.Common.Interfaces;
using MVC.Core.Interfaces;
using MVC.Core.Models;

namespace MVC.Core.Service
{
    public class UserService : IUserService
    {
        private readonly IMVCDBRepo _repo;

        public UserService(IMVCDBRepo repo)
        {
            _repo = repo;
        }

        public User GetUser()
        {
            var result = _repo.GetSomeData();
            return new User {UserName = result.Name};
        }
    }
}
