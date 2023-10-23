using SampleMsunit.Models;

namespace SampleMsunit.Service.Interface
{
    public interface IStudentService
    {
        public Task<ICollection<Student>> GetStudent();

        public Task<Student> AddStudent(Student student);
    }
}
