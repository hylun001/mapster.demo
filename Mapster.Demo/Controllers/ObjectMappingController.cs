using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mapster.Demo.Controllers
{
    [ApiController]
    [Route("api/objectmappings")]
    public class ObjectMappingController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ObjectMappingController> _logger;

        public ObjectMappingController(ILogger<ObjectMappingController> logger)
        {
            _logger = logger;
        }

        [HttpGet("simple")]
        public IEnumerable<WeatherForecastDto> GetSimpleTest()
        {
            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();

            return result.Adapt<IEnumerable<WeatherForecastDto>>();
        }

        [HttpGet("complex")]
        public List<StudentDto> GetComplexTest()
        {
            Random random = new Random();

            var students = new List<Student>();
            for (int i = 0; i < 20; i++)
            {
                students.Add(new Student()
                {
                    Age = random.Next(1, 100),
                    CID = DateTime.Now.ToString(),
                    Id = Guid.NewGuid().ToString(),
                    Name = i.ToString(),
                    Cource = new Cource()
                    {
                        ID = $"{i}{i}",
                        CourceName = $"Hello Word{i}",
                        Grade = i * 5
                    }
                });
            }

            return students.Adapt<List<StudentDto>>();
        }
    }
}
