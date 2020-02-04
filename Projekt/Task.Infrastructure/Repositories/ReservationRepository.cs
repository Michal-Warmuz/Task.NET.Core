using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Core.Domain;
using Task.Core.Repositories;
using Task.Data;

namespace Task.Infrastructure.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ReservationRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IReadOnlyList<Reservation>> GetAllAsync()
        {
            return await dbContext.Reservations.ToListAsync();
        }

        public void SaveReservationWithGuests(Reservation reservation, List<Guest> guests)
        {
                dbContext.Reservations.Add(reservation);
                dbContext.SaveChanges();

                foreach (var guest in guests)
                {
                    dbContext.Guests.Add(guest);
                    dbContext.SaveChanges();

                    var reservationGuest = new GuestReservation(guest.Id, reservation.Id);

                    dbContext.GuestReservations.Add(reservationGuest);
                }

                dbContext.SaveChanges();
            }
    }
}
