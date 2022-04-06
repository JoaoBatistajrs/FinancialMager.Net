using FM.Domain.AggregatesModel.Models;
using System;

namespace FM.Domain.AggregatesModel.FinanceManagerAggregates
{
    public interface IBankAccount
    {
        public string Name { get; }
    }

    public class BankAccount : Entity, IBankAccount
    {
        public BankAccount(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public string Name { get; private set; }
    }
}
