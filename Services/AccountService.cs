using Business_Objects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _repository;
        public AccountService()
        {
            _repository = new AccountRepository();
        }

        public AccountMember GetAccountById(string accountId)
        {
            return _repository.GetAccountById(accountId);
        }
    }
}
