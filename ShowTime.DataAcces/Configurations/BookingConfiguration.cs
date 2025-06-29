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
    public class BookingConfiguration: IEntityTypeConfiguration<Models.Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => new { b.UserId, b.FestivalId });

            builder.Property(b => b.Type)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(b => b.Price)
                   .IsRequired();

        }
    }
}
