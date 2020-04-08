using AutoMapper;
using QLCHXe.Models;
using QLCHXe.ViewModels;

namespace QLCHXe.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NhanVien, NhanVienDTO>();
            
        }
    }
}
