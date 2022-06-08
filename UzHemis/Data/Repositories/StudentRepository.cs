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
    internal class StudentRepository : IStudentRepository
    {
        AppDbContext appDbContext = new AppDbContext();

        public Student Create(Student student)
        {
            var newStudent = appDbContext.Students.Add(student);

            appDbContext.SaveChanges();

            return newStudent.Entity;
        }

        public bool Delete(int Id)
        {
            Student checker = appDbContext.Students.FirstOrDefault(x => x.Id == Id);

            if (checker == null)
                return false;

            appDbContext.Remove(checker);

            appDbContext.SaveChanges();

            return true;
        }

        public Student Get(int Id)
        {
            return appDbContext.Students.Include(y => y.Courses).FirstOrDefault(x => x.Id == Id);

        }

        public IEnumerable<Student> GetAll()
        {
            return appDbContext.Students.Include(y => y.Courses);
        }

        public Student Update(int Id, Student student)
        {
            Student existingStudent = appDbContext.Students.FirstOrDefault(x => x.Id == Id);

            if (existingStudent != null)
            {
                existingStudent.FirstName = student.FirstName;
                existingStudent.LastName = student.LastName;
                existingStudent.Age = student.Age;
                existingStudent.Email = student.Email;
                existingStudent.Courses = student.Courses;
            }

            appDbContext.Students.Update(existingStudent);

            appDbContext.SaveChanges();

            return existingStudent;
        }

        public Student AddCourse(int Id, Course course)
        {
            Student existingStudent = appDbContext.Students.FirstOrDefault(x => x.Id == Id);

            existingStudent.Courses.Add(course);

            appDbContext.Update(existingStudent);

            appDbContext.SaveChanges();

            return existingStudent;
        }
    }
}
