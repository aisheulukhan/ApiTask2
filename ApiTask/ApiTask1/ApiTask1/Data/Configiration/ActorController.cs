using ApiTask1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTask1.Data.Configiration
{
    public class ActorController : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(a => a.FullName).IsRequired().HasMaxLength(255);
            builder.Property(a => a.ImageUrl).IsRequired();
            builder.Property(a => a.IsDeleted).HasDefaultValue(false);
            builder.Property(a => a.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(a => a.ModifiedDate).HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
