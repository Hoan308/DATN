using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web.qlts.Application.Dto.Account
{
    public class AccountTranferDto
    {
        public Guid AccountId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Telephone { get; set; }
        public string? Address { get; set; }
    }
}
