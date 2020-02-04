using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Core.Domain;

namespace Task.Core.Repositories
{
    public interface IReservationRepository
    {
        Task<IReadOnlyList<Reservation>> GetAllAsync();
        void SaveReservationWithGuests(Reservation reservation, List<Guest> guests);
    }
}
