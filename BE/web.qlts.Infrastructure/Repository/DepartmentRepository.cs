using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Infrastructure.Repository
{
    /// <summary>
    /// Implement Interface Department Repository
    /// </summary>
    public class DepartmentRepository : BaseRepository<Domain.Entity.Department>, IDepartmentRepository
    {
        public DepartmentRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }


    }
}
