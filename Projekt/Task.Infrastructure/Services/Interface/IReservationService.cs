using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Infrastructure.Commands;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Services.Interface
{
    public interface IReservationService
    {
        Task<IReadOnlyList<ReservationDto>> GetAllAsync();
        void SaveReservationWithGuests(ReservationWithGuestsCommand command);
    }
}
