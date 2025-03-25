using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Repositories.Context;

namespace Server.Repositories.Concretes
{
  public class GradeRepository : Repository<Grade, int>, IGradeRepository
  {
    private readonly AppDbContext _context;

    public GradeRepository(AppDbContext context) : base(context)
    {
      _context = context;
    }

    public async Task UpdateGradeAsync(Grade grade)
    {
      var updateGrade = await GetByIdAsync(grade.Id);

      updateGrade.Midterm = grade.Midterm;
      updateGrade.FinalExam = grade.FinalExam;
      updateGrade.Quiz = grade.Quiz;
      updateGrade.StudentId = grade.StudentId;
      updateGrade.CourseId = grade.CourseId;

      await SaveAsync();
    }
  }
}