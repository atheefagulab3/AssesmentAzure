using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleMsunit.Models;
using SampleMsunit.Service.Interface;

namespace SampleMsunit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentservice;
        public StudentController(IStudentService studentservice)
        {
            _studentservice = studentservice;
        }

      
        [HttpGet]
        public async Task<ICollection<Student>> GetStudent()
        {
            return await _studentservice.GetStudent();
        }

       

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            try
            {
                var result = await _studentservice.AddStudent(student);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }

    }
}
