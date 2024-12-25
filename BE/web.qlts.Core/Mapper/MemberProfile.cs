using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.qlts.Application.Dto.Member;
using web.qlts.Domain.Entity;

namespace web.qlts.Application.Mapper
{
    public class MemberProfile : Profile
    {
        public MemberProfile()
        {
            CreateMap<MemberReceipt, MemberDto>();
            CreateMap<MemberInsertDto, MemberReceipt>();
            CreateMap<MemberInsertDto, Domain.Entity.MemberReceipt>();
            CreateMap<Domain.Entity.MemberReceipt, MemberDto>();
            CreateMap<MemberUpdateDto, MemberReceipt>();
            CreateMap<MemberUpdateDto, Domain.Entity.MemberReceipt>();

        }
    }
}
