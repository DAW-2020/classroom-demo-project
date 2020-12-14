using DAW.Entities;
using DAW.IRepositories;
using DAW.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        public StudentService(IStudentRepository repository)
        {
            this._repository = repository;
        }

        public bool Delete(int id)
        {
            var student = _repository.FindById(id);
            _repository.Delete(student);
            return _repository.SaveChanges();
        }

        public List<Student> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Student GetById(int id)
        {
            return _repository.FindById(id);
        }

        public bool Insert(Student student)
        {
            _repository.Create(student);
            return _repository.SaveChanges();
        }

        public bool Update(Student student)
        {
            _repository.Update(student);
            return _repository.SaveChanges();
        }
    }
}
