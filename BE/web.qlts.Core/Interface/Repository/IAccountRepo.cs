using web.qlts.Domain.Entity;

namespace web.qlts.Application.Interface.Repository
{
    public interface IAccountRepo : IBaseRepository<Account>
    {
        Task<Account> GetAccount(Account account);

        Task<bool> InsertAccount(Account account);
    }
}
