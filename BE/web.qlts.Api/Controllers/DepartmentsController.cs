using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using web.qlts.Application.Dto.DepartmentDto;
using web.qlts.Application.Interface;

namespace web.qlts.Api.Controllers
{
    /// <summary>
    /// Api Department
    //  Author: HMDUC (14/06/2023)
    /// </summary>
    [Route("api/v1/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseController<DepartmentDto, DepartmentInsertDto, DepartmentUpdateDto, DepartmentTranferDto>
    {
        #region Field
        private readonly IDepartmentService _departmentService;
        #endregion

        #region Constructor
        public DepartmentsController(IDepartmentService departmentService) : base(departmentService)
        {
            _departmentService = departmentService;
        }

        #endregion

    }
}
