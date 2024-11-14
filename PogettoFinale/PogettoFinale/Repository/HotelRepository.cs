using Microsoft.EntityFrameworkCore;
using PogettoFinale.Data;
using PogettoFinale.Models;
using PogettoFinale.Interfaces;


namespace PogettoFinale.Repository
{
    public class HotelRepository : IHotelRepository
    {
        private readonly BookingDbContext _context;

        public HotelRepository(BookingDbContext context)
        {
            _context = context;
        }

        public async Task<List<Hotel>> GetAll()
        {
            return await _context.Hotels.Include(h => h.Rooms).ToListAsync();
        }

        public async Task<IEnumerable<Hotel>> SearchHotels(string query)
        {
            return await _context.Hotels
                .Where(h => h.HotelName.Contains(query) || h.Location.Contains(query))
                .ToListAsync();
        }

        public async Task<Hotel> GetById(int id)
        {
            return await _context.Hotels
                                 .Include(h => h.Rooms)
                                 .FirstOrDefaultAsync(h => h.HotelId == id);
        }

       
    }
}
