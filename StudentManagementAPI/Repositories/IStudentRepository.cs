using StudentManagementAPI.Models;

namespace StudentManagementAPI.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student Add(Student student);
        Student Update(int id, Student student);
        bool Delete(int id);
    }
}