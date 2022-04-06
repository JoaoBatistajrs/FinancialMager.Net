using FM.Domain.AggregatesModel.FinanceManagerAggregates;
using FM.Infrastrucuture.EntityConfigurations;
using MediatR;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FM.Infrastrucuture.Data
{
    public class Context : DbContext
    {
        private readonly IMediator _mediator;
        public const string DEFAULT_SCHEMA = "fn";

        public DbSet<FinanceData> FinanceDatas { get; set; }
        public DbSet<RegistryCategory> RegistryCategories { get; set; }
        public DbSet<RegistryCategory> BankAccount { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new FinanceDataConfiguration());
            builder.ApplyConfiguration(new RegistryCategoryConfiguration());
            builder.ApplyConfiguration(new BankAccountConfiguration());

        }

    }
}

