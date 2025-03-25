using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Server.Entities;
using Server.Repositories.Abstracts;
using Server.Services.Abstracts;

namespace Server.Services.Concretes
{
  public class GradeService : IGradeService
  {
    private readonly IGradeRepository _gradeRepository;
    private readonly IMapper _mapper;
    public GradeService(IGradeRepository gradeRepository, IMapper mapper)
    {
      _gradeRepository = gradeRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<GradeDto>> GetAllGradesAsync()
    {
      var grades = await _gradeRepository.GetAllAsync();

      if (!grades.Any())
      {
        throw new Exception("Sınav bulunamadı.");
      }

      return _mapper.Map<IEnumerable<GradeDto>>(grades);
    }

    public async Task<GradeDto> GetByIdGrade(int id)
    {
      var grade = await _gradeRepository.GetByIdAsync(id);

      if (grade is null)
      {
        throw new Exception("Aradığınız sınav bulunamadı.");
      }

      return _mapper.Map<GradeDto>(grade);
    }

    public async Task AddGradeAsync(GradeCreateDto gradeCreateDto)
    {
      var addGrade = _mapper.Map<Grade>(gradeCreateDto);
      await _gradeRepository.AddAsync(addGrade);
    }

    public async Task DeleteGradeAsync(int id)
    {
      await _gradeRepository.DeleteAsync(id);
    }

    public async Task UpdateGradeAsync(GradeUpdateDto gradeUpdateDto)
    {
      var updateGrade = _mapper.Map<Grade>(gradeUpdateDto);
      await _gradeRepository.UpdateGradeAsync(updateGrade);
    }
  }
}