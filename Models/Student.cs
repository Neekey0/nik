using Microsoft.AspNetCore.Mvc;

namespace nik.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
    }
}
