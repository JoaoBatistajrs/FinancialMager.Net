using FM.Domain.AggregatesModel.FinanceManagerAggregates;
using FM.Infrastrucuture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.Infrastrucuture.EntityConfigurations
{
    public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.ToTable("BankAccount", Context.DEFAULT_SCHEMA);

            builder.Property(bc => bc.Id)
                .ValueGeneratedNever();

            builder.Property(bc => bc.Name);

        }
    }
}
