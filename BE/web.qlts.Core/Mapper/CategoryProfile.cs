using AutoMapper;
using web.qlts.Application.Dto.CategoryDto;
using web.qlts.Application.Entity;

namespace web.qlts.Application.Mapper
{
    /// <summary>
    /// Kế thừa Profile của Mapper
    /// </summary>
    public class CategoryProfile : Profile
    {
        /// <summary>
        /// Tạo các hàm mapper theo form mode
        /// </summary>
        public CategoryProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<Domain.Entity.Category, CategoryDto>();
            CreateMap<CategoryInsertDto, Category>();
            CreateMap<CategoryInsertDto, Domain.Entity.Category>();
            CreateMap<CategoryUpdateDto, Category>();
            CreateMap<CategoryUpdateDto, Domain.Entity.Category>();
        }
    }

}
