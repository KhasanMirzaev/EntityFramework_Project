using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzHemis.Models
{
    internal class Student
    {
        public Student()
        {
            this.Courses = new List<Course>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public List<Course> Courses { get; set; }
    }
}
