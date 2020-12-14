using DAW.Data;
using DAW.Entities;
using DAW.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Repositories
{
    public class ProfessorRepository : GenericRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(ClassroomDbContext context) : base(context)
        {
        }

        public Professor GetByIdJoined(int id)
        {
            var prof = _context.Professors.Where(x => x.Id == id)
                .Include(x => x.Courses)
                .FirstOrDefault();

            return prof;
        }
    }
}
