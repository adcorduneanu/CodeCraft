using CraftCode.Day2;
using Moq;
using NUnit.Framework;

namespace Tests
{
    public class AccountServiceShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Increase_Balance_When_Deposit()
        {
            AccountService accountService=new AccountService();
            accountService.Deposit(100);
        }
    }

    public class PrinStatementFeature
    {
        private Mock<IPrinter> printer = new Mock<IPrinter>();

        [Test]
        public void Print_Statement_Containing_Transactions_In_Reverse_Chronological_Order()
        {
            AccountService accountService = new AccountService();

            accountService.Deposit(1000);
            accountService.Withdraw(-100);
            accountService.Deposit(500);

            accountService.PrintStatement();

            printer.Verify(x => x.PrintLine() == "DATE  |   AMOUNT  |   BALANCE");
            printer.Verify(x => x.PrintLine() == "10/04/2014  |   500  |   1400");
            printer.Verify(x => x.PrintLine() == "02/04/2014  |   -100  |   900");
            printer.Verify(x => x.PrintLine() == "01/04/2014  |   1000  |   1000");
        }
    }
}