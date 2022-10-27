using System;
using CashMachine.Exceptions;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMachine.Tests
{
    [TestClass]
    public class CashMachineTests
    {
        private readonly ICashMachine _machine = new CashMachine();

        [TestMethod]
        [DataRow(15)]
        [DataRow(40)]
        public void Withdraw_CorrectAmount(int amount)
        {
            // Act
            var result = _machine.Withdraw(amount);

            // Assert
            result.Should().Be(amount);
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(-5)]
        [DataRow(14)]
        public void Withdraw_InvalidAmount_ThrowException(int amount)
        {
            // Act
            Action act = () => _machine.Withdraw(amount);

            // Assert
            act.Should().Throw<InvalidAmount>()
                .WithMessage("Invalid Amount");
        }

        [TestMethod]
        [DataRow(new int[]{4, 10, 13})]
        [DataRow(new int[]{4, 10, -5})]
        public void Insert_InvalidBanknotes_ThrowException(int[] cash)
        {
            // Act
            Action act = () => _machine.Insert(cash);

            // Assert
            act.Should().Throw<InvalidBanknote>()
                .WithMessage("Invalid Banknote");
        }
    }
}
