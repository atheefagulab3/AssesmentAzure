using SampleMsunit.Models;

namespace SampleMsunit.Repository.Interface
{
    public interface IStudentRepo
    {
        public Task<ICollection<Student>> GetStudent();

        public Task<Student> AddStudent(Student student);
    }
}
