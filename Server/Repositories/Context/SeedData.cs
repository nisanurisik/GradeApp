using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Server.Entities;
using Server.Repositories.Context;

namespace Server.Repositories
{
  public static class SeedData
  {
    public static void TestData(IApplicationBuilder app)
    {
      using var scope = app.ApplicationServices.CreateScope();
      var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

      if (context.Database.GetPendingMigrations().Any())
      {
        context.Database.Migrate();
      }

      if (!context.Faculties.Any())
      {
        context.Faculties.AddRange(
            new Faculty { FacultyName = "Engineering" },
            new Faculty { FacultyName = "Science" }
        );
        context.SaveChanges();
      }

      if (!context.Departments.Any())
      {
        context.Departments.AddRange(
            new Department { DepartmentName = "Computer Engineering", FacultyId = 1 },
            new Department { DepartmentName = "Mechanical Engineering", FacultyId = 1 },
            new Department { DepartmentName = "Physics", FacultyId = 2 }
        );
        context.SaveChanges();
      }

      if (!context.Classes.Any())
      {
        context.Classes.AddRange(
            new Class { ClassLevel = 1 },
            new Class { ClassLevel = 2 },
            new Class { ClassLevel = 3 }
        );
        context.SaveChanges();
      }

      if (!context.Teachers.Any())
      {
        context.Teachers.AddRange(
            new Teacher { FirstName = "Nisa Nur", LastName = "Işık", Email = "nisa@uni.edu", Phone = "123456789", DepartmentId = 1 },
            new Teacher { FirstName = "Muhammet Onur", LastName = "Aydınoğlu", Email = "onur@uni.edu", Phone = "987654321", DepartmentId = 2 }
        );
        context.SaveChanges();
      }

      if (!context.Courses.Any())
      {
        context.Courses.AddRange(
            new Course { CourseName = "Algorithms", Credits = 5, TeacherId = 1, DepartmentId = 1 },
            new Course { CourseName = "Thermodynamics", Credits = 4, TeacherId = 2, DepartmentId = 2 }
        );
        context.SaveChanges();
      }

      if (!context.Students.Any())
      {
        context.Students.AddRange(
            new Student
            {

              FirstName = "Elia",
              LastName = "AI",
              Email = "elisa@student.com",
              Phone = "5055055050",
              Gender = 'F',
              BirthDate = new DateTime(2030, 3, 15),
              Address = "Samsun",
              StudentNumber = "S1001",
              DepartmentId = 1,
              ClassId = 1
            },
            new Student
            {

              FirstName = "Yağız",
              LastName = "AI",
              Email = "yagiz@student.com",
              Phone = "5055055051",
              Gender = 'M',
              BirthDate = new DateTime(2028, 7, 22),
              Address = "Samsun",
              StudentNumber = "S1002",
              DepartmentId = 2,
              ClassId = 2
            }
        );
        context.SaveChanges();
      }

      if (!context.Grades.Any())
      {
        context.Grades.AddRange(
            new Grade { StudentId = 1, CourseId = 1, Midterm = 85, FinalExam = 90, Quiz = 80 },
            new Grade { StudentId = 2, CourseId = 2, Midterm = 70, FinalExam = 75, Quiz = 65 }
        );
        context.SaveChanges();
      }
    }
  }
}
