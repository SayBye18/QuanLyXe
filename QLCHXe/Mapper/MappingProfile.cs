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
            CreateMap<Acccount,AccountDTO>();
            CreateMap<BaoHanh,BaoHanhDTO>();
            CreateMap<Hdn,HdnDTO>();
            CreateMap<KhachHang,KhachHangDTO>();
            CreateMap<Kho,KhoDTO>();
            CreateMap<LoaiXe,LoaiXeDTO>();
            CreateMap<Ncc,NccDTO>();
            CreateMap<Xe,XeDTO>();
            
        }
    }
}
