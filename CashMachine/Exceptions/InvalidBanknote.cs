using System;

namespace CashMachine.Exceptions
{
    public class InvalidBanknote : Exception
    {
        public InvalidBanknote() : base("Invalid Banknote") { }
    }
}
