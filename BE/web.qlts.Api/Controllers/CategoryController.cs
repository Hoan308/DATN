using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using web.qlts.Application.Dto.CategoryDto;
using web.qlts.Application.Interface;

namespace web.qlts.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CategoryController : BaseController<CategoryDto, CategoryInsertDto, CategoryUpdateDto, CategoryTranferDto>
    {
        #region Field
        private readonly ICategoryService _categoryService;
        #endregion

        #region Constructor
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion
    }
}
