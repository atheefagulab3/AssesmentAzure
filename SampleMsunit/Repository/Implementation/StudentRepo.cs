using Microsoft.EntityFrameworkCore;
using SampleMsunit.Models;
using SampleMsunit.Repository.Interface;

namespace SampleMsunit.Repository.Implementation
{
    public class StudentRepo:IStudentRepo
    {
        private readonly StudentDbContext _studentContext;

        public StudentRepo(StudentDbContext con)
        {
            _studentContext = con;
        }

        public async Task<ICollection<Student>> GetStudent()

        {
            var users = await _studentContext.Students.ToListAsync();
            return users;
        }
       
        public async Task<Student> AddStudent(Student student)
        {

            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();

            return student;
        }
    }
}
