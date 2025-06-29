using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShowTime.DataAcces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTime.DataAcces.Configurations
{
    public class FestivalConfiguration : IEntityTypeConfiguration<Models.Festival>
    {

        public void Configure(EntityTypeBuilder<Festival> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name)
                  .IsRequired()
                  .HasMaxLength(255);

            builder.Property(f => f.Location).IsRequired()
                   .HasMaxLength(255);

            builder.Property(f => f.SplashArt)
                  .HasMaxLength(255);

            builder.Property(f => f.StartDate)
                   .IsRequired();

            builder.Property(f => f.EndDate)
                   .IsRequired();

            builder.Property(f => f.Capacity)
                   .IsRequired();

            builder.HasMany(f => f.Lineups)
              .WithOne(l => l.Festival)
              .HasForeignKey(l => l.FestivalId)
              .OnDelete(DeleteBehavior.Cascade);


            builder.HasMany(f => f.Bookings)
                   .WithOne(b => b.Festival)
                   .HasForeignKey(b => b.FestivalId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
