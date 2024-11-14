namespace PogettoFinale.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
