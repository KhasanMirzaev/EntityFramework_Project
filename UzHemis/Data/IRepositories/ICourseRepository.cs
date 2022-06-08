using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzHemis.Models;

namespace UzHemis.Data.IRepositories
{
    internal interface ICourseRepository
    {
        Course Create(Course course);
        Course Update(int Id, Course course);
        bool Delete(int Id);
        Course Get(int Id);
        IEnumerable<Course> GetAll();
    }
}
