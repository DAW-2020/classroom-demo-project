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
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ClassroomDbContext context) : base(context)
        {
        }

        public Course GetByIdJoined(int id)
        {
            var course = _context.Courses.Where(x => x.Id == id)
                .Include(x => x.Professor)
                .Include(x => x.CourseStudents)
                    .ThenInclude(x => x.Student)
                .FirstOrDefault();

            return course;
        }
    }
}
