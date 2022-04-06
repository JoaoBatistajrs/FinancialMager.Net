using FM.Domain.AggregatesModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Domain.AggregatesModel.FinanceManagerAggregates
{
    class User : Entity
    {
        public string UserName { get; private set;}
        public string UserEmail { get; private set; }
        public string Senha { get; private set; }
    }
}
