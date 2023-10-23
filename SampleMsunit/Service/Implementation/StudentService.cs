using SampleMsunit.Models;
using SampleMsunit.Repository.Interface;
using SampleMsunit.Service.Interface;

namespace SampleMsunit.Service.Implementation
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepo _repository;

        public StudentService(IStudentRepo repository)
        {
            _repository = repository;
        }
      
        public async Task<ICollection<Student>> GetStudent()
        {
            var student = await _repository.GetStudent();
            if (student != null)
            {
                return student;
            }
            throw new NullReferenceException("Student details not found");
        }
      

        public async Task<Student> AddStudent(Student student)
        {
            var stu = await _repository.AddStudent(student);
            if (stu != null)
            {
                return stu;
            }
            throw new NullReferenceException("Please check the  details");

        }
    }
}
