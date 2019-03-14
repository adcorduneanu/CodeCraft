using System;

namespace CraftCode.Day2
{
    public interface IAccountStatement
    {
        void GetTransactions();
        void RecordTransaction(int amount, DateTime date);
        void GetBalance();
    }
}