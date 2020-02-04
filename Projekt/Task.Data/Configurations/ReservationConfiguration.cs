using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Task.Core.Domain;

namespace Task.Data.Configurations
{
    class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Provision).IsRequired(false);
            builder.Property(x => x.Source).IsRequired(false);

            builder.Property(x => x.CheckInDate).IsRequired();
            builder.Property(x => x.CheckOutDate).IsRequired();
            builder.Property(x => x.Code).IsRequired().HasMaxLength(10);
            builder.Property(x => x.CreatedAt).IsRequired();
            builder.Property(x => x.Currency).IsRequired();
            builder.Property(x => x.Price).IsRequired();


            //SeedData

            builder.HasData(
                new Reservation(1,"AASS!2", DateTime.Now, 345, "PLN", new DateTime(2019, 11, 10), new DateTime(2019, 11, 7), null, null),
                new Reservation(2,"AASS!3", DateTime.Now, 220, "PLN", new DateTime(2018, 9, 10), new DateTime(2019, 9, 7), 20, null),
                new Reservation(3,"AASS!4", DateTime.Now, 110, "PLN", new DateTime(2019, 9, 10), new DateTime(2019, 9, 7), null, null),
                new Reservation(4,"AASS!5", DateTime.Now, 500, "PLN", new DateTime(2015, 3, 10), new DateTime(2019, 3, 7), null, null),
                new Reservation(5,"AASS!6", DateTime.Now, 532, "PLN", new DateTime(2015, 1, 10), new DateTime(2019, 1, 7), 102, null),
                new Reservation(6,"AASS!7", DateTime.Now, 708, "PLN", new DateTime(2017, 5, 10), new DateTime(2019, 5, 7), 44, null)
                );

            
        }
    }
}
