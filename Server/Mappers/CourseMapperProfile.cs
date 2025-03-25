using AutoMapper;
using Server.Entities;
using Server.Entities.DTOs;

namespace Server.Mappers
{
  public class CourseMapperProfile : Profile
  {
    public CourseMapperProfile()
    {
      CreateMap<Course, CourseDto>();
      CreateMap<CourseCreateDto, Course>();
      CreateMap<CourseUpdateDto, Course>();
    }
  }
}