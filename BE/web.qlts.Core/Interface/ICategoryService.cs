using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.qlts.Application.Dto.CategoryDto;

namespace web.qlts.Application.Interface
{
    /// <summary>
    /// Interface Category Service
    /// </summary>
    /// Author: HMDUC (17/06/2023)
    public interface ICategoryService : IBaseService<CategoryDto, CategoryInsertDto, CategoryUpdateDto, CategoryTranferDto>
    {

    }
}
