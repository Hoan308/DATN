using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using web.qlts.Application.Dto.Account;
using web.qlts.Domain.Entity;

namespace web.qlts.Application.Interface
{
    public interface IAccountService : IBaseService<AccountDto, AccountInsertDto, AccountUpdateDto, AccountTranferDto>
    {
        Task<object> Login(Account account);

        Task<object> Register(Account account);

    }
}
