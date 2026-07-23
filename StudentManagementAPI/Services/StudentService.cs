using StudentManagementAPI.Models;
using StudentManagementAPI.Repositories;

namespace StudentManagementAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetAll()
        {
            return _repository.GetAll();
        }

        public Student GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Student Add(Student student)
        {
            return _repository.Add(student);
        }

        public Student Update(int id, Student student)
        {
            return _repository.Update(id, student);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}