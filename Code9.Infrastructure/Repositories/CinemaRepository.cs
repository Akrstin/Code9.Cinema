using Code9.Domain.Interfaces;
using Code9.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace Code9.Infrastructure.Repositories
{
    public class CinemaRepository : ICinemaRepository
    {
        private readonly CinemaDbContext _dbContext;

        public CinemaRepository(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Cinema>> GetAllCinemas()
        {
            return await _dbContext.Cinemas.ToListAsync();
        }
         public async Task<Cinema> AddNewCinema(Cinema cinema)
        {
            _dbContext.Cinemas.Add(cinema);
            await _dbContext.SaveChangesAsync();
                return cinema;
        }

        public async Task<Cinema> UpdateCinema(Cinema cinema)
        {
            _dbContext.Cinemas.Update(cinema);
            await _dbContext.SaveChangesAsync();
            return cinema;
        }
        public async Task DeleteCinema(Cinema cinema)
        {
            _dbContext.Remove(cinema);

            await _dbContext.SaveChangesAsync();
        }
        public async Task<Cinema> GetCinema(Guid id)
        {
            return await _dbContext.Cinemas.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}