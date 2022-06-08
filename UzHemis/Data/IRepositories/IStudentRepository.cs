using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzHemis.Models;

namespace UzHemis.Data.IRepositories
{
    internal interface IStudentRepository
    {
        Student Create(Student student);
        Student Update(int Id, Student student);
        bool Delete(int Id);
        Student Get(int Id);
        IEnumerable<Student> GetAll();
        Student AddCourse(int Id, Course course);
    }
}
