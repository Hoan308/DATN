using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Infrastructure.Repository
{
    /// <summary>
    /// Implement Interface Category Repository
    /// </summary>
    public class CategoryRepository : BaseRepository<Domain.Entity.Category>,ICategoryRepository
    {

        public CategoryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
