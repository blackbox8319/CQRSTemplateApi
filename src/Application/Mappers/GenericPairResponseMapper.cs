using Application.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappers
{
    public class GenericPairResponseMapper : Profile
    {
        public GenericPairResponseMapper() =>
            CreateMap<GenericPair, GenericPairResponse>().ReverseMap();
    }
}
