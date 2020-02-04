using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Infrastructure.Dtos;

namespace Task.Infrastructure.Services.Interface
{
    public interface IGuestService
    {
        Task<IReadOnlyList<GuestDto>> GetPetersAsync();
    }
}
