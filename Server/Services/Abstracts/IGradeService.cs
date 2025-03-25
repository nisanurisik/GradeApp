using Server.Entities;

namespace Server.Services.Abstracts
{
  public interface IGradeService
  {
    Task<IEnumerable<GradeDto>> GetAllGradesAsync();
    Task<GradeDto> GetByIdGrade(int id);
    Task AddGradeAsync(GradeCreateDto gradeCreateDto);
    Task UpdateGradeAsync(GradeUpdateDto gradeUpdateDto);
    Task DeleteGradeAsync(int id);
  }
}