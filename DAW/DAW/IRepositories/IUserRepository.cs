using DAW.Entities;
using DAW.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator4_453.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetByUserAndPassword(string username, string password);
    }
}
