using AutoMapper;
using web.qlts.Application.Dto.AssetDto;
using web.qlts.Application.Entity;

namespace web.qlts.Application.Mapper
{
    /// <summary>
    /// Kế thừa Profile của Mapper
    /// </summary>
    public class AssetProfile : Profile
    {
        /// <summary>
        /// Tạo các hàm mapper theo form mode
        /// </summary>
        public AssetProfile()
        {
            CreateMap<Asset, AssetDto>();
            CreateMap<Domain.Entity.Asset, AssetDto>();
            CreateMap<Asset, AssetTranferDto>();
            CreateMap<Domain.Entity.Asset, AssetTranferDto>();
            CreateMap<AssetInsertDto, Asset>();
            CreateMap<AssetUpdateDto, Asset>();
            CreateMap<AssetUpdateDto, Domain.Entity.Asset>();
            CreateMap<AssetDto, AssetUpdateDto>();
            CreateMap<AssetInsertDto, Domain.Entity.Asset>();
        }
    }
}
