using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class StudentRepository : Repository<Student, int>, IStudentRepository
  {
    private readonly AppDbContext _context;

    public StudentRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateStudentAsync(Student student)
    {
      var updateStudent = await GetByIdAsync(student.Id);

      updateStudent.FirstName = student.FirstName;
      updateStudent.LastName = student.LastName;
      updateStudent.BirthDate = student.BirthDate;
      updateStudent.Gender = student.Gender;
      updateStudent.Email = student.Email;
      updateStudent.Phone = student.Phone;
      updateStudent.Address = student.Address;
      updateStudent.StudentNumber = student.StudentNumber;
      updateStudent.ClassId = student.ClassId;
      updateStudent.DepartmentId = student.DepartmentId;

      await SaveAsync();
    }
  }
}