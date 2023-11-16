using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Configrations
{
    public class PrapiskaConfiguration : IEntityTypeConfiguration<Propiska>
    {
        public void Configure(EntityTypeBuilder<Propiska> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.GivenDay)
                .HasMaxLength(50)
                .HasDefaultValue("2023")
                .IsRequired();

            builder.HasOne(builder => builder.User)
                .WithOne(builder => builder.Propiska)
                .HasForeignKey<Users>(x => x.Id)
                .OnDelete(DeleteBehavior.Cascade);   
        }
    }

}
