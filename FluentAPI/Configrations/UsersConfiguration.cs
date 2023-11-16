﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FluentAPI.Entities;

namespace FluentAPI.Configrations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .HasMaxLength(30)
                .HasDefaultValue("Irakl")
                .IsRequired();

            builder.Property(x => x.LastName)
                .HasMaxLength(30)
                .HasDefaultValue("Jokker")
                .IsRequired();

            builder.HasOne(x => x.Propiska)
                .WithOne(x => x.User)
                .HasForeignKey<Propiska>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade); 

            builder.HasMany(x =>x.Home)
                .WithOne(x =>x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}



