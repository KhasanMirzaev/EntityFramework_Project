
using System;
using System.Collections.Generic;
using UzHemis.Data.IRepositories;
using UzHemis.Data.Repositories;
using UzHemis.Models;

namespace UzHemis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICourseRepository courseRepository = new CourseRepository();
            IStudentRepository studentRepository = new StudentRepository();


            //Courses
            Course course1 = new Course() { Name = ".NET"};
            Course course2 = new Course() { Name = "Python" };
            Course course3 = new Course() { Name = "JavaScript"};
            Course course4 = new Course() { Name = "Go"};
            Course course5 = new Course() { Name = "Java"};
            Course course6 = new Course() { Name = "C"};


            //Students
            Student student1 = new Student() { FirstName = "Xasan", LastName = "Mirzayev"};
            Student student2 = new Student() { FirstName = "Jaloliddin", LastName = "Rustamov"};
            //Student student = new Student() { FirstName = "Javohir", LastName = "Mirtojiyev", Courses = new List<Course>() { new Course() { Name = "Java", Id = 5 } } };



            //student1.Courses.Add(course1);
            //student1.Courses.Add(course2);

            //student2.Courses.Add(course3);
            //student2.Courses.Add(course4);

            //student3.Courses.Add(course5);



            //CreatingOfCourses
            courseRepository.Create(course6);
            ////courseRepository.Create(course7);
            ////courseRepository.Create(course8);
            //courseRepository.Create(course9);
            //courseRepository.Create(course10);


            //CreatingOfStudents
            //studentRepository.Create(student);
            //studentRepository.Create(student5);
            //studentRepository.Create(student6);


            //studentRepository.AddCourse(2, course6);



            //courseRepository.Delete(6);

            var names = studentRepository.Get(2);

            foreach (var i in names.Courses)
                Console.WriteLine(i.Name);

        }
    }
}
