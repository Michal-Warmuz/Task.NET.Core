using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Core.Domain;

namespace Task.Core.Repositories
{
    public interface IGuestRepository
    {
        Task<IReadOnlyList<Guest>> GetPetersAsync();
    }
}
