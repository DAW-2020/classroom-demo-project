using DAW.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.IServices
{
    public interface IProfessorService
    {
        List<Professor> GetAll();
        Professor GetById(int id);
        bool Insert(Professor prof);
        bool Update(Professor prof);
        bool Delete(int id);
    }
}
