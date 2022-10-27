using System;

namespace CashMachine.Exceptions
{
    public class InvalidAmount : Exception
    {
        public InvalidAmount() : base("Invalid Amount") { }
    }
}
