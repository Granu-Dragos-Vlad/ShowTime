
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShowTime.DataAcces.Models;

namespace ShowTime.DataAcces.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Models.Artist>
    {


        public void Configure(EntityTypeBuilder<Artist> builder)
        {

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).IsRequired().HasMaxLength(255);

            builder.Property(a => a.Image).IsRequired()
                   .HasMaxLength(255);

            builder.Property(a => a.Genre).IsRequired()
                   .HasMaxLength(100);

            builder.HasMany(a => a.Lineups)
                   .WithOne(l => l.Artist)
                   .HasForeignKey(l => l.ArtistId)
                   .OnDelete(DeleteBehavior.Cascade);
        }

    }


}
