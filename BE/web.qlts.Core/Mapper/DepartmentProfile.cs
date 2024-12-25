using AutoMapper;
using web.qlts.Application.Dto.DepartmentDto;
using web.qlts.Application.Entity;

namespace web.qlts.Application.Mapper
{
    /// <summary>
    /// Kế thừa Profile của Mapper
    /// </summary>
    public class DepartmentProfile : Profile
    {
        /// <summary>
        /// Tạo các hàm mapper theo form mode
        /// </summary>
        public DepartmentProfile()
        {
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentInsertDto, DepartmentDto>();
            CreateMap<DepartmentInsertDto, Domain.Entity.Department>();
            CreateMap<Domain.Entity.Department, DepartmentDto>();
            CreateMap<DepartmentUpdateDto, DepartmentDto>();
            CreateMap<DepartmentUpdateDto, Domain.Entity.Department>();
        }
    }
}
