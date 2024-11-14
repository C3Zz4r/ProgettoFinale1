namespace PogettoFinale.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        // Відношення один-до-багатьох: клієнт може мати багато бронювань
        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
