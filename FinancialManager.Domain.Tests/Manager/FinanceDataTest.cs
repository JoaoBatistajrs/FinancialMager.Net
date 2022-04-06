using FM.Domain.AggregatesModel.FinanceManagerAggregates;
using System;
using Xunit;

namespace FM.Domain.Tests.Manager
{
    public class FinanceDataTest
    {
        [Fact]
        private void FinanceData_WhenDataParametersareok_ShouldCreateFinanceData ()
        {
            var register = new FinanceData(DateTime.UtcNow, 120.40, "despesas médicas",  RegistryType.Variable);
            Assert.NotNull(register);
        }

        [Fact]
        private void RegistryCategory_WhenDataParametersareok_ShouldCreateRegistryCategory()
        {
            var register = new RegistryCategory("Farmacia");
            Assert.NotNull(register);
        }

        [Fact]
        private void RegistryBankAccount_WhenDataParametersareok_ShouldCreateRegistryCategory()
        {
            var register = new BankAccount("Banco Itau");
            Assert.NotNull(register);
        }
    }
}
