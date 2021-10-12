using System;

namespace Mapster.Demo
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }

    public class WeatherForecastDto
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }


    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CID { get; set; }
        public Cource Cource { get; set; }
    }

    public class Cource
    {
        public string ID { get; set; }
        public string CourceName { get; set; }
        public double Grade { get; set; }
    }

    public class StudentDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string CourceName { get; set; }
        public double Grade { get; set; }

    }


}
