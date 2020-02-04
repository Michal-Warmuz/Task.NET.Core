using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task.Core.Domain;

namespace Task.Data.Configurations
{
    public class GuestReservationConfiguration : IEntityTypeConfiguration<GuestReservation>
    {
        public void Configure(EntityTypeBuilder<GuestReservation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Reservation).WithMany(x => x.GuestReservations).HasForeignKey(x => x.ReservationId);
            builder.HasOne(x => x.Guest).WithMany(x => x.GuestReservations).HasForeignKey(x => x.GuestId);

            //SeedData

            builder.HasData(
                new GuestReservation(1,1,1),
                new GuestReservation(2,1,2),
                new GuestReservation(3,3,2),
                new GuestReservation(4,2,2),
                new GuestReservation(5,4,1),
                new GuestReservation(6,2,1)
                );

        }
    }
}
