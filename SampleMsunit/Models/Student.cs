using System.ComponentModel.DataAnnotations;

namespace SampleMsunit.Models
{
    public class Student
    {
        [Key]

        public int StudentId { get; set; }

        public string StudentName { get; set; } 

        public string GroupName { get; set; }

      
    }
}
