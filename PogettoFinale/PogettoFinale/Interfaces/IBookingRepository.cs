using PogettoFinale.Models;

namespace PogettoFinale.Interfaces
{
    public interface IBookingRepository
    {
        Task<Booking> CreateBooking(Booking booking);
        Task<List<Booking>> GetBookingsForCustomer(int customerId);
    }
}
