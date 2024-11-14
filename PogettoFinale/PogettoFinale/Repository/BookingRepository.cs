using Microsoft.EntityFrameworkCore;
using PogettoFinale.Data;
using PogettoFinale.Interfaces;
using PogettoFinale.Models;


namespace PogettoFinale.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingDbContext _context;

        public BookingRepository(BookingDbContext context)
        {
            _context = context;
        }

        public async Task<Booking> CreateBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();
            return booking;
        }

        public async Task<List<Booking>> GetBookingsForCustomer(int customerId)
        {
            return await _context.Bookings
                                 .Where(b => b.ClientId == customerId)
                                 .ToListAsync();
        }
    }
}
