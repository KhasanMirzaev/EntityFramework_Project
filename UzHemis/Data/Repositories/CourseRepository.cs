using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzHemis.Data.Contexts;
using UzHemis.Data.IRepositories;
using UzHemis.Models;

namespace UzHemis.Data.Repositories
{
    internal class CourseRepository : ICourseRepository
    {
        AppDbContext appDbContext = new AppDbContext();

        public Course Create(Course course)
        {
            var newCourse = appDbContext.Courses.Add(course).Entity;

            appDbContext.SaveChanges();

            return newCourse;
        }

        public bool Delete(int Id)
        {
            Course checker = appDbContext.Courses.FirstOrDefault(x => x.Id == Id);

            if (checker == null)
                return false;

            appDbContext.Remove(checker);

            appDbContext.SaveChanges();

            return true;
        }

        public Course Get(int Id)
        {
            return appDbContext.Courses.Include(y => y.Students).FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Course> GetAll()
        {
            return appDbContext.Courses.Include(y => y.Students);
        }

        public Course Update(int Id, Course course)
        {
            Course existingCourse = appDbContext.Courses.FirstOrDefault(x => x.Id == Id);

            if (existingCourse != null)
            {
                existingCourse.Name = course.Name;
                existingCourse.Description = course.Description;
                existingCourse.Price = course.Price;
                existingCourse.Data = course.Data;
            }

            appDbContext.Courses.Update(existingCourse);

            appDbContext.SaveChanges();

            return existingCourse;

        }
    }
}
