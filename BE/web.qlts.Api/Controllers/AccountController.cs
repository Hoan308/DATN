using Microsoft.AspNetCore.Mvc;
using web.qlts.Application.Dto.Account;
using web.qlts.Application.Interface;
using web.qlts.Domain.Entity;

namespace web.qlts.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : BaseController<AccountDto, AccountInsertDto, AccountUpdateDto, AccountTranferDto>
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService) : base(accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] Account account)
        {
            var result = await _accountService.Login(account);

            return Ok(result);

        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] Account account)
        {
            var result = await _accountService.Register(account);

            return Ok(result);
        }
    }
}
