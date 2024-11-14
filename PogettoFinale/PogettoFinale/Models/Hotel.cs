namespace PogettoFinale.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string Location { get; set; }
        public decimal PricePerNight { get; set; }

        // Відношення один-до-багатьох: один готель має багато кімнат
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
