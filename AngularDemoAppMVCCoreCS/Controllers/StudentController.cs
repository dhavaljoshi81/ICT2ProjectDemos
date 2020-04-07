using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularDemoAppMVCCoreCS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngularDemoAppMVCCoreCS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> studentList = new List<Student>();

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        // GET: Student
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            if (studentList.Count == 0)
            {
                studentList.Add(new Student
                {
                    ID = 1,
                    Name = "Akash",
                    Age = 22,
                    City = "Surat"
                });
                studentList.Add(new Student
                {
                    ID = 2,
                    Name = "Jaya",
                    Age = 23,
                    City = "Ahmedabad"
                });
                studentList.Add(new Student
                {
                    ID = 3,
                    Name = "Lokesh",
                    Age = 22,
                    City = "Vadodara"
                });
                studentList.Add(new Student
                {
                    ID = 4,
                    Name = "Purvi",
                    Age = 21,
                    City = "Surat"
                });
            }
            return studentList.ToArray();
        }
    }
}