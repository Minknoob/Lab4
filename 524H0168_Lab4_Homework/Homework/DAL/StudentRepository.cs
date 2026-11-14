using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class StudentRepository
    {
        private readonly SchoolDbContext _context;

        public StudentRepository()
        {
            _context = new SchoolDbContext();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.StudentID == id);
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = _context.Students.FirstOrDefault(s => s.StudentID == student.StudentID);
            if (existingStudent != null)
            {
                existingStudent.StudentName = student.StudentName;
                existingStudent.City = student.City;
                existingStudent.Age = student.Age;
                existingStudent.YearOfEnroll = student.YearOfEnroll;
                existingStudent.Major = student.Major;
                existingStudent.GPA = student.GPA;
                _context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentID == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
