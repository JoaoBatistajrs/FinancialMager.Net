using FM.Domain.AggregatesModel.FinanceManagerAggregates;
using FM.Infrastrucuture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.Infrastrucuture.EntityConfigurations
{
    public class FinanceDataConfiguration : IEntityTypeConfiguration<FinanceData>
    {
        public void Configure(EntityTypeBuilder<FinanceData> builder)
        {
            builder.ToTable("Finance", Context.DEFAULT_SCHEMA);

            builder.Property(fn => fn.Id)
                .ValueGeneratedNever();

            builder.Property(fn => fn.RegistryDate);

            builder.Property(fn => fn.RegistryValue);

            builder.Property(fn => fn.RegistryDescription);

            builder.HasOne<RegistryCategory>()
                .WithMany()
                .HasForeignKey(c => c.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .IsRequired(true);

        }
    }
}
