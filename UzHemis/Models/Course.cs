using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzHemis.Models
{
    internal class Course
    {
        public Course()
        {
            this.Students = new List<Student>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Data { get; set; }

        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public List<Student> Students { get; set; }
    }
}
