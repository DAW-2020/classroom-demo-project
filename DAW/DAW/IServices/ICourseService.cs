using DAW.Entities;
using DAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.IServices
{
    public interface ICourseService
    {
        List<Course> GetAll();
        Course GetById(int id);
        bool Insert(Course course);
        bool Update(Course course);
        bool Delete(int id);

        bool RegisterStudent(StudentCourseRegister paylaod);
    }
}
