using AutoMapper;
using Server.Entities;
using Server.Entities.DTOs;
using Server.Repositories.Abstracts;
using Server.Services.Abstracts;

namespace Server.Services.Concretes
{
  public class TeacherService : ITeacherService
  {
    private readonly ITeacherRepository _teacherRepository;
    private readonly IMapper _mapper;

    public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
    {
      _teacherRepository = teacherRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<TeacherDto>> GetAllTeachersAsync()
    {
      var teachers = await _teacherRepository.GetAllAsync();

      if (!teachers.Any())
      {
        throw new Exception("Öğretmen bulunamadı.");
      }

      return _mapper.Map<IEnumerable<TeacherDto>>(teachers);
    }

    public async Task<TeacherDto> GetByIdTeacherAsync(int id)
    {
      var teacher = await _teacherRepository.GetByIdAsync(id);

      if (teacher is null)
      {
        throw new Exception("Aradığınız öğretmen bulunamadı.");
      }

      return _mapper.Map<TeacherDto>(teacher);
    }

    public async Task AddTeacherAsync(TeacherCreateDto teacherCreateDto)
    {
      var addTeacher = _mapper.Map<Teacher>(teacherCreateDto);

      if (string.IsNullOrWhiteSpace(addTeacher.FirstName) && string.IsNullOrWhiteSpace(addTeacher.LastName))
      {
        throw new Exception("Öğretmen adı ve soyadı boş olamaz.");
      }

      await _teacherRepository.AddAsync(addTeacher);
    }

    public async Task DeleteTeacherAsync(int id)
    {
      await _teacherRepository.DeleteAsync(id);
    }

    public async Task UpdateTeacherAsync(TeacherUpdateDto teacherUpdateDto)
    {
      var updateTeacher = _mapper.Map<Teacher>(teacherUpdateDto);

      if (string.IsNullOrWhiteSpace(updateTeacher.FirstName) && string.IsNullOrWhiteSpace(updateTeacher.LastName))
      {
        throw new Exception("Öğretmen adı ve soyadı boş olamaz.");
      }

      await _teacherRepository.UpdateTeacherAsync(updateTeacher);
    }
  }
}