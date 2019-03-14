using System;

namespace CraftCode.Day2
{
    public class AccountService
    {
        private readonly IAccountDAO _accountDao;
        private readonly IPrinter _printer;

        public AccountService()
        {
           
        }

        public void Deposit(int amount)
        {
            _accountDao.RecordTransaction(amount, DateTime.Now);
        }

        public void Withdraw(int amount)
        {
            _accountDao.RecordTransaction(amount, DateTime.Now);
        }

        public void PrintStatement()
        {
            _accountDao.PrintTranasctionLog(_printer);
        }
    }
}
