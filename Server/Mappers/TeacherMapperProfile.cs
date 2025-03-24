using AutoMapper;
using Server.Entities;
using Server.Entities.DTOs;

namespace Server.Mappers
{
  public class TeacherMapperProfile : Profile
  {
    public TeacherMapperProfile()
    {
      CreateMap<Teacher, TeacherDto>();
      CreateMap<TeacherCreateDto, Teacher>();
      CreateMap<TeacherUpdateDto, Teacher>();
    }
  }
}