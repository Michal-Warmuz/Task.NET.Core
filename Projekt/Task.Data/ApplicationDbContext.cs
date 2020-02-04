using Microsoft.EntityFrameworkCore;
using Task.Core.Domain;
using Task.Data.Configurations;

namespace Task.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<GuestReservation> GuestReservations { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new GuestConfiguration());
            builder.ApplyConfiguration(new ReservationConfiguration());
            builder.ApplyConfiguration(new GuestReservationConfiguration());
        }
    }
}
