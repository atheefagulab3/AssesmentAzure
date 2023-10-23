using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleMsunit.Controllers;
using SampleMsunit.Models;
using SampleMsunit.Repository.Interface;
using SampleMsunit.Service.Implementation;
using System.Collections.Generic;
using System.Linq;

namespace SampleMsunit.Tests
{
    [TestClass]
    public class StudentsControllerTests
    {

        private readonly Mock<IStudentRepo> _studentRepoMock;
        private readonly StudentService _studentService;

        public StudentsControllerTests()
        {
            _studentRepoMock = new Mock<IStudentRepo>();
            _studentService = new StudentService(_studentRepoMock.Object);
        }

        [TestMethod]
        public async Task GetStudents_returns_Students()
        {
            //Arrange

            var student = new List<Student>
            {
                new (){
                StudentId = 1,
                StudentName ="Pavithra",
                GroupName ="BioMaths"
                },
                new (){
                StudentId = 2,
                StudentName ="Yuvasree",
                GroupName ="ComputerScience"
                },
            };

            _studentRepoMock.Setup(repo => repo.GetStudent()).ReturnsAsync(student);//Behaviour Setup

            //Act
            var result = await _studentService.GetStudent();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);

        }
    }
}

