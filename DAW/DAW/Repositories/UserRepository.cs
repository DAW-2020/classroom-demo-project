using DAW.Data;
using DAW.Entities;
using DAW.Repositories;
using Laborator4_453.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laborator4_453.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ClassroomDbContext context) : base(context)
        {
        }

        public User GetByUserAndPassword(string username, string password)
        {
            return _table.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
