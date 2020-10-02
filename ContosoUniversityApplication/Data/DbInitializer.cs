using ContosoUniversityApplication.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversityApplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Dakota",LastName="Rowe",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Elisabeth",LastName="Goodwin",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Meadow",LastName="Andrews",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Kaitlin",LastName="Meyers",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Alexa",LastName="Grimes",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Hana",LastName="Phillips",EnrollmentDate=DateTime.Parse("2020-10-01")},
            new Student{FirstName="Noelle",LastName="Mosley",EnrollmentDate=DateTime.Parse("2020-10-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{Id=1050,Title="Introdution to Computing and Programming",Credits=3},
            new Course{Id=4022,Title="Artificial Intelligence I",Credits=3},
            new Course{Id=4041,Title="Data Structures and Discrete Mathematics I",Credits=3},
            new Course{Id=1045,Title="Introduction to Machine Learning",Credits=4},
            new Course{Id=3141,Title="Computer Algorithms I",Credits=4},
            new Course{Id=2021,Title="Software Engineering I",Credits=3},
            new Course{Id=2042,Title="Object Oriented Programming",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentId=1,CourseId=1050,Grade=Grade.A},
            new Enrollment{StudentId=1,CourseId=4022,Grade=Grade.C},
            new Enrollment{StudentId=1,CourseId=4041,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=1045,Grade=Grade.B},
            new Enrollment{StudentId=2,CourseId=3141,Grade=Grade.F},
            new Enrollment{StudentId=2,CourseId=2021,Grade=Grade.F},
            new Enrollment{StudentId=3,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=1050},
            new Enrollment{StudentId=4,CourseId=4022,Grade=Grade.F},
            new Enrollment{StudentId=5,CourseId=4041,Grade=Grade.C},
            new Enrollment{StudentId=6,CourseId=1045},
            new Enrollment{StudentId=7,CourseId=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}

