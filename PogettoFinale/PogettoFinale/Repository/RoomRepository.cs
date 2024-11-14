using Microsoft.EntityFrameworkCore;
using PogettoFinale.Data;
using PogettoFinale.Interfaces;
using PogettoFinale.Models;

namespace PogettoFinale.Repository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly BookingDbContext _context;

        public RoomRepository(BookingDbContext context)
        {
            _context = context;
        }

        public async Task<List<Room>> GetAll()
        {
            return await _context.Rooms.ToListAsync();
        }

        public async Task<Room> GetById(int id)
        {
            return await _context.Rooms
                                 .FirstOrDefaultAsync(r => r.RoomId == id);
        }

        public async Task<List<Room>> GetRoomsByHotelId(int hotelId)
        {
            return await _context.Rooms
                                 .Where(r => r.HotelId == hotelId)
                                 .ToListAsync();
        }
    }
}
