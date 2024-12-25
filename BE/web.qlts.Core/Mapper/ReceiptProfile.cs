using AutoMapper;
using web.qlts.Application.Dto.ReceiptDto;
using web.qlts.Domain.Entity;

namespace web.qlts.Application.Mapper
{
    public class ReceiptProfile : Profile
    {
        public ReceiptProfile()
        {
            CreateMap<Receipt, ReceiptDto>();
            CreateMap<Domain.Entity.Receipt, ReceiptDto>();
            CreateMap<ReceiptInsertDto, Receipt>();
            CreateMap<ReceiptInsertDto, Domain.Entity.Receipt>();
            CreateMap<ReceiptUpdateDto, Receipt>();
            CreateMap<ReceiptUpdateDto, Domain.Entity.Receipt>();
        }
    }
}
