using System.Linq;
using CashMachine.Exceptions;

namespace CashMachine
{
    public class CashMachine : ICashMachine
    {
        public int Withdraw(int amount)
        {
            if (amount % 5 != 0 || amount <= 0)
            {
                throw new InvalidAmount();
            }

            return amount;
        }

        public void Insert(int[] cash)
        {
            int[] acceptedBanknotes = { 5, 10, 20, 50, 100};

            if (cash.Any(banknote => !acceptedBanknotes.Contains(banknote)))
            {
                throw new InvalidBanknote();
            }
        }
    }
}
