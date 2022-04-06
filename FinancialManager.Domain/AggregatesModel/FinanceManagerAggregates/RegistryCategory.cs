using FM.Domain.AggregatesModel.Models;
using System;

namespace FM.Domain.AggregatesModel.FinanceManagerAggregates
{
    public interface IRegistryCategory
    {
        public string Name { get; }
    }

    public class RegistryCategory : Entity, IRegistryCategory
    {

        public RegistryCategory(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public string Name { get; private set; }
    }

}