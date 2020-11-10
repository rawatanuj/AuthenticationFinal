using Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication.Repository
{
    public interface IAuthRepository
    {
        public bool UserLoginRepo(Login model);
    }
}
