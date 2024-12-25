using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.qlts.Application.Dto.DepartmentDto;
using web.qlts.Application.Entity;
using web.qlts.Application.Interface;
using web.qlts.Application.Interface.Repository;
using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Application.Service
{
    /// <summary>
    /// Implement Department Interface
    /// </summary>
    public class DepartmentService : BaseService<Domain.Entity.Department, DepartmentDto, DepartmentInsertDto, DepartmentUpdateDto, DepartmentTranferDto>, IDepartmentService
    {
        #region Field
        private readonly Domain.Interface.Repository.IDepartmentRepository _departmentRepository;
        #endregion

        #region Constructor
        public DepartmentService(Domain.Interface.Repository.IDepartmentRepository departmentRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(departmentRepository, mapper, unitOfWork)
        {
            _departmentRepository = departmentRepository;

        }
        #endregion


    }
}
