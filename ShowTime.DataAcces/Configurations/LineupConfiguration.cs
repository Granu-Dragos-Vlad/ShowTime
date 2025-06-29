using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowTime.DataAcces.Configurations
{
    public class LineupConfiguration : IEntityTypeConfiguration<Models.Lineup>
    {
        public void Configure(EntityTypeBuilder<Models.Lineup> builder)
        {
            builder.HasKey(l => new { l.FestivalId, l.ArtistId });

            builder.Property(l => l.Stage)
                   .HasMaxLength(100);

            builder.Property(l => l.StartTime)
                  .IsRequired();

     
        }
    }
}
