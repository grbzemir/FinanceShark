using AutoMapper;
using FinShark.Dtos.Stock;
using FinShark.Models;

namespace FinShark.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Stock, StockDto>();
            CreateMap<StockDto,Stock>();
        }
    }
}
