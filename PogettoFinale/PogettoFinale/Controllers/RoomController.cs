using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PogettoFinale.Data;
using PogettoFinale.Models;

namespace PogettoFinale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly BookingDbContext _context;

        public RoomController(BookingDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            return await _context.Rooms.Include(r => r.Hotel).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Room>> CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRooms), new { id = room.RoomId }, room);
        }
    }
}

