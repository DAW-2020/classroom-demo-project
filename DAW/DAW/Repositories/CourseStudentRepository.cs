using DAW.Data;
using DAW.Entities;
using DAW.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Repositories
{
    public class CourseStudentRepository : GenericRepository<CourseStudent>, ICourseStudentRepository
    {
        public CourseStudentRepository(ClassroomDbContext context) : base(context)
        {
        }

        public CourseStudent GetByStudentAndCourse(int student, int course)
        {
            return _context.CourseStudents.Where(x => x.StudentId == student && x.CourseId == course)
                .FirstOrDefault();
        }
    }
}
