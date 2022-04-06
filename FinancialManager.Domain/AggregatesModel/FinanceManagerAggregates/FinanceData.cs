using FM.Domain.AggregatesModel.Models;
using System;
using System.Collections.Generic;

namespace FM.Domain.AggregatesModel.FinanceManagerAggregates
{

    public interface IFinanceData
    {
        public DateTime RegistryDate { get; }
        public double RegistryValue { get; }
        public string RegistryDescription { get; }
        public RegistryType Type { get;  }
        public IReadOnlyList<RegistryCategory> Category { get; }
    }

    public class FinanceData : Entity, IFinanceData
    {

        public FinanceData (DateTime date, double value, string description, RegistryType type) 
        {
            Id = Guid.NewGuid();
            RegistryDate = date;
            RegistryValue = value;
            RegistryDescription = description;
            Type = type;
        }

        public DateTime RegistryDate { get; private set; }
        public double RegistryValue { get; private set; }
        public string RegistryDescription { get; private set; }
        public RegistryType Type { get; private set; }
        public IReadOnlyList<RegistryCategory> Category { get; private set; }

    }
}
