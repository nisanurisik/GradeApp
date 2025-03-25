using AutoMapper;
using Server.Entities;
using Server.Entities.DTOs;

namespace Server.Mappers
{
  public class StudentMapperProfile : Profile
  {
    public StudentMapperProfile()
    {
      CreateMap<Student, StudentDto>();
      CreateMap<StudentCreateDTO, Student>();
      CreateMap<StudentUpdateDto, Student>();
    }
  }
}