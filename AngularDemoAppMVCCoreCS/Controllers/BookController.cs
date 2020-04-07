using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularDemoAppMVCCoreCS.Models;
using Microsoft.Extensions.Logging;

namespace AngularDemoAppMVCCoreCS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> booklist = new List<Book>();

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book>Get()
        {
            if(booklist.Count == 0)
            {
                booklist.Add(
                    new Book
                    {
                        Id = 101,
                        Title = "C",
                        Author = "Yashwant",
                        Price = 500
                    }
                    );
                booklist.Add(
                    new Book
                    {
                        Id = 103,
                        Title = ".NET",
                        Author = "Jaymin",
                        Price = 800
                    }
                    );
                booklist.Add(
                    new Book
                    {
                        Id = 106,
                        Title = "Angular",
                        Author = "Romit",
                        Price = 600
                    }
                    );
            }

            return booklist;
        }
    }
}