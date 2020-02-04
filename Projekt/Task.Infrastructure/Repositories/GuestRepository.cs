using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Core.Domain;
using Task.Core.Repositories;
using Task.Data;

namespace Task.Infrastructure.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly ApplicationDbContext dbContext;

        public GuestRepository(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IReadOnlyList<Guest>> GetPetersAsync()
        {
            return await dbContext.Guests.Where(x => x.FirstName == "Piotr" && (x.City == "Wrocław" || x.City == null)).ToListAsync();
        }
    }
}
