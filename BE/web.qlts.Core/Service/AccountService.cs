using AutoMapper;
using web.qlts.Application.Dto.Account;
using web.qlts.Application.Interface;
using web.qlts.Domain.Entity;
using web.qlts.Domain.Interface.Repository;

namespace web.qlts.Application.Service
{
    public class AccountService : BaseService<Account, AccountDto, AccountInsertDto, AccountUpdateDto, AccountTranferDto>, IAccountService
    {
        private readonly Domain.Interface.Repository.IAccountRepo _accountRepo;

        public AccountService(Domain.Interface.Repository.IAccountRepo accountRepo, IMapper mapper, IUnitOfWork unitOfWork) : base(accountRepo, mapper, unitOfWork)
        {
            _accountRepo = accountRepo;

        }


        /// <summary>
        /// Hàm lấy thông tin người dùng 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<object> Login(Account account)
        {
            var result = new Dictionary<string, object>();
            var user = await _accountRepo.GetAccount(account);

            if (user == null)
            {
                result["isLogin"] = false;
            }
            else
            {
                result["isLogin"] = true;
                result["user"] = user;
            }

            return result;

        }

        /// <summary>
        /// Thêm mới người dùng
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<object> Register(Account account)
        {
            var result = new Dictionary<string, object>();
            var user = await _accountRepo.GetAccount(account);

            if (user != null)
            {
                result["isSuccess"] = false;
                result["ErrorCode"] = "DUPLICATE";
            }
            else
            {
                var insert = await _accountRepo.InsertAccount(account);

                if (insert)
                {
                    result["isSuccess"] = true;
                }
            }

            return result;
        }
    }
}
