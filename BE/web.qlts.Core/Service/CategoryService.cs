using AutoMapper;
using web.qlts.Application.Dto.CategoryDto;
using web.qlts.Application.Entity;
using web.qlts.Application.Interface;
using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Application.Service
{
    /// <summary>
    /// Implement Interface Category Service
    /// </summary>
    public class CategoryService : BaseService<Domain.Entity.Category, CategoryDto, CategoryInsertDto, CategoryUpdateDto, CategoryTranferDto>, ICategoryService
    {
        #region Field
        private readonly Domain.Interface.Repository.ICategoryRepository _categoryRepository;
        #endregion

        #region Constructor
        public CategoryService(Domain.Interface.Repository.ICategoryRepository categoryRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(categoryRepository, mapper, unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion


    }
}
