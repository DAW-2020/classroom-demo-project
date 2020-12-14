using DAW.Entities;
using DAW.IRepositories;
using DAW.IServices;
using DAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        private readonly ICourseStudentRepository _courseStudentRepository;
        public CourseService(ICourseRepository repository, ICourseStudentRepository courseStudentRepository)
        {
            this._repository = repository;
            this._courseStudentRepository = courseStudentRepository;
        }

        public bool Delete(int id)
        {
            var course = _repository.FindById(id);
            _repository.Delete(course);
            return _repository.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return _repository.GetAllActive();
        }

        public Course GetById(int id)
        {
            return _repository.GetByIdJoined(id);
        }

        public bool Insert(Course course)
        {
            _repository.Create(course);
            return _repository.SaveChanges();
        }

        public bool Update(Course course)
        {
            _repository.Update(course);
            return _repository.SaveChanges();
        }

        public bool RegisterStudent(StudentCourseRegister paylaod)
        {
            var entity = new CourseStudent
            {
                CourseId = paylaod.CourseId,
                StudentId = paylaod.StudentId
            };

            _courseStudentRepository.Create(entity);
            return _repository.SaveChanges();
        }

        public bool RemoveStudentFromCourse(StudentCourseRegister payload)
        {
            var entity = _courseStudentRepository.GetByStudentAndCourse(payload.StudentId, payload.CourseId);
            _courseStudentRepository.HardDelete(entity);
            return _courseStudentRepository.SaveChanges();
        }
    }
}
