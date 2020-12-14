using DAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.IServices
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        bool Insert(Student student);
        bool Update(Student student);
        bool Delete(int id);
    }
}
