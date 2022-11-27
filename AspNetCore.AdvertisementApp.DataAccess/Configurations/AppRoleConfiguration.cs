﻿using AspNetCore.AdvertisementApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetCore.AdvertisementApp.DataAccess.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.Property(x => x.Definition).HasMaxLength(300).IsRequired();
            builder.HasData(new AppRole[]
            {
                new()
                {
                    Id=1,
                    Definition="Member"
                },
                new()
                {
                    Id=2,
                    Definition="Admin"
                }
            });
        }
    }
}
