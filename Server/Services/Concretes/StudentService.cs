using AutoMapper;
using Server.Entities;
using Server.Entities.DTOs;
using Server.Repositories.Abstracts;
using Server.Services.Abstracts;

namespace Server.Services.Concretes
{
  public class StudentService : IStudentService
  {
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public StudentService(IStudentRepository studentRepository, IMapper mapper)
    {
      _studentRepository = studentRepository;
      _mapper = mapper;
    }

    public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
    {
      var students = await _studentRepository.GetAllAsync();

      if (!students.Any())
      {
        throw new Exception("Öğrenci bulunamadı.");
      }

      return _mapper.Map<IEnumerable<StudentDto>>(students);
    }

    public async Task<StudentDto> GetByIdStudentAsync(int id)
    {
      var student = await _studentRepository.GetByIdAsync(id);

      if (student is null)
      {
        throw new Exception("Aradığınız öğrenci bulunamadı.");
      }

      return _mapper.Map<StudentDto>(student);
    }

    public async Task AddStudentAsync(StudentCreateDTO studentCreateDTO)
    {
      var addStudent = _mapper.Map<Student>(studentCreateDTO);

      if (string.IsNullOrWhiteSpace(addStudent.FirstName) && string.IsNullOrWhiteSpace(addStudent.LastName))
      {
        throw new Exception("Öğrenci adı ve soyadı boş olamaz.");
      }

      await _studentRepository.AddAsync(addStudent);
    }

    public async Task DeleteStudentAsync(int id)
    {
      await _studentRepository.DeleteAsync(id);
    }

    public async Task UpdateStudentAsync(StudentUpdateDto studentUpdateDto)
    {
      var updateStudent = _mapper.Map<Student>(studentUpdateDto);

      if (string.IsNullOrWhiteSpace(updateStudent.FirstName) && string.IsNullOrWhiteSpace(updateStudent.LastName))
      {
        throw new Exception("Öğrenci adı ve soyadı boş olamaz.");
      }

      await _studentRepository.UpdateStudentAsync(updateStudent);
    }
  }
}