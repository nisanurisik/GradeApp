using AutoMapper;
using Server.Entities;

namespace Server.Mappers
{
  public class GradeMapperProfile : Profile
  {
    public GradeMapperProfile()
    {
      CreateMap<Grade, GradeDto>();
      CreateMap<GradeCreateDto, Grade>();
      CreateMap<GradeUpdateDto, Grade>();
    }
  }
}