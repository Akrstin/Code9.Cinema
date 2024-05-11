using Code9.Domain.Models;

namespace Code9.Domain.Interfaces
{
    public interface ICinemaRepository
    {
        public Task<List<Cinema>> GetAllCinemas();
        public Task<Cinema> AddNewCinema(Cinema cinema);
        public Task<Cinema> UpdateCinema(Cinema cinema);
    }
}
