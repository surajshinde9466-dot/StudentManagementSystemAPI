using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly ILogger<StudentController> _logger;

        public StudentController(
            IStudentService studentService,
            ILogger<StudentController> logger)
        {
            _studentService = studentService;
            _logger = logger;
        }

        // GET: api/Student
        [HttpGet]
        public IActionResult GetStudents()
        {
            _logger.LogInformation("Fetching all students.");

            var students = _studentService.GetAll();

            _logger.LogInformation("Fetched {Count} students.", students.Count);

            return Ok(students);
        }

        // GET: api/Student/5
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            _logger.LogInformation("Fetching student with Id: {Id}", id);

            var student = _studentService.GetById(id);

            if (student == null)
            {
                _logger.LogWarning("Student with Id {Id} not found.", id);
                return NotFound("Student not found.");
            }

            _logger.LogInformation("Student with Id {Id} fetched successfully.", id);

            return Ok(student);
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            _logger.LogInformation("Adding new student: {Name}", student.Name);

            var newStudent = _studentService.Add(student);

            _logger.LogInformation("Student added successfully with Id: {Id}", newStudent.Id);

            return Ok(newStudent);
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            _logger.LogInformation("Updating student with Id: {Id}", id);

            var updatedStudent = _studentService.Update(id, student);

            if (updatedStudent == null)
            {
                _logger.LogWarning("Student with Id {Id} not found for update.", id);
                return NotFound("Student not found.");
            }

            _logger.LogInformation("Student with Id {Id} updated successfully.", id);

            return Ok(updatedStudent);
        }

        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            _logger.LogInformation("Deleting student with Id: {Id}", id);

            var deleted = _studentService.Delete(id);

            if (!deleted)
            {
                _logger.LogWarning("Student with Id {Id} not found for deletion.", id);
                return NotFound("Student not found.");
            }

            _logger.LogInformation("Student with Id {Id} deleted successfully.", id);

            return Ok(new
            {
                Message = "Student deleted successfully."
            });
        }
    }
}