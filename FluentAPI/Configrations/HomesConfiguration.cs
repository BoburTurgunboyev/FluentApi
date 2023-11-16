using FluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentAPI.Configrations
{
    public class HomesConfiguration : IEntityTypeConfiguration<Homes>
    {
        public void Configure(EntityTypeBuilder<Homes> builder)
        {
            builder.HasKey(x => x.Id);


            builder.Property(x => x.Location)
                .HasMaxLength(50)
                .HasDefaultValue("Angren")
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Home)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
