using DAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.IRepositories
{
    public interface ICourseStudentRepository: IGenericRepository<CourseStudent>
    {
        CourseStudent GetByStudentAndCourse(int student, int course);
    }
}
