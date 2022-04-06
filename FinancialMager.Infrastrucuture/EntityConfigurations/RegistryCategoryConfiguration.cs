using FM.Domain.AggregatesModel.FinanceManagerAggregates;
using FM.Infrastrucuture.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FM.Infrastrucuture.EntityConfigurations
{
    public class RegistryCategoryConfiguration : IEntityTypeConfiguration<RegistryCategory>
    {
        public void Configure(EntityTypeBuilder<RegistryCategory> builder)
        {
            builder.ToTable("Category", Context.DEFAULT_SCHEMA);

            builder.Property(cr => cr.Id)
                .ValueGeneratedNever();

            builder.Property(cr => cr.Name);

        }
    }
}
