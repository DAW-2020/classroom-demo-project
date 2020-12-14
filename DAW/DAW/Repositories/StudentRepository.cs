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
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ClassroomDbContext context) : base(context)
        {
        }

        public Student GetByIdJoined(int id)
        {
            var student = _context.Students.Where(x => x.Id == id)
                .Include(x => x.CourseStudents)
                .FirstOrDefault();

            return student;
        }
    }
}
