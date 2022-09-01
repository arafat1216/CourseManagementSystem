using CourseManagementSystem.Models;

namespace CourseManagementSystem.Data
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder builder)
        {
            var context = builder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if(!context.Departments.Any())
            {
                var departments = new List<Department>() 
                {
                    new Department{DepartmentName="CSE"},
                    new Department{DepartmentName="BBA"},
                };
                context.Departments.AddRange(departments);
            }

            if (!context.Students.Any())
            {
                var students = new List<Student>()
                {
                    new Student{StudentName="Arafat",EnrollmentDate=DateTime.Parse("2022-07-01"),DepartmentId=1},
                    new Student{StudentName="Aakash",EnrollmentDate=DateTime.Parse("2022-07-02"),DepartmentId=1},

                };
                context.Students.AddRange(students);
            }

            if(!context.Courses.Any())
            {
                var courses = new List<Course>()
                {
                    new Course{CourseId=101,CourseName="Introduction To CS",Credits=3},
                    new Course{CourseId=102,CourseName="C Programming Fundamentals",Credits=3},
                    new Course{CourseId=103,CourseName="C Programming Practical",Credits=1.5M},
                };
                context.Courses.AddRange(courses);
            }

            if(!context.Enrollments.Any())
            {
                var enrollments = new List<Enrollment>()
                {
                    new Enrollment{CourseId=101,StudentId=1,Grade=Grade.A},
                    new Enrollment{CourseId=102,StudentId=1,Grade=Grade.A},
                    new Enrollment{CourseId=103,StudentId=1,Grade=Grade.A},
                    new Enrollment{CourseId=101,StudentId=2,Grade=Grade.B},
                    new Enrollment{CourseId=102,StudentId=2,Grade=Grade.A},
                    new Enrollment{CourseId=103,StudentId=2,Grade=Grade.A},

                };
                context.Enrollments.AddRange(enrollments);
            }

            context.SaveChanges();
        }
    }
}
