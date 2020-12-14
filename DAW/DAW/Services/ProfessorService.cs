using DAW.Entities;
using DAW.IRepositories;
using DAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IProfessorRepository _repository;
        public ProfessorService(IProfessorRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var professor = _repository.FindById(id);
            _repository.Delete(professor);
            return _repository.SaveChanges();
        }

        public List<Professor> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Professor GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Professor prof)
        {
            _repository.Create(prof);
            return _repository.SaveChanges();
        }

        public bool Update(Professor prof)
        {
            _repository.Update(prof);
            return _repository.SaveChanges();
        }
    }
}
