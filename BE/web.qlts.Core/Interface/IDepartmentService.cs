using web.qlts.Application.Dto.DepartmentDto;

namespace web.qlts.Application.Interface
{
    /// <summary>
    /// Interface Department Service
    /// </summary>
    /// Author: HMDUC (17/06/2023)
    public interface IDepartmentService : IBaseService<DepartmentDto, DepartmentInsertDto, DepartmentUpdateDto, DepartmentTranferDto>
    {

    }
}
